using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.PDF417.Internal;

namespace GenerateBarcodeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs args)
        {
            valueLabel.Text = "QR-code: " + wantedText.Text;
            MyImageView.BarcodeValue = wantedText.Text;            
            //await DisplayAlert("Alert", "You pressed a button", "OK");
        }
    }
}
