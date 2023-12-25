using DreamRend.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamRend
{
	public partial class AdminPanel : Form
	{
		private DreamRendContext dbContext;
		public AdminPanel()
		{
			InitializeComponent();
			dbContext = new DreamRendContext();
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{
			using (var context = new DreamRendContext())
			{
				var users = context.Users.ToList();
				if (users != null)
				{
					dataGridView1.DataSource = users;
				}
			}


			using (var context = new DreamRendContext())
			{
				var apartaments = context.Apartments.ToList();
				if (apartaments != null)
				{
					dataGridView2.DataSource = apartaments;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				// Сохранение изменений в базе данных
				dbContext.SaveChanges();
				MessageBox.Show("Изменения сохранены успешно.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Произошла ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
