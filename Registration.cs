using DreamRend.Models;

namespace DreamRend
{
	public partial class Registration : Form
	{

		public Registration()
		{
			InitializeComponent();
			label6.Visible = false;
			numbertextBox.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Validator validator = new Validator();

			if (!validator.IsValidEmail(emailTextBox.Text))
			{
				return;
			}
			string email = emailTextBox.Text;
			if (!validator.IsValidPassword(passwordTextBox.Text))
			{
				return;
			}
			string password = passwordTextBox.Text;
			string salt = BCrypt.Net.BCrypt.GenerateSalt();
			password = BCrypt.Net.BCrypt.HashPassword(password, salt);

			if (FnametextBox.Text.Length == 0 || MnameTextBox.Text.Length == 0)
			{
				MessageBoxHelper.ShowError("Введите контактные данные");
			}
			string fname = FnametextBox.Text;
			string mname = MnameTextBox.Text;
			if (!validator.IsValidIndexComboBox((comboBox1, "Выберите способ связи")))
			{
				return;
			}
			int indexCombobox = comboBox1.SelectedIndex;

			if (numbertextBox.Text.Length == 0)
			{
				MessageBoxHelper.ShowError("Введите способ связи");
				return;
			}
			string number = numbertextBox.Text;

			using (var context = new DreamRendContext())
			{
				if (context.Users.Any(u => u.EMail == email))
				{
					MessageBoxHelper.ShowError("Почта занята");
					return;
				}

				var newUser = new User
				{
					EMail = email,
					PasswordHash = password,
					CommMethod = number,
					Salt = salt,
					Fname = fname,
					Mname = mname,
				};


				context.Users.Add(newUser);
				context.SaveChanges();
				MessageBoxHelper.ShowSuccess("Регистрация успешна!");
				this.Close();
				Autorization autorization = new Autorization();
				autorization.Show();
			}
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			Autorization autorization = new Autorization();
			autorization.Show();
			this.Close();
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				label6.Visible = true;
				numbertextBox.Visible = true;
				label6.Text = "Номер телефона";
			}
			else
			{
				label6.Visible = true;
				numbertextBox.Visible = true;
				label6.Text = "Telegram id";
			}
		}
	}
}
