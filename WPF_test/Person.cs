using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_test
{
    class Person : INotifyPropertyChanged
	{
		double _bmi;

		public double Height { get; set; }
        public double Weight { get; set; }
		public double Bmi
		{
			get { return _bmi; }
			set
			{
				_bmi = value;
				OnPropertyChanged("Bmi");
			}
		}

		double _heightLabel;
		public double HeightLabel
		{
			get
			{
				return _heightLabel;
			}
			set
			{
				_heightLabel = value;
				Height = _heightLabel;
				OnPropertyChanged("Height");
			}
		}

		public void Calculate()
        {
           Bmi = Weight / Math.Pow(Height, 2);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
