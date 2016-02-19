using System;
using Xamarin.Forms;

namespace DealingSizes
{
	public class FontSizesPage : ContentPage
	{
		public FontSizesPage ()
		{

			BackgroundColor = Color.White;
			StackLayout stackLayout = new StackLayout {

				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			NamedSize[] namedSizes = {

				NamedSize.Default ,NamedSize.Micro ,NamedSize.Small,
				NamedSize.Medium ,NamedSize.Large
			};

			foreach(NamedSize namedSize in namedSizes)
			{
				double fontsize = Device.GetNamedSize (namedSize , typeof(Label));

				stackLayout.Children.Add (new Label
					{
						Text = String.Format("Named Size = {0} ({1:F2})" ,namedSize ,fontsize),
						FontSize = fontsize,
						TextColor = Color.Black
					}

				);
			}

			double resolution = Device.OnPlatform (160 ,160 , 240);

			stackLayout.Children.Add (
			
				new BoxView{

					Color = Color.Accent,
					HeightRequest = resolution/80
				}
			);

			int[] ptSizes = { 4 , 6, 8,10 ,12};
			foreach(double ptSize in ptSizes)
			{
				double fontsize = resolution * ptSize / 72;
				stackLayout.Children.Add (
				
					new Label{

						Text = String.Format("Point Size = {0} ({1:F2})",ptSize, fontsize),
						FontSize = fontsize,
						TextColor = Color.Black
					}
				);
			}

			Content = stackLayout;
		}
	}
}