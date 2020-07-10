﻿using CookTime.Views__UI_;
using MobileClient.Model__Logic_;
using MobileClient.ViewModel__Abstract_UI_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileClient.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notifications : ContentPage
    {
        MyNotificationsVM notificationList;
        public Notifications()
        {
            InitializeComponent();
            notificationList = new MyNotificationsVM();
            NotificationsList.ItemsSource = notificationList.MyNotifications;
        }
    }
}