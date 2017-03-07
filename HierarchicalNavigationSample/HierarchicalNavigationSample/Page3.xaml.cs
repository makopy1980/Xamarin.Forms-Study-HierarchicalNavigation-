using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Util;

namespace HierarchicalNavigationSample
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void OnPrevButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        private async void OnTopPageButton(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
        }

        private void OnInsertPageBeforeButton(object sender, EventArgs e)
        {
            // このページの前にInsertPageを挿入する
            Navigation.InsertPageBefore(new InsertPage(), this);
        }

        private void OnRemovePrevPageButton(object sender, EventArgs e)
        {
            var stack = Navigation.NavigationStack;
            var pIndex = stack.Count - 2;

            if (pIndex > 0)
            {
                var page = stack[pIndex];
                if (page != null)
                {
                    Navigation.RemovePage(page);
                }
            }
        }

        private void OnReplacePrevPageButton(object sender, EventArgs e)
        {
            var stack = Navigation.NavigationStack;
            var pIndex = stack.Count - 2;

            if (pIndex > 0)
            {
                var page = stack[pIndex];
                if (page != null)
                {
                    // 前ページを削除
                    Navigation.RemovePage(page);
                    // このページの前にInsertPageを挿入する
                    Navigation.InsertPageBefore(new InsertPage(), this);
                }
            }
            
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
