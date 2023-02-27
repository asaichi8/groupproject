using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.src
{
    public class BorderlessUtils
    {
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessage
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-releasecapture
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private readonly Form form;
        private int buttonsAdded = 0;
        private readonly Size size = new Size(25, 25);
        private const string BTN_CLOSE_NAME = "btnClose";
        private const string BTN_CLOSE_TEXT = "✖";
        private const string BTN_MAXIMISE_NAME = "btnMaximise";
        private const string BTN_MAXIMISE_TEXT = "🗖";
        private const string BTN_MINIMISE_NAME = "btnMinimise";
        private const string BTN_MINIMISE_TEXT = "🗕";

        public BorderlessUtils(Form _form)
        {
            form = _form;
        }

        // call SendMessage & ReleaseCapture from winapi to simulate moving title bar
        private static void Uninteractable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            const uint WM_NCLBUTTONDOWN = 0x00A1; // https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-nclbuttondown
            const uint HTCAPTION = 0x2;           // https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest

            ReleaseCapture();
            SendMessage(((Control)sender).FindForm().Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, (IntPtr)0);
        }

        public static void HookUninteractableControls(Form f)
        {
            foreach (Control c in f.Controls)
            {
                // check for interactable controls
                if (c is Button || c is CheckBox || c is TextBox || c is WebView2)
                    continue;

                c.MouseDown += Uninteractable_MouseDown;
            }

            f.MouseDown += Uninteractable_MouseDown;
        }

        private static void btnExit_Click(object sender, EventArgs e)
        {
            ((Control)sender).FindForm().Close();
        }

        private static void btnMaximise_Click(object sender, EventArgs e)
        {
            ((Control)sender).FindForm().WindowState = FormWindowState.Maximized;
        }

        private static void btnMinimise_Click(object sender, EventArgs e)
        {
            ((Control)sender).FindForm().WindowState = FormWindowState.Minimized;
        }

        private Button CreateTitlebarButton(Size size, string name, string text, FlatStyle style, Color color)
        {
            buttonsAdded++;
            Point location = new Point(form.Width - size.Width * buttonsAdded, 0);

            Button button = new Button
            {
                Location = location,
                Size = size,
                Name = name,
                Text = text,
                FlatStyle = style,
                ForeColor = color,
                UseVisualStyleBackColor = true,
                Font = form.Font,
                TabStop = false,
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderSize = 0;

            form.Controls.Add(button);

            return button;

        }

        public void CreateCloseButton(FlatStyle style, Color color)
        {
            CreateTitlebarButton(size, BTN_CLOSE_NAME, BTN_CLOSE_TEXT, style, color).Click += btnExit_Click;
        }
        public void CreateMaximiseButton(FlatStyle style, Color color)
        {
            Button b = CreateTitlebarButton(size, BTN_MAXIMISE_NAME, BTN_MAXIMISE_TEXT, style, color);
            b.Click += btnMaximise_Click;

            if (!form.MaximizeBox)
                b.Enabled = false;
        }
        public void CreateMinimiseButton(FlatStyle style, Color color)
        {
            Button b = CreateTitlebarButton(size, BTN_MINIMISE_NAME, BTN_MINIMISE_TEXT, style, color);
            b.Click += btnMinimise_Click;

            if (!form.MinimizeBox)
                b.Enabled = false;
        }

        public void CreateTitlebarButtons(FlatStyle style, Color color, bool checkIfDisabled = true)
        {
            CreateCloseButton(style, color);

            if (checkIfDisabled && form.MaximizeBox)
                CreateMaximiseButton(style, color);
            if (checkIfDisabled && form.MinimizeBox)
                CreateMinimiseButton(style, color);
        }
    }
}
