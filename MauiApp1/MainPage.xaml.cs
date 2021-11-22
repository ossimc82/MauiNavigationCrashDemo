using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly Page1 _page1;

        public MainPage(Page1 page1)
        {
            _page1 = page1;

            InitializeComponent();
        }

        private void OnPage1Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(_page1);
        }
    }
}
