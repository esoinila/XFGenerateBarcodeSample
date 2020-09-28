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
        private string _myText = "The secret is to use your arse muscless in lifting stuff";
        public string MyText { get { return _myText; } set { _myText = value; } }

        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            valueLabel.Text = "QR-code: bla bla";
            MainTitle.Text = "Otsikko Uusi";
            MyImageView.BarcodeValue = "Satoi kuin Esterin sielta";

            //await DisplayAlert("Alert", "You pressed a button", "OK");

        }
    }
}
