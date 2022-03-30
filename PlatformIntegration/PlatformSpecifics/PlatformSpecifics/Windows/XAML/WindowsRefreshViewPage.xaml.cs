﻿using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using RefreshPullDirection = Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.RefreshView.RefreshPullDirection;

namespace PlatformSpecifics
{
	public partial class WindowsRefreshViewPage : ContentPage
	{
		public WindowsRefreshViewPage ()
		{
			InitializeComponent ();
            enumPicker.EnumType = typeof(Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.RefreshView.RefreshPullDirection);
            enumPicker.SelectedIndex = 0;
		}

        void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            refreshView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetRefreshPullDirection((RefreshPullDirection)enumPicker.SelectedItem);
        }
    }
}