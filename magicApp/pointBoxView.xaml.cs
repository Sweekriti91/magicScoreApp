using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace magicApp
{
    public partial class pointBoxView : ContentView
    {
        public pointBoxView()
        {
            InitializeComponent();

            addPoint.Clicked += AddPoint_Clicked;
            subtractPoint.Clicked += SubtractPoint_Clicked;

        }

        void AddPoint_Clicked(object sender, EventArgs e)
        {
            var currentVal = Int32.Parse(scoreValue.Text);
            var newVal = currentVal + 1;

            scoreValue.Text = newVal.ToString();
        }

        void SubtractPoint_Clicked(object sender, EventArgs e)
        {
			var currentVal = Int32.Parse(scoreValue.Text);
			var newVal = currentVal - 1;

			scoreValue.Text = newVal.ToString();
        }
    }
}
