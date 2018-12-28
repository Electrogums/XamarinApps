using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSwitcher
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ChangeColor(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var red = redSlider.Value;
            var blue = blueSlider.Value;
            var green = greenSlider.Value;

            Color bgColor =new Color(red, green, blue);
            boxColor.BackgroundColor = bgColor;
            lblDisplay.Text = ColorToHext(bgColor);
        }

        private string ColorToHext(Color bgColor)
        {
            int red = (int)(bgColor.R * 255);
            int green = (int)(bgColor.G * 255);
            int blue = (int)(bgColor.B * 255);
            int alpha = (int)(bgColor.A * 255);
            return $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";
        }
    }
}
