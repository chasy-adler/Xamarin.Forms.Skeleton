﻿using SkeletonExample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace SkeletonExample.Pages
{
    public partial class VerticalShake : BasePage
    {
        public VerticalShake()
        {
            InitializeComponent();
            this.BindingContext = new VerticalShakeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Device.RuntimePlatform.Equals(Device.iOS))
                mainGrid.Margin = new Thickness(30, On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets().Top + 30, 30, 30);
            else
                mainGrid.Margin = new Thickness(30, 50, 30, 30);
        }


    }
}