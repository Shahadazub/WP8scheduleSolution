﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
// Directive for the ViewModel.
using LocalDatabaseSample.Model;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the page DataContext property to the ViewModel.
            this.DataContext = App.ViewModel;

            

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void MainPageClickHandler(object sender, RoutedEventArgs e)
        {
            var button = (Button) sender;
            switch(button.Name)
            {
                case "PuprpleSchBut":
                    NavigationService.Navigate(new Uri("/SchedulesPage.xaml", UriKind.Relative));
                    break;
                case "GreenSchBut":
                    NavigationService.Navigate(new Uri("/SchedulesPage.xaml", UriKind.Relative));
                    break;
                case "BlueSchBut":
                    NavigationService.Navigate(new Uri("/SchedulesPage.xaml", UriKind.Relative));
                    break;
                case "NextBlueBut":
                    break;
                case "NextGreenBut":
                    break;
                case "NextPurpleBut":
                    break;
            }
        }



        


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}