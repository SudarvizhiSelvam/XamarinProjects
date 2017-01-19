using Xamarin.Forms;

namespace CustomRendererExample
{
	public class CustomTextInputLayout : View
	{
		public static readonly BindableProperty PlaceHolderProperty = BindableProperty.Create("PlaceHolder", typeof(string), typeof(CustomTextInputLayout), default(string));
		public string PlaceHolder
		{
			get
			{
				return (string)GetValue(PlaceHolderProperty);
			}
			set
			{
				SetValue(PlaceHolderProperty, value);
			}
		}

		public static readonly BindableProperty TextProperty = BindableProperty.Create("PlaceHolder", typeof(string), typeof(CustomTextInputLayout), default(string));
		public string Text
		{
			get
			{
				return (string)GetValue(TextProperty);
			}
			set
			{
				SetValue(TextProperty, value);
			}
		}

		public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(CustomTextInputLayout), Color.Black);
		public Color TextColor
		{
			get
			{
				return (Color)GetValue(TextColorProperty);
			}
			set
			{
				SetValue(TextColorProperty, value);
			}
		}

		public static readonly BindableProperty KeyboardProperty = BindableProperty.Create("Keyboard", typeof(Keyboard), typeof(CustomTextInputLayout), Keyboard.Default);
		public Keyboard Keyboard
		{
			get
			{
				return (Keyboard)GetValue(KeyboardProperty);
			}
			set
			{
				SetValue(KeyboardProperty, value);
			}
		}

		public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create("IsPassword", typeof(bool), typeof(CustomTextInputLayout), default(bool));
		public bool IsPassword
		{
			get
			{
				return (bool)GetValue(IsPasswordProperty);
			}
			set
			{
				SetValue(IsPasswordProperty, value);
			}
		}

		public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(float), typeof(CustomTextInputLayout), 15f);
		public float FontSize
		{
			get
			{
				return (float)GetValue(FontSizeProperty);
			}
			set
			{
				SetValue(FontSizeProperty, value);
			}
		}

	}
}