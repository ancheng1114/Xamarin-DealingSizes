using System;
using Xamarin.Forms;

namespace DealingSizes
{
	public struct FontCalc
	{
		public double FontSize { private set; get;}
		public double TextHeight { private set ; get;}

		public FontCalc(Label label , double fontSize , double containerWidth):this()
		{
			label.FontSize = fontSize;
		
			SizeRequest sizeRequest = label.GetSizeRequest (containerWidth ,Double.PositiveInfinity);
			TextHeight = sizeRequest.Request.Height;
			FontSize = fontSize;

		}
	}
}

