using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            await DisplayAlert("Alert", "You pressed a button", "OK");
        }
    }
}
