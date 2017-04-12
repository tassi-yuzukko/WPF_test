using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_test2.ViewModel.MyPackage;

namespace Wpf_test2.ViewModel
{
	class MainWindowViewModel : MyViewModelBase
	{
		public ICommand MyButton { get; set; }

		private int _myText;
		public int MyText
		{
			get { return _myText; }
			set
			{
				_myText = value;
				OnPropertyChanged(nameof(MyText));
				(MyButton as RelayCommand)?.RaiseCanExecuteChanged();
			}
		}

		public MainWindowViewModel()
		{
			MyButton = new RelayCommand(() => { MyText--; }, () => { return MyText > 0; });
			MyText = 1;
		}
	}
}
