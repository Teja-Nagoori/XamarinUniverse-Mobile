﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace XamarinUniverse.Mobile.Views.AppShell
{
    public class AppShellMasterViewModel
    {
        public ObservableCollection<AppShellMenuItem> PrimaryMenuItems { get; set; }
        public ObservableCollection<AppShellMenuItem> SecondaryMenuItems { get; set; }

        public AppShellMasterViewModel()
        {
            PrimaryMenuItems = new ObservableCollection<AppShellMenuItem>(new[]
            {
                new AppShellMenuItem { Id = 0, Title = "News", TargetType = typeof(NewsOverviewPage) },
            });

            SecondaryMenuItems = new ObservableCollection<AppShellMenuItem>(new[]
            {
                new AppShellMenuItem { Id = 0, Title = "Settings", TargetType = typeof(SettingsPage) },
            });
        }
    }
}
