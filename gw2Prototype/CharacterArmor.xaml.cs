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
    public sealed partial class CharacterArmor : Page
    {
        //make a global variable to hold the character id
        public int id;

        public CharacterArmor()
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
                id = int.Parse(e.Parameter.ToString());

                //Switch case, if 0 - Necro, 1 - Mesmer.
                switch (id)
                {
                    case 0:

                        CharacterName.Text = App.person1.Name;

                        //Set the attributes, They are all numbers, some will have decimal values
                        power.Text = App.person1.powerAtt.ToString("N0");
                        toughness.Text = App.person1.toughnessAtt.ToString("N0");
                        vitality.Text = App.person1.vitalityAtt.ToString("N0");
                        precision.Text = App.person1.precisionAtt.ToString("N0");
                        ferocity.Text = App.person1.ferocityAtt.ToString("N0");
                        conditionDamage.Text = App.person1.conditionDamageAtt.ToString("N0");
                        expertise.Text = App.person1.expertiseAtt.ToString("N0");
                        concentration.Text = App.person1.concentrationAtt.ToString("N0");
                        agonyResistence.Text = App.person1.agonyResistenceAtt.ToString("N0");
                        professionAttribute.Text = App.person1.professionAttribute.ToString("N0") + "%";
                        armor.Text = App.person1.armorAtt.ToString("N0");
                        health.Text = App.person1.healthAtt.ToString("N0");
                        criticalChance.Text = App.person1.criticalChanceAtt.ToString("N2") + "%";
                        criticalDamage.Text = App.person1.criticalDamageAtt.ToString("N1") + "%";
                        healing.Text = App.person1.healingAtt.ToString("N0");
                        conditionDuration.Text = App.person1.conditionDurationAtt.ToString("N1") + "%";
                        boonDuration.Text = App.person1.boonDurationAtt.ToString("N1") + "%";
                        magicFind.Text = App.person1.magicFindAtt.ToString("N0") + "%";

                        HelmAquatic.Source = new BitmapImage(new Uri(App.equipment.necroHelmAq.Icon));
                        Backpack.Source = new BitmapImage(new Uri(App.equipment.necroBackpack.Icon));
                        Helm.Source = new BitmapImage(new Uri(App.equipment.necroHelm.Icon));
                        Shoulders.Source = new BitmapImage(new Uri(App.equipment.necroShoulders.Icon));
                        Coat.Source = new BitmapImage(new Uri(App.equipment.necroCoat.Icon));
                        Gloves.Source = new BitmapImage(new Uri(App.equipment.necroGloves.Icon));
                        Leggings.Source = new BitmapImage(new Uri(App.equipment.necroLeggings.Icon));
                        Boots.Source = new BitmapImage(new Uri(App.equipment.necroBoots.Icon));
                        WeaponA1.Source = new BitmapImage(new Uri(App.equipment.necroWeaponA1.Icon));
                        WeaponA2.Source = new BitmapImage(new Uri(App.equipment.necroWeaponA2.Icon));
                        WeaponB1.Source = new BitmapImage(new Uri(App.equipment.necroWeaponB1.Icon));
                        Accessory1.Source = new BitmapImage(new Uri(App.equipment.necroAccessory1.Icon));
                        Accessory2.Source = new BitmapImage(new Uri(App.equipment.necroAccessory2.Icon));
                        Amulet.Source = new BitmapImage(new Uri(App.equipment.necroAmulet.Icon));
                        Ring1.Source = new BitmapImage(new Uri(App.equipment.necroRing1.Icon));
                        Ring2.Source = new BitmapImage(new Uri(App.equipment.necroRing2.Icon));
                        Sickle.Source = new BitmapImage(new Uri(App.equipment.necroSickle.Icon));
                        Axe.Source = new BitmapImage(new Uri(App.equipment.necroAxe.Icon));
                        Pick.Source = new BitmapImage(new Uri(App.equipment.necroPick.Icon));
                        WeaponAquaticA.Source = new BitmapImage(new Uri(App.equipment.necroWeaponAquaticA.Icon));
                        WeaponAquaticB.Source = new BitmapImage(new Uri(App.equipment.necroWeaponAquaticB.Icon));
                        WeaponB2Button.IsEnabled = false;

                        break;

                    case 1:
                        CharacterName.Text = App.person2.Name;

                        power.Text = App.person2.powerAtt.ToString("N0");
                        toughness.Text = App.person2.toughnessAtt.ToString("N0");
                        vitality.Text = App.person2.vitalityAtt.ToString("N0");
                        precision.Text = App.person2.precisionAtt.ToString("N0");
                        ferocity.Text = App.person2.ferocityAtt.ToString("N0");
                        conditionDamage.Text = App.person2.conditionDamageAtt.ToString("N0");
                        expertise.Text = App.person2.expertiseAtt.ToString("N0");
                        concentration.Text = App.person2.concentrationAtt.ToString("N0");
                        agonyResistence.Text = App.person2.agonyResistenceAtt.ToString("N0");
                        professionAttribute.Text = App.person2.professionAttribute.ToString("N0") + "%";
                        armor.Text = App.person2.armorAtt.ToString("N0");
                        health.Text = App.person2.healthAtt.ToString("N0");
                        criticalChance.Text = App.person2.criticalChanceAtt.ToString("N2") + "%";
                        criticalDamage.Text = App.person2.criticalDamageAtt.ToString("N1") + "%";
                        healing.Text = App.person2.healingAtt.ToString("N0");
                        conditionDuration.Text = App.person2.conditionDurationAtt.ToString("N1") + "%";
                        boonDuration.Text = App.person2.boonDurationAtt.ToString("N1") + "%";
                        magicFind.Text = App.person2.magicFindAtt.ToString("N0") + "%";


                        HelmAquatic.Source = new BitmapImage(new Uri(App.equipment.mesmerHelmAq.Icon));
                        Backpack.Source = new BitmapImage(new Uri(App.equipment.mesmerBackpack.Icon));
                        Helm.Source = new BitmapImage(new Uri(App.equipment.mesmerHelm.Icon));
                        Shoulders.Source = new BitmapImage(new Uri(App.equipment.mesmerShoulders.Icon));
                        Coat.Source = new BitmapImage(new Uri(App.equipment.mesmerCoat.Icon));
                        Gloves.Source = new BitmapImage(new Uri(App.equipment.mesmerGloves.Icon));
                        Leggings.Source = new BitmapImage(new Uri(App.equipment.mesmerLeggings.Icon));
                        Boots.Source = new BitmapImage(new Uri(App.equipment.mesmerBoots.Icon));
                        WeaponA1.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponA1.Icon));
                        WeaponA2.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponA2.Icon));
                        WeaponB1.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponB1.Icon));
                        WeaponB2.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponB2.Icon));
                        Accessory1.Source = new BitmapImage(new Uri(App.equipment.mesmerAccessory1.Icon));
                        Accessory2.Source = new BitmapImage(new Uri(App.equipment.mesmerAccessory2.Icon));
                        Amulet.Source = new BitmapImage(new Uri(App.equipment.mesmerAmulet.Icon));
                        Ring1.Source = new BitmapImage(new Uri(App.equipment.mesmerRing1.Icon));
                        Ring2.Source = new BitmapImage(new Uri(App.equipment.mesmerRing2.Icon));
                        Sickle.Source = new BitmapImage(new Uri(App.equipment.mesmerSickle.Icon));
                        Axe.Source = new BitmapImage(new Uri(App.equipment.mesmerAxe.Icon));
                        Pick.Source = new BitmapImage(new Uri(App.equipment.mesmerPick.Icon));
                        WeaponAquaticA.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponAquaticA.Icon));
                        WeaponAquaticB.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponAquaticB.Icon));

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


//Now for the magic, two values need to be passed to the next page, i.e. the item page of the item selected.

            //create a class and create getters and setters
        public class passMe
        {
            public int characterNumber { get; set; }
            public string selectedItemName { get; set; }
        }
        #endregion

        private void item_Check(object sender, RoutedEventArgs e)
        {
            //create an instance of a class, and set the id, and the itemname based of the character id and clicked item
            passMe s = new passMe();            
                s.characterNumber = id;
                s.selectedItemName = Convert.ToString((sender as Button).Tag);
            



//pass it on!
        Frame.Navigate(typeof(itemView), s);

        }

        private void about_Page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }

    }

}
