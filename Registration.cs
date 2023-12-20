using DreamRend.Models;

namespace DreamRend
{
	public partial class Registration : Form
	{
		public Registration()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string email = emailTextBox.Text;
			string password = passwordTextBox.Text;
			string fname = FnametextBox.Text;
			string mname = MnameTextBox.Text;


			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				MessageBoxHelper.ShowError("Введите почту или пароль!");
				return;
			}
			if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(mname))
			{
				MessageBoxHelper.ShowError("Введите контактные данные!");
				return;
			}

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
					Password = password,
					Fname = fname,
					Mname = mname,
				};
				 
				context.Users.Add(newUser);
				context.SaveChanges();
				MessageBoxHelper.ShowSuccess("Регистрация успешна");
				this.Close();
				Autorization autorization = new Autorization();
				autorization.Show();
			}
		}
	}
}
