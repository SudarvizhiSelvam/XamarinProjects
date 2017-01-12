using System.ComponentModel;

namespace CustomRendererExample
{
	public abstract class BaseViewModel : INotifyPropertyChanged
	{
		bool isBusy;
		public bool IsBusy
		{
			get
			{
				return isBusy;
			}
			set
			{
				isBusy = value;
				OnPropertyChanged("IsBusy");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string property)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}
	}
}