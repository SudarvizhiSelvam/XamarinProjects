using Xamarin.Forms;

namespace XamarinPieChart
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			TabbedPage pages = new TabbedPage();
			pages.Children.Add(new SimplestPage() { Title = "Simplest" });
			pages.Children.Add(new NormalPage() { Title = "Normal" });
			pages.Children.Add(new AreaPage() { Title = "Area" });

			MainPage = pages;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
