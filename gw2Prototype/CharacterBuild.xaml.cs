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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace gw2Prototype
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public sealed partial class CharacterBuild : Page
    {

        public CharacterBuild()
        {
            this.InitializeComponent();



        }




        #region Navigated to and From with back button

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;


            currentView.BackRequested += backButton_Tapped;

            //Check the parameter being passed, if it is an integer object
            if (e.Parameter is int)
            {
               //change it to a string, then parse it to make it an integer
                int id = Int32.Parse(e.Parameter.ToString());
                //Switch case, if 0 - Necro, 1 - Mesmer.
                switch (id)
                {
                    case 0:

                        
                        spec1.Source = new BitmapImage(new Uri(App.Necromancer.specializationOneBackground));
                        specIcon1.Source = new BitmapImage(new Uri(App.Necromancer.specializationOneIcon));
                        traitLineOneHexOne.Source = new BitmapImage(new Uri(App.Necromancer.specOneMinorTraitOne));
                        traitLineOneHexTwo.Source = new BitmapImage(new Uri(App.Necromancer.specOneMinorTraitTwo));
                        traitLineOneHexThree.Source = new BitmapImage(new Uri(App.Necromancer.specOneMinorTraitThree));

                        traitLineOneSqrOne.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitOne));
                        traitLineOneSqrTwo.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitTwo));
                        traitLineOneSqrThree.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitThree));
                        traitLineOneSqrFour.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitFour));
                        traitLineOneSqrFive.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitFive));
                        traitLineOneSqrSix.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitSix));
                        traitLineOneSqrSeven.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitSeven));
                        traitLineOneSqrEight.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitEight));
                        traitLineOneSqrNine.Source = new BitmapImage(new Uri(App.Necromancer.specOneMajorTraitNine));

                        //Opacity is used to show which traits are used and which are not - only one per trait group can be active.
                        traitLineOneSqrOne.Opacity = 0.40;
                        traitLineOneSqrTwo.Opacity = 0.40;
                        traitLineOneSqrThree.Opacity = 1;
                        traitLineOneSqrFour.Opacity = 1;
                        traitLineOneSqrFive.Opacity = 0.40;
                        traitLineOneSqrSix.Opacity = 0.40;
                        traitLineOneSqrSeven.Opacity = 0.40;
                        traitLineOneSqrEight.Opacity = 1;
                        traitLineOneSqrNine.Opacity = 0.40;


                        spec2.Source = new BitmapImage(new Uri(App.Necromancer.specializationTwoBackground));
                        specIcon2.Source = new BitmapImage(new Uri(App.Necromancer.specializationTwoIcon));
                        traitLineTwoHexOne.Source = new BitmapImage(new Uri(App.Necromancer.specTwoMinorTraitOne));
                        traitLineTwoHexTwo.Source = new BitmapImage(new Uri(App.Necromancer.specTwoMinorTraitTwo));
                        traitLineTwoHexThree.Source = new BitmapImage(new Uri(App.Necromancer.specTwoMinorTraitThree));

                        traitLineTwoSqrOne.Source =     new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitOne));
                        traitLineTwoSqrTwo.Source =     new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitTwo));
                        traitLineTwoSqrThree.Source =   new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitThree));
                        traitLineTwoSqrFour.Source =    new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitFour));
                        traitLineTwoSqrFive.Source =    new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitFive));
                        traitLineTwoSqrSix.Source =     new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitSix));
                        traitLineTwoSqrSeven.Source =   new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitSeven));
                        traitLineTwoSqrEight.Source =   new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitEight));
                        traitLineTwoSqrNine.Source =    new BitmapImage(new Uri(App.Necromancer.specTwoMajorTraitNine));
                        traitLineTwoSqrOne.Opacity = 0.40;
                        traitLineTwoSqrTwo.Opacity = 1;
                        traitLineTwoSqrThree.Opacity = 0.40;
                        traitLineTwoSqrFour.Opacity = 0.40;
                        traitLineTwoSqrFive.Opacity = 0.40;
                        traitLineTwoSqrSix.Opacity = 1;
                        traitLineTwoSqrSeven.Opacity = 1;
                        traitLineTwoSqrEight.Opacity = 0.40;
                        traitLineTwoSqrNine.Opacity = 0.40;

                        spec3.Source = new BitmapImage(new Uri(App.Necromancer.specializationThreeBackground));
                        specIcon3.Source = new BitmapImage(new Uri(App.Necromancer.specializationThreeIcon));
                        traitLineThreeHexOne.Source = new BitmapImage(new Uri(App.Necromancer.specThreeMinorTraitOne));
                        traitLineThreeHexTwo.Source = new BitmapImage(new Uri(App.Necromancer.specThreeMinorTraitTwo));
                        traitLineThreeHexThree.Source = new BitmapImage(new Uri(App.Necromancer.specThreeMinorTraitThree));

                        traitLineThreeSqrOne.Source =   new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitOne));
                        traitLineThreeSqrTwo.Source =   new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitTwo));
                        traitLineThreeSqrThree.Source = new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitThree));
                        traitLineThreeSqrFour.Source =  new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitFour));
                        traitLineThreeSqrFive.Source =  new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitFive));
                        traitLineThreeSqrSix.Source =   new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitSix));
                        traitLineThreeSqrSeven.Source = new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitSeven));
                        traitLineThreeSqrEight.Source = new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitEight));
                        traitLineThreeSqrNine.Source =  new BitmapImage(new Uri(App.Necromancer.specThreeMajorTraitNine));
                        traitLineThreeSqrOne.Opacity = 0.40;
                        traitLineThreeSqrTwo.Opacity = 1;
                        traitLineThreeSqrThree.Opacity = 0.40;
                        traitLineThreeSqrFour.Opacity = 0.40;
                        traitLineThreeSqrFive.Opacity = 1;
                        traitLineThreeSqrSix.Opacity = 0.40;
                        traitLineThreeSqrSeven.Opacity = 0.40;
                        traitLineThreeSqrEight.Opacity = 1;
                        traitLineThreeSqrNine.Opacity = 0.40;

                        break;
                    case 1:

                        spec1.Source = new BitmapImage(new Uri(App.Mesmer.specializationOneBackground));
                        specIcon1.Source = new BitmapImage(new Uri(App.Mesmer.specializationOneIcon));
                        traitLineOneHexOne.Source = new BitmapImage(new Uri(App.Mesmer.specOneMinorTraitOne));
                        traitLineOneHexTwo.Source = new BitmapImage(new Uri(App.Mesmer.specOneMinorTraitTwo));
                        traitLineOneHexThree.Source = new BitmapImage(new Uri(App.Mesmer.specOneMinorTraitThree));

                        traitLineOneSqrOne.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitOne));
                        traitLineOneSqrTwo.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitTwo));
                        traitLineOneSqrThree.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitThree));
                        traitLineOneSqrFour.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitFour));
                        traitLineOneSqrFive.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitFive));
                        traitLineOneSqrSix.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitSix));
                        traitLineOneSqrSeven.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitSeven));
                        traitLineOneSqrEight.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitEight));
                        traitLineOneSqrNine.Source = new BitmapImage(new Uri(App.Mesmer.specOneMajorTraitNine));
                        traitLineOneSqrOne.Opacity = 0.40;
                        traitLineOneSqrTwo.Opacity = 1;
                        traitLineOneSqrThree.Opacity = 0.40;
                        traitLineOneSqrFour.Opacity = 0.40;
                        traitLineOneSqrFive.Opacity = 1;
                        traitLineOneSqrSix.Opacity = 0.40;
                        traitLineOneSqrSeven.Opacity = 1;
                        traitLineOneSqrEight.Opacity = 0.40;
                        traitLineOneSqrNine.Opacity = 0.40;


                        spec2.Source = new BitmapImage(new Uri(App.Mesmer.specializationTwoBackground));
                        specIcon2.Source = new BitmapImage(new Uri(App.Mesmer.specializationTwoIcon));
                        traitLineTwoHexOne.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMinorTraitOne));
                        traitLineTwoHexTwo.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMinorTraitTwo));
                        traitLineTwoHexThree.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMinorTraitThree));

                        traitLineTwoSqrOne.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitOne));
                        traitLineTwoSqrTwo.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitTwo));
                        traitLineTwoSqrThree.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitThree));
                        traitLineTwoSqrFour.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitFour));
                        traitLineTwoSqrFive.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitFive));
                        traitLineTwoSqrSix.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitSix));
                        traitLineTwoSqrSeven.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitSeven));
                        traitLineTwoSqrEight.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitEight));
                        traitLineTwoSqrNine.Source = new BitmapImage(new Uri(App.Mesmer.specTwoMajorTraitNine));
                        traitLineTwoSqrOne.Opacity = 0.40;
                        traitLineTwoSqrTwo.Opacity = 0.40;
                        traitLineTwoSqrThree.Opacity = 1;
                        traitLineTwoSqrFour.Opacity = 1;
                        traitLineTwoSqrFive.Opacity = 0.40;
                        traitLineTwoSqrSix.Opacity = 0.40;
                        traitLineTwoSqrSeven.Opacity = 0.40;
                        traitLineTwoSqrEight.Opacity = 0.40;
                        traitLineTwoSqrNine.Opacity = 1;

                        spec3.Source = new BitmapImage(new Uri(App.Mesmer.specializationThreeBackground));
                        specIcon3.Source = new BitmapImage(new Uri(App.Mesmer.specializationThreeIcon));
                        traitLineThreeHexOne.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMinorTraitOne));
                        traitLineThreeHexTwo.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMinorTraitTwo));
                        traitLineThreeHexThree.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMinorTraitThree));

                        traitLineThreeSqrOne.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitOne));
                        traitLineThreeSqrTwo.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitTwo));
                        traitLineThreeSqrThree.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitThree));
                        traitLineThreeSqrFour.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitFour));
                        traitLineThreeSqrFive.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitFive));
                        traitLineThreeSqrSix.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitSix));
                        traitLineThreeSqrSeven.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitSeven));
                        traitLineThreeSqrEight.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitEight));
                        traitLineThreeSqrNine.Source = new BitmapImage(new Uri(App.Mesmer.specThreeMajorTraitNine));
                        traitLineThreeSqrOne.Opacity = 1;
                        traitLineThreeSqrTwo.Opacity = 0.40;
                        traitLineThreeSqrThree.Opacity = 0.40;
                        traitLineThreeSqrFour.Opacity = 0.40;
                        traitLineThreeSqrFive.Opacity = 1;
                        traitLineThreeSqrSix.Opacity = 0.40;
                        traitLineThreeSqrSeven.Opacity = 0.40;
                        traitLineThreeSqrEight.Opacity = 1;
                        traitLineThreeSqrNine.Opacity = 0.40;

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
        private void about_Page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }

    }
}
