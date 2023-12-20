using DreamRend.Models;

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
			CurrentUser.UserId = IsValidLogin(email, password);
			if (CurrentUser.UserId != 0)
			{
				MainPage mainPage = new MainPage();
				mainPage.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Неверные логин или пароль");
			}
		}

		private long IsValidLogin(string email, string password)
		{
			using (var context = new DreamRendContext())
			{
				var user = context.Users.FirstOrDefault(u => u.EMail == email && u.Password == password);
				if (user != null)
				{
					long inofo = user.UserId;
					return inofo;
				}
				else
				{
					return 0;
				}

			}
		}


	}
	public static class CurrentUser
	{
		public static long UserId { get; set; }
	}
}
