using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.src
{
    // TODO: use proper object orientated design methods to clean up this code, but for now it works

    /// <summary>
    /// Represents a class for creating customizable buttons on the title bar of a form.
    /// </summary>
    public class CornerButton
    {
        private readonly Form form;

        /// <summary>
        /// Initializes a new instance of the <see cref="CornerButton"/> class with the specified form.
        /// </summary>
        /// <param name="_form">The form to attach the buttons to.</param>
        public CornerButton(Form _form)
        {
            form = _form;
        }

        private int buttonsAdded = 0;
        private readonly Size size = new Size(25, 25);
        private const string BTN_CLOSE_NAME = "Close";
        private const string BTN_CLOSE_TEXT = "✖";
        private const string BTN_MAXIMISE_NAME = "Maximise";
        private const string BTN_MAXIMISE_TEXT = "🗖";
        private const string BTN_MINIMISE_NAME = "Minimise";
        private const string BTN_MINIMISE_TEXT = "🗕";

        // events
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

        /// <summary>
        /// Dynamically creates a title bar button on the form with the specified properties.
        /// </summary>
        /// <param name="size">The size of the button.</param>
        /// <param name="name">The internal name for the button.</param>
        /// <param name="text">The text to display on the button.</param>
        /// <param name="style">The FlatStyle of the button.</param>
        /// <param name="color">The color of the button's text.</param>
        /// <returns>The created Button object.</returns>
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

        /// <summary>
        /// Creates a ToolTip object for the specified control with the specified tooltip text.
        /// </summary>
        /// <param name="control">The control for which to create the ToolTip object.</param>
        /// <param name="tip">The tooltip text to display when the mouse hovers over the control.</param>
        /// <returns>The created ToolTip object.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the control parameter is null.</exception>
        private ToolTip CreateToolTip(Control control, string tip)
        {
            if (control is null)
                throw new ArgumentNullException($"{nameof(control)} cannot be null.");

            ToolTip toolTip = new ToolTip();

            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.AutoPopDelay = 5000;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(control, tip);

            return toolTip;
        }

        /// <summary>
        /// Creates a close button with the specified style and color on the title bar of the form.
        /// </summary>
        public void CreateCloseButton(FlatStyle style, Color color)
        {
            Button close = CreateTitlebarButton(size, "btn" + BTN_CLOSE_NAME, BTN_CLOSE_TEXT, style, color);
            close.Click += btnExit_Click;

            CreateToolTip(close, BTN_CLOSE_NAME);
        }

        /// <summary>
        /// Creates a maximize button with the specified style and color on the title bar of the form.
        /// If the MaximizeBox property of the form is set to false, the button will be disabled.
        /// </summary>
        public void CreateMaximiseButton(FlatStyle style, Color color)
        {
            Button maximise = CreateTitlebarButton(size, "btn" + BTN_MAXIMISE_NAME, BTN_MAXIMISE_TEXT, style, color);
            maximise.Click += btnMaximise_Click;

            CreateToolTip(maximise, BTN_MAXIMISE_NAME);

            if (!form.MaximizeBox)
                maximise.Enabled = false;
        }

        /// <summary>
        /// Creates a minimize button with the specified style and color on the title bar of the form.
        /// If the MinimizeBox property of the form is set to false, the button will be disabled.
        /// </summary>
        public void CreateMinimiseButton(FlatStyle style, Color color)
        {
            Button minimise = CreateTitlebarButton(size, "btn" + BTN_MINIMISE_NAME, BTN_MINIMISE_TEXT, style, color);
            minimise.Click += btnMinimise_Click;

            CreateToolTip(minimise, BTN_MINIMISE_NAME);

            if (!form.MinimizeBox)
                minimise.Enabled = false;
        }

        /// <summary>
        /// Creates the title bar buttons (close, maximize, minimize) with the specified style and color on the form.
        /// </summary>
        /// <param name="checkIfDisabled">Determines whether the method should check if the MaximizeBox and MinimizeBox properties are true before creating the buttons.</param>
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
