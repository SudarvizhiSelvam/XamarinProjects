using Android.Support.Design.Widget;
using Android.Text;
using Android.Views;
using CustomRendererExample;
using CustomRendererExample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomTextInputLayout), typeof(CustomTextInputLayoutDroid))]
namespace CustomRendererExample.Droid
{
	public class CustomTextInputLayoutDroid : ViewRenderer<CustomTextInputLayout, TextInputLayout>
	{
		CustomTextInputLayout formsControl;
		TextInputLayout textInputLayout;

		protected override void OnElementChanged(ElementChangedEventArgs<CustomTextInputLayout> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement == null)
			{
				return;
			}

			formsControl = Element as CustomTextInputLayout;
			textInputLayout = CreateNativeControl();

			textInputLayout.EditText.Text = formsControl.Text;
			textInputLayout.EditText.SetHintTextColor(Android.Graphics.Color.Blue);
			textInputLayout.Hint = formsControl.PlaceHolder;
			textInputLayout.EditText.SetTextColor(formsControl.TextColor.ToAndroid());
			textInputLayout.EditText.InputType = formsControl.IsPassword ? InputTypes.TextVariationPassword | InputTypes.ClassText : formsControl.Keyboard.ToNative();
			textInputLayout.EditText.SetTextSize(Android.Util.ComplexUnitType.Dip, formsControl.FontSize);

			SetNativeControl(textInputLayout);
		}

		protected override TextInputLayout CreateNativeControl()
		{
			var layout = (TextInputLayout)LayoutInflater.From(Forms.Context).Inflate(Resource.Drawable.TextInputLayoutDroid, null);

			return layout;
		}
	}
}