﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_test
{
	class BmiLevelConverter : IValueConverter
	{
		#region IValueConverter メンバ

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			double target = (double)value;
			SolidColorBrush level;

			if (target < 18.5)
				level = new SolidColorBrush(Colors.Blue);
			else if (target > 25)
				level = new SolidColorBrush(Colors.Red);
			else
				level = new SolidColorBrush(Colors.White);

			return level;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
