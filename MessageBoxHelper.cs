using System.Windows.Forms;

namespace DreamRend
{
	public static class MessageBoxHelper
	{
		public static void ShowError(string message)
		{
			MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowSuccess(string message)
		{
			MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
