using System.Windows.Forms;

namespace Renamer
{
    public static class MessageDialog
    {
        public static void ShowError(string text)
        {
            MessageBox.Show(null, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformation(string text)
        {
            MessageBox.Show(null, text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
