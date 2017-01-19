using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleTinderXamarin
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
	
		List<CardStackView.Item> items = new List<CardStackView.Item>();
		public List<CardStackView.Item> ItemsList
		{
			get	{
				return items;
			}
			set	{
				if (items == value)	{
					return;
				}
				items = value;
				OnPropertyChanged();
			}
		}
		
		protected virtual void OnPropertyChanged ([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) {
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
			
		protected virtual void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			field = value;
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) {
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		public MainPageViewModel()
		{
			items.Add (new CardStackView.Item () { Name = "Pizza to go", Photo = "icon.png", Location = "30 meters away", Description = "Pizza" });
			items.Add (new CardStackView.Item () { Name = "Dragon & Peacock", Photo = "icon.png", Location = "800 meters away", Description = "Sweet & Sour"});
			items.Add (new CardStackView.Item () { Name = "Murrays Food Palace", Photo = "icon.png", Location = "9 miles away", Description = "Salmon Plate" });
			items.Add (new CardStackView.Item () { Name = "Food to go", Photo = "icon.png", Location = "4 miles away", Description = "Salad Wrap" });
			items.Add (new CardStackView.Item () { Name = "Mexican Joint", Photo = "icon.png", Location = "2 miles away", Description = "Chilli Bites" });
			items.Add (new CardStackView.Item () { Name = "Mr Bens", Photo = "icon.png", Location = "1 mile away", Description = "Beef" });
			items.Add (new CardStackView.Item () { Name = "Corner Shop", Photo = "icon.png", Location = "100 meters away", Description = "Burger & Chips" });
			items.Add (new CardStackView.Item () { Name = "Sarah's Cafe", Photo = "icon.png", Location = "6 miles away", Description = "House Breakfast" });
			items.Add (new CardStackView.Item () { Name = "Pata Place", Photo = "icon.png", Location = "2 miles away", Description = "Chicken Curry" });
			items.Add (new CardStackView.Item () { Name = "Jerrys", Photo = "icon.png", Location = "8 miles away", Description = "Pasta Salad" });
		}
	}
}

