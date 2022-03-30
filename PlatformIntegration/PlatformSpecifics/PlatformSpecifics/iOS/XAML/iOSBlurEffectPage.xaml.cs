﻿using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSBlurEffectPage : ContentPage
    {
        public iOSBlurEffectPage()
        {
            InitializeComponent();
        }

        void OnNoBlurButtonClicked(object sender, EventArgs e)
        {
            image.On<iOS>().UseBlurEffect(BlurEffectStyle.None);
        }

        void OnExtraLightBlurButtonClicked(object sender, EventArgs e)
        {
            image.On<iOS>().UseBlurEffect(BlurEffectStyle.ExtraLight);
        }

        void OnLightBlurButtonClicked(object sender, EventArgs e)
        {
            image.On<iOS>().UseBlurEffect(BlurEffectStyle.Light);
        }

        void OnDarkBlurButtonClicked(object sender, EventArgs e)
        {
            image.On<iOS>().UseBlurEffect(BlurEffectStyle.Dark);
        }
    }
}
