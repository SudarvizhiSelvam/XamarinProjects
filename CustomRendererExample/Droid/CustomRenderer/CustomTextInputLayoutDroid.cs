using Android.Support.Design.Widget;
using Android.Text;
using Android.Views;
using CustomRendererExample;
using CustomRendererExample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomTextInputLayout), typeof(CustomTextInputLayoutDroid))]
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

			//textInputLayout.EditText.SetTextColor(Android.Graphics.Color.Blue);
			textInputLayout.EditText.SetHintTextColor(Android.Graphics.Color.Red);

			textInputLayout.EditText.InputType = InputTypes.ClassText | InputTypes.TextVariationEmailAddress;

			textInputLayout.EditText.SetSingleLine(true);

			SetNativeControl(textInputLayout);
		}

		protected override TextInputLayout CreateNativeControl()
		{
			var layout = (TextInputLayout)LayoutInflater.From(Forms.Context).Inflate(Resource.Drawable.TextInputLayoutDroid, null);

			return layout;
		}
	}
}