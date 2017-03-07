using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace HierarchicalNavigationSample
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void OnNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(), true);
        }

        private async void OnPrevButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Trace.WriteMethod();
            Trace.WriteNavigationStack(this);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Trace.WriteMethod();
            Trace.WriteNavigationStack(this);
        }
    }
}
