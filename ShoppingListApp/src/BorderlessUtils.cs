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
    public static class BorderlessUtils
    {
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessage
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-releasecapture
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

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
    }
}
