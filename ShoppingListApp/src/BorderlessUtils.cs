using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ShoppingListApp.src
{
    /// <summary>
    /// Provides utility methods for creating a borderless Windows Forms application.
    /// </summary>
    public static class BorderlessUtils
    {
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessage
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-releasecapture
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        /// <summary>
        /// Simulates the behavior of clicking and dragging a form's title bar.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">A <see cref="MouseEventArgs"/> object that contains the event data.</param>
        private static void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            const uint WM_NCLBUTTONDOWN = 0x00A1; // https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-nclbuttondown
            const uint HTCAPTION = 0x2;           // https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest

            ReleaseCapture();
            SendMessage(((Control)sender).FindForm().Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, (IntPtr)0);
        }

        /// <summary>
        /// Makes a form draggable by simulating the behavior of clicking and dragging its title bar.
        /// </summary>
        /// <param name="f">The form to make draggable.</param>
        public static void MakeFormDraggable(Form f)
        {
            foreach (Control c in f.Controls)
            {
                // check for interactable controls
                if (c is Button || c is CheckBox || c is TextBox || c is WebView2)
                    continue;

                c.MouseDown += Titlebar_MouseDown;
            }

            f.MouseDown += Titlebar_MouseDown;
        }
    }
}
