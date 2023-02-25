namespace ShoppingListApp.src
{
    public static class FormExtensions
    {
        // set the location of targetForm to the center of the current form
        public static void CenterChild(this Form targetForm, Form callerForm)
        {
            targetForm.Location = new Point(
                callerForm.Location.X + (callerForm.Size.Width / 2) - (targetForm.Size.Width / 2),
                callerForm.Location.Y + (callerForm.Size.Height / 2) - (targetForm.Size.Height / 2)
            );
        }

        public static void SwapForm(this Form targetForm, Form callerForm, bool shouldClose = false)
        {
            targetForm.Show();

            if (shouldClose)
                callerForm.Close();
            else
                callerForm.Hide();
        }
    }
}
