using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Util;

using Xamarin.Forms;

namespace HierarchicalNavigationSample
{
    public partial class TopPage : ContentPage
    {
        public TopPage()
        {
            InitializeComponent();
        }

        private async void OnNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(), true);
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
