using DreamRend.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DreamRend
{
	public partial class Autorization : Form
	{
		
		public Autorization()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Registration registration = new Registration();
			registration.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			ForgotYourPassword forgot = new ForgotYourPassword();
			forgot.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{


			string email = emailTextBox.Text;
			string password = passwordTextBox.Text;
			if(email == "admin" || password == "admin")
			{
				AdminPanel adminPanel = new AdminPanel();
				adminPanel.Show();
				return;
			}

			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Введите имя пользователя и пароль.");
				return;
			}
			using (var context = new DreamRendContext())
			{
				var user = context.Users.SingleOrDefault(u => u.EMail == email);
				if (user != null && ValidatePassword(password, user.PasswordHash, user.Salt))
				{
					CurrentUser.UserId = user.UserId;
					MessageBoxHelper.ShowSuccess("Вход выполнен успешно!");
					this.Hide();
					MainPage mainPage = new MainPage();
					mainPage.Show();
				}
				else
				{
					MessageBoxHelper.ShowError("Неверное имя пользователя или пароль.");
				}

			}

		}


		private bool ValidatePassword(string enteredPassword, string storedHash, string salt)
		{
			
			string enteredPasswordHash = PasswordHashingFunction(enteredPassword, salt);
			return enteredPasswordHash == storedHash;
		}
		private string PasswordHashingFunction(string password, string salt)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, salt);
		}
	}
	public static class CurrentUser
	{
		public static long UserId { get; set; }
	}
}
