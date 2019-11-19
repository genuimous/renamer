using System.Windows.Forms;

namespace Utils
{
    public class MessageDialog
    {
        public static void ShowInformation(string text)
        {
            MessageBox.Show(null, text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string text)
        {
            MessageBox.Show(null, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool AskQuiestion(string text)
        {
            return MessageBox.Show(null, text, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
