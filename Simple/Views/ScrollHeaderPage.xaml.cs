﻿using Simple.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Simple.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ScrollHeaderPage : Page
    {
        public ScrollHeaderPage()
        {
            this.InitializeComponent();
            Items = new ObservableCollection<ListViewModel>();
            for (int i = 0; i < 20; i++)
            {
                Items.Add(new ListViewModel() { Title = "Item" + i, Content = "This is Item" + i, Image = new Uri("ms-appx:///Assets/imgs/" + i + ".jpg") });
            }
        }

        ObservableCollection<ListViewModel> Items { get; set; }

        private void ScrollHeaderPanel_ScrollHeaderStateChanged(MaterialLibs.Controls.ScrollHeaderPanel sender, MaterialLibs.Common.ScrollHeaderStateChangedEventArgs e)
        {
            switch (e.State)
            {
                case MaterialLibs.Common.HeaderState.Start:

                    break;
                case MaterialLibs.Common.HeaderState.Changing:

                    break;
                case MaterialLibs.Common.HeaderState.Final:

                    break;
            }
        }
    }
}