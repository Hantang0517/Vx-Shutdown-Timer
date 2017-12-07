﻿using MahApps.Metro.Controls;
using System;
using System.IO;

namespace VxShutdownTimer.GUI.About
{
  
    public partial class AboutView : MetroWindow
    {
        public AboutView()
        {
            InitializeComponent();
            Load();
        }
        private async void Load()
        {
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "apache-license.txt")))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "apache-license.txt")))
                    {
                        string text = await reader.ReadToEndAsync();
                        TextBoxLicense.Text = text;
                    }
                }
                catch { }
            }
        }
        private void GotoUri(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
            }
            catch { }
        }
    }
}
