using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BrownBag
{
	public partial class MainPage : ContentPage
	{
		string _resultText = null;
		Label _resultLabel;

		public MainPage()
		{
			var label = new Label()
			{
				Text = "Hey"
			};

			var entry = new Entry()
			{
				Placeholder = "Type your name here.."
			};
			var button = new Button()
			{
				Text = "Don't press my buttons!",
				BackgroundColor = Color.Yellow
			};
			button.Clicked += Button_Clicked;
			_resultLabel = new Label()
			{
				Text = _resultText
			};
			_resultLabel.IsVisible = true;
			_resultLabel.TextColor = Color.Red;
			_resultLabel.FontAttributes = FontAttributes.Bold;

			var layout = new StackLayout()
			{
				Padding = 10,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Vertical,
				Children = {label, entry, button, _resultLabel}
			};
			Content = layout;
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			_resultText = "Why would you do that?";
			_resultLabel.Text = _resultText;
		}

	}
}
