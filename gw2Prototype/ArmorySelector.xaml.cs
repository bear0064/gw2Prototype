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
using Windows.UI.Xaml.Navigation;



namespace gw2Prototype
{


    public sealed partial class ArmorySelector : Page
    {
        //Create a global id for the selected Id
        public int id;

        public ArmorySelector()
        {
            this.InitializeComponent();
        }

        #region Navigated to and From with back button

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;


            currentView.BackRequested += backButton_Tapped;

            //check if the passed object is an integer
            if (e.Parameter is int)
            {
                //convert it to a string then parse it as an int- this seems like the long way to do this.
                int id = Int32.Parse(e.Parameter.ToString());


                //Switch case, if 0- necro, 1- mesmer.
                switch (id)
                {
                    case 0:

                        //set the two buttons to hold the id of the character, that way it can be passed along
                        equipmentGo.Tag = id;
                        buildGo.Tag = id;

                        CharacterNameAS.Text = App.person1.Name;
                        CharacterLevelAS.Text = App.person1.Level.ToString();
                        CharacterClassAS.Text = App.person1.characterClass;
                        break;
                    case 1:
                        equipmentGo.Tag = id;
                        buildGo.Tag = id;

                        CharacterNameAS.Text = App.person2.Name;
                        CharacterLevelAS.Text = App.person2.Level.ToString();
                        CharacterClassAS.Text = App.person2.characterClass;
                        break;

                }
            
            }


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

        //Click handler for the equipment page
        private void equipmentGo_Click(object sender, RoutedEventArgs e)
        {

            //pass the tag value - id = 0 or 1, along 
            Frame.Navigate(typeof(CharacterArmor), equipmentGo.Tag);

        }

        //Click handler for the build page
        private void buildGo_Click(object sender, RoutedEventArgs e)
        {
            //pass the tag value - id = 0 or 1, along 
            Frame.Navigate(typeof(CharacterBuild), buildGo.Tag);

        }

        private void about_Page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }

    }
}
