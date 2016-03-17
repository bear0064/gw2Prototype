using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;




namespace gw2Prototype
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CharacterScreen : Page
    {
        public CharacterScreen()
        {
            this.InitializeComponent();

            //When the page loads, set the default values as these- getting from the objects in App.cs

            Character1.Tag = App.person1.Id;
            CharName.Text = App.person1.Name;
            CharLvl.Text = App.person1.Level.ToString();
            CharClass.Text = App.person1.characterClass;
            CharGuild.Text = App.person1.Guild;
            professionImg.Source = new BitmapImage(new Uri(App.person1.professionBackground));

            Character2.Tag = App.person2.Id;
            CharName1.Text = App.person2.Name;
            CharLvl1.Text = App.person2.Level.ToString();
            CharClass1.Text = App.person2.characterClass;
            CharGuild1.Text = App.person2.Guild;
            professionImg1.Source = new BitmapImage(new Uri(App.person2.professionBackground));


        }
        //Click handler for character 1, on a click carry/pass the Tag, which is the id of this character
        private void Character1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ArmorySelector), Character1.Tag);
        }
        //Click handler for character 2, on a click carry/pass the Tag, which is the id of this character
        private void Character2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ArmorySelector), Character2.Tag);

        }


        #region Navigated to and From with back button

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;


            currentView.BackRequested += backButton_Tapped;




            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {


            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;


            currentView.BackRequested -= backButton_Tapped;




            base.OnNavigatedFrom(e);
        }


        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }

        }

        #endregion

        private void about_Page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }

    }
}
