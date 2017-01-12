using Xamarin.Forms;

namespace CustomRendererExample
{
	public class CustomTextInputLayout : View
	{
		public string PlaceHolder
		{
			get;set;
		}

		public Color TextColor
		{
			get;
			set;
		}

		public Keyboard Keyboard
		{
			get;
			set;
		}

		public bool IsPassword
		{
			get;
			set;
		}

	}
}