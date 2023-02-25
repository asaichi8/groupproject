namespace ShoppingListApp.src
{
    public static class FormExtensions
    {
        /// <summary>
        /// Sets the location of the child <see cref='Form'/> to the center of the parent <see cref='Form'/>.
        /// </summary>
        /// <param name="childForm">The <see cref='Form'/> to be centered.</param>
        /// <param name="parentForm">The child's position will be centered based around this <see cref='Form'/>.</param>
        public static void CenterChild(this Form childForm, Form parentForm)
        {
            childForm.Location = new Point(
                parentForm.Location.X + (parentForm.Size.Width / 2) - (childForm.Size.Width / 2),
                parentForm.Location.Y + (parentForm.Size.Height / 2) - (childForm.Size.Height / 2)
            );
        }

        /// <summary>
        /// Swaps the visibility of two forms.
        /// </summary>
        /// <param name="childForm">The <see cref='Form'/> to be displayed.</param>
        /// <param name="parentForm">The <see cref='Form'/> to be hidden/closed.</param>
        /// <param name="shouldClose">Determines whether the <see cref='Form.Close'/> or <see cref='Control.Hide()'/> method should be called.</param>
        public static void SwapForm(this Form childForm, Form parentForm, bool shouldClose = false)
        {
            childForm.Show();

            if (shouldClose)
                parentForm.Close();
            else
                parentForm.Hide();
        }
    }
}
