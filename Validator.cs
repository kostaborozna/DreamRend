namespace DreamRend
{
	internal class Validator
	{
		public bool IsValidIndexComboBox(params (ComboBox comboBox, string errorMessage)[] comboBoxData)
		{
			foreach (var data in comboBoxData)
			{
				if (data.comboBox.SelectedIndex == -1)
				{
					MessageBoxHelper.ShowError(data.errorMessage);
					return false;
				}
			}
			return true;
		}

		public bool IsValidApName(string apName)
		{
			if (string.IsNullOrEmpty(apName))
			{
				MessageBoxHelper.ShowError("Введите данные в адресс квартиры!");
				return false;
			}
			if(apName.Length > 120)
			{
				MessageBoxHelper.ShowError("Слишком длинный адресс!");
				return false;
			}
			return true;
		}

		public bool IsValidCost(string inputCost) 
		{
			if (string.IsNullOrWhiteSpace(inputCost))
			{
				MessageBoxHelper.ShowError("Введите цену!");
				return false;
			}

			if (!int.TryParse(inputCost, out int _))
			{
				MessageBoxHelper.ShowError("Введите целое число в стоимость квартиры!");
				return false;
			}

			return true;

		}

		public bool IsValidInfo(string inputInfo)
		{
			if(string.IsNullOrEmpty(inputInfo))
			{
				MessageBoxHelper.ShowError("Введите информацию о квартире!");
				return false;
			}
			if (inputInfo.Length > 5000)
			{
				MessageBoxHelper.ShowError("Слишком длинная информация");
				return false;
			}

			return true;
		}

		public bool IsValidArea(string area)
		{
			if (string.IsNullOrWhiteSpace(area))
			{
				MessageBoxHelper.ShowError("Введите цену!");
				return false;
			}

			if (!int.TryParse(area, out int a))
			{
				MessageBoxHelper.ShowError("Введите целое число в стоимость квартиры!");
				return false;
			}
			if(a < 0)
			{
				MessageBoxHelper.ShowError("Введите положительное число в стоимость квартиры!");
				return false;
			}

			return true;
		}

		public bool IsValidFloor(string floor)
		{
			if (string.IsNullOrWhiteSpace(floor))
			{
				MessageBoxHelper.ShowError("Введите этаж!");
				return false;
			}

			if (!int.TryParse(floor, out int f))
			{
				MessageBoxHelper.ShowError("Введите целое число в этаж!");
				return false;
			}
			if(f > 163 || f < 0)
			{
				MessageBoxHelper.ShowError("Такого здания не бывает!");
				return false;
			}
			

			return true;
		}
	}
}
