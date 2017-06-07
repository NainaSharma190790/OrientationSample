using System;
using Xamarin.Forms;

namespace OrientationSample
{
	public class CustomPage:ContentPage
	{
		public static readonly BindableProperty IsPortraitProperty =
			BindableProperty.Create("IsPortrait", typeof(bool), typeof(CustomPage), true);

		public bool IsPortrait
		{
			get { return (bool)GetValue(IsPortraitProperty); }
			set { SetValue(IsPortraitProperty, value); }
		}
	}
}
