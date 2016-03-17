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
    public sealed partial class itemView : Page
    {
        //Global variables for passing the Id and the Item Name 
        public int charId;
        public string passedItemName;

        public itemView()
        {
            this.InitializeComponent();
        }

        #region Navigated to and From with back button

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;


            currentView.BackRequested += backButton_Tapped;


            // When the page navigates here, retreive the passed data and put it into the global variables declared at the top
            CharacterArmor.passMe s = e.Parameter as CharacterArmor.passMe;
            passedItemName = s.selectedItemName;
            charId = s.characterNumber;

            //switch case, dependent on the character id if 0, then necro; if 1 then mesmer
            //while this is being done when the page changes, i feel like this could have been done by calling a method outside of the OnNavigatedTo
            switch (charId)
            {
                case 0:

                    //switch case, figure out what the item was that was passed, if a helm, then retreive the stats for that item 
                    switch (passedItemName)
                    {

                        #region Necromancer

                        case "Helm":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroHelm.Icon));
                            itemName.Text = App.equipment.necroHelm.Name;
                            attribute1.Text = "+" + App.equipment.necroHelm.Mod1.ToString() + " " + App.equipment.necroHelm.Att1;
                            attribute2.Text = "+" + App.equipment.necroHelm.Mod2.ToString() + " " + App.equipment.necroHelm.Att2;
                            attribute3.Text = "+" + App.equipment.necroHelm.Mod3.ToString() + " " + App.equipment.necroHelm.Att3;
                            UpgradeName.Text = App.equipment.necroHelmUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroHelmUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroHelmUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroHelmUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroHelmUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroHelmUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroHelmUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroHelm.Rarity;
                            Weight.Text = App.equipment.necroHelm.weightClass;
                            Type.Text = App.equipment.necroHelm.Type;
                            level.Text = App.equipment.necroHelm.Level.ToString();

                            break;

                        case "AquaticHelm":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroHelmAq.Icon));
                            itemName.Text = App.equipment.necroHelmAq.Name;
                            attribute1.Text = "+" + App.equipment.necroHelmAq.Mod1.ToString() + " " + App.equipment.necroHelmAq.Att1;
                            attribute2.Text = "+" + App.equipment.necroHelmAq.Mod2.ToString() + " " + App.equipment.necroHelmAq.Att2;
                            attribute3.Text = "+" + App.equipment.necroHelmAq.Mod3.ToString() + " " + App.equipment.necroHelmAq.Att3;
                            UpgradeName.Text = App.equipment.necroHelmUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroHelmAquaticUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroHelmAquaticUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroHelmAquaticUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroHelmAquaticUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroHelmAquaticUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroHelmAquaticUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroHelmAq.Rarity;
                            Weight.Text = App.equipment.necroHelmAq.weightClass;
                            Type.Text = App.equipment.necroHelmAq.Type;
                            level.Text = App.equipment.necroHelmAq.Level.ToString();

                            break;



                        case "Backpack":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroBackpack.Icon));
                            itemName.Text = App.equipment.necroBackpack.Name;
                            attribute1.Text = "+" + App.equipment.necroBackpack.Mod1.ToString() + " " + App.equipment.necroBackpack.Att1;
                            attribute2.Text = "+" + App.equipment.necroBackpack.Mod2.ToString() + " " + App.equipment.necroBackpack.Att2;
                            attribute3.Text = "+" + App.equipment.necroBackpack.Mod3.ToString() + " " + App.equipment.necroBackpack.Att3;
                            UpgradeName.Text = App.equipment.necroBackpackUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroBackpackUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroBackpackUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroBackpackUpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroBackpack.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroBackpack.Type;
                            level.Text = App.equipment.necroBackpack.Level.ToString();

                            break;


                        case "Gloves":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroGloves.Icon));
                            itemName.Text = App.equipment.necroGloves.Name;
                            attribute1.Text = "+" + App.equipment.necroGloves.Mod1.ToString() + " " + App.equipment.necroGloves.Att1;
                            attribute2.Text = "+" + App.equipment.necroGloves.Mod2.ToString() + " " + App.equipment.necroGloves.Att2;
                            attribute3.Text = "+" + App.equipment.necroGloves.Mod3.ToString() + " " + App.equipment.necroGloves.Att3;
                            UpgradeName.Text = App.equipment.necroGlovesUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroGlovesUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroGlovesUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroGlovesUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroGlovesUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroGlovesUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroGlovesUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroGloves.Rarity;
                            Weight.Text = App.equipment.necroGloves.weightClass;
                            Type.Text = App.equipment.necroGloves.Type;
                            level.Text = App.equipment.necroGloves.Level.ToString();

                            break;


                        case "Shoulders":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroShoulders.Icon));
                            itemName.Text = App.equipment.necroShoulders.Name;
                            attribute1.Text = "+" + App.equipment.necroShoulders.Mod1.ToString() + " " + App.equipment.necroShoulders.Att1;
                            attribute2.Text = "+" + App.equipment.necroShoulders.Mod2.ToString() + " " + App.equipment.necroShoulders.Att2;
                            attribute3.Text = "+" + App.equipment.necroShoulders.Mod3.ToString() + " " + App.equipment.necroShoulders.Att3;
                            UpgradeName.Text = App.equipment.necroShouldersUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroShouldersUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroShouldersUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroShouldersUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroShouldersUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroShouldersUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroShouldersUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroShoulders.Rarity;
                            Weight.Text = App.equipment.necroShoulders.weightClass;
                            Type.Text = App.equipment.necroShoulders.Type;
                            level.Text = App.equipment.necroShoulders.Level.ToString();

                            break;


                        case "Coat":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroCoat.Icon));
                            itemName.Text = App.equipment.necroCoat.Name;
                            attribute1.Text = "+" + App.equipment.necroCoat.Mod1.ToString() + " " + App.equipment.necroCoat.Att1;
                            attribute2.Text = "+" + App.equipment.necroCoat.Mod2.ToString() + " " + App.equipment.necroCoat.Att2;
                            attribute3.Text = "+" + App.equipment.necroCoat.Mod3.ToString() + " " + App.equipment.necroCoat.Att3;
                            UpgradeName.Text = App.equipment.necroCoatUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroCoatUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroCoatUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroCoatUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroCoatUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroCoatUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroCoatUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroCoat.Rarity;
                            Weight.Text = App.equipment.necroCoat.weightClass;
                            Type.Text = App.equipment.necroCoat.Type;
                            level.Text = App.equipment.necroCoat.Level.ToString();

                            break;


                        case "Leggings":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroLeggings.Icon));
                            itemName.Text = App.equipment.necroLeggings.Name;
                            attribute1.Text = "+" + App.equipment.necroLeggings.Mod1.ToString() + " " + App.equipment.necroLeggings.Att1;
                            attribute2.Text = "+" + App.equipment.necroLeggings.Mod2.ToString() + " " + App.equipment.necroLeggings.Att2;
                            attribute3.Text = "+" + App.equipment.necroLeggings.Mod3.ToString() + " " + App.equipment.necroLeggings.Att3;
                            UpgradeName.Text = App.equipment.necroLeggingsUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroLeggingsUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroLeggingsUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroLeggingsUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroLeggingsUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroLeggingsUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroLeggingsUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroLeggings.Rarity;
                            Weight.Text = App.equipment.necroLeggings.weightClass;
                            Type.Text = App.equipment.necroLeggings.Type;
                            level.Text = App.equipment.necroLeggings.Level.ToString();

                            break;


                        case "Boots":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroBoots.Icon));
                            itemName.Text = App.equipment.necroBoots.Name;
                            attribute1.Text = "+" + App.equipment.necroBoots.Mod1.ToString() + " " + App.equipment.necroBoots.Att1;
                            attribute2.Text = "+" + App.equipment.necroBoots.Mod2.ToString() + " " + App.equipment.necroBoots.Att2;
                            attribute3.Text = "+" + App.equipment.necroBoots.Mod3.ToString() + " " + App.equipment.necroBoots.Att3;
                            UpgradeName.Text = App.equipment.necroBootsUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroBootsUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroBootsUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroBootsUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.necroBootsUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.necroBootsUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.necroBootsUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.necroBoots.Rarity;
                            Weight.Text = App.equipment.necroBoots.weightClass;
                            Type.Text = App.equipment.necroBoots.Type;
                            level.Text = App.equipment.necroBoots.Level.ToString();

                            break;


                        case "WeaponA1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroWeaponA1.Icon));
                            itemName.Text = App.equipment.necroWeaponA1.Name;
                            attribute1.Text = "+" + App.equipment.necroWeaponA1.Mod1.ToString() + " " + App.equipment.necroWeaponA1.Att1;
                            attribute2.Text = "+" + App.equipment.necroWeaponA1.Mod2.ToString() + " " + App.equipment.necroWeaponA1.Att2;
                            attribute3.Text = "+" + App.equipment.necroWeaponA1.Mod3.ToString() + " " + App.equipment.necroWeaponA1.Att3;
                            UpgradeName.Text = App.equipment.necroWeaponA1UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroWeaponA1UpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroWeaponA1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroWeaponA1.Type;
                            level.Text = App.equipment.necroWeaponA1.Level.ToString();

                            break;


                        case "WeaponA2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroWeaponA2.Icon));
                            itemName.Text = App.equipment.necroWeaponA2.Name;
                            attribute1.Text = "+" + App.equipment.necroWeaponA2.Mod1.ToString() + " " + App.equipment.necroWeaponA2.Att1;
                            attribute2.Text = "+" + App.equipment.necroWeaponA2.Mod2.ToString() + " " + App.equipment.necroWeaponA2.Att2;
                            attribute3.Text = "+" + App.equipment.necroWeaponA2.Mod3.ToString() + " " + App.equipment.necroWeaponA2.Att3;
                            UpgradeName.Text = App.equipment.necroWeaponA2UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroWeaponA2UpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroWeaponA2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroWeaponA2.Type;
                            level.Text = App.equipment.necroWeaponA2.Level.ToString();

                            break;


                        case "WeaponB1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroWeaponB1.Icon));
                            itemName.Text = App.equipment.necroWeaponB1.Name;
                            attribute1.Text = "+" + App.equipment.necroWeaponB1.Mod1.ToString() + " " + App.equipment.necroWeaponB1.Att1;
                            attribute2.Text = "+" + App.equipment.necroWeaponB1.Mod2.ToString() + " " + App.equipment.necroWeaponB1.Att2;
                            attribute3.Text = "+" + App.equipment.necroWeaponB1.Mod3.ToString() + " " + App.equipment.necroWeaponB1.Att3;
                            UpgradeName.Text = App.equipment.necroWeaponB1UpgradeSlot1.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroWeaponB1UpgradeSlot1.Bonus1;
                            Bonus2.Text = App.equipment.necroWeaponB1UpgradeSlot2.Name;
                            Bonus3.Text = "(2) " + App.equipment.necroWeaponB1UpgradeSlot2.Bonus1;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroWeaponB1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroWeaponB1.Type;
                            level.Text = App.equipment.necroWeaponB1.Level.ToString();

                            break;


                        case "WeaponB2":


                            break;


                        case "Accessory1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroAccessory1.Icon));
                            itemName.Text = App.equipment.necroAccessory1.Name;
                            attribute1.Text = "+" + App.equipment.necroAccessory1.Mod1.ToString() + " " + App.equipment.necroAccessory1.Att1;
                            attribute2.Text = "+" + App.equipment.necroAccessory1.Mod2.ToString() + " " + App.equipment.necroAccessory1.Att2;
                            attribute3.Text = "+" + App.equipment.necroAccessory1.Mod3.ToString() + " " + App.equipment.necroAccessory1.Att3;
                            UpgradeName.Text = App.equipment.necroAccessory1UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroAccessory1UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroAccessory1UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroAccessory1UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroAccessory1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroAccessory1.Type;
                            level.Text = App.equipment.necroAccessory1.Level.ToString();

                            break;


                        case "Accessory2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroAccessory2.Icon));
                            itemName.Text = App.equipment.necroAccessory2.Name;
                            attribute1.Text = "+" + App.equipment.necroAccessory2.Mod1.ToString() + " " + App.equipment.necroAccessory2.Att1;
                            attribute2.Text = "+" + App.equipment.necroAccessory2.Mod2.ToString() + " " + App.equipment.necroAccessory2.Att2;
                            attribute3.Text = "+" + App.equipment.necroAccessory2.Mod3.ToString() + " " + App.equipment.necroAccessory2.Att3;
                            UpgradeName.Text = App.equipment.necroAccessory2UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroAccessory2UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroAccessory2UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroAccessory2UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroAccessory2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroAccessory2.Type;
                            level.Text = App.equipment.necroAccessory2.Level.ToString();

                            break;


                        case "Amulet":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroAmulet.Icon));
                            itemName.Text = App.equipment.necroAmulet.Name;
                            attribute1.Text = "+" + App.equipment.necroAmulet.Mod1.ToString() + " " + App.equipment.necroAmulet.Att1;
                            attribute2.Text = "+" + App.equipment.necroAmulet.Mod2.ToString() + " " + App.equipment.necroAmulet.Att2;
                            attribute3.Text = "+" + App.equipment.necroAmulet.Mod3.ToString() + " " + App.equipment.necroAmulet.Att3;
                            UpgradeName.Text = App.equipment.necroAmuletUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroAmuletUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroAmuletUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroAmuletUpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroAmulet.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroAmulet.Type;
                            level.Text = App.equipment.necroAmulet.Level.ToString();

                            break;


                        case "Ring1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroRing1.Icon));
                            itemName.Text = App.equipment.necroRing1.Name;
                            attribute1.Text = "+" + App.equipment.necroRing1.Mod1.ToString() + " " + App.equipment.necroRing1.Att1;
                            attribute2.Text = "+" + App.equipment.necroRing1.Mod2.ToString() + " " + App.equipment.necroRing1.Att2;
                            attribute3.Text = "+" + App.equipment.necroRing1.Mod3.ToString() + " " + App.equipment.necroRing1.Att3;
                            UpgradeName.Text = App.equipment.necroRing1UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroRing1UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroRing1UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroRing1UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroRing1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroRing1.Type;
                            level.Text = App.equipment.necroRing1.Level.ToString();

                            break;


                        case "Ring2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroRing2.Icon));
                            itemName.Text = App.equipment.necroRing2.Name;
                            attribute1.Text = "+" + App.equipment.necroRing2.Mod1.ToString() + " " + App.equipment.necroRing2.Att1;
                            attribute2.Text = "+" + App.equipment.necroRing2.Mod2.ToString() + " " + App.equipment.necroRing2.Att2;
                            attribute3.Text = "+" + App.equipment.necroRing2.Mod3.ToString() + " " + App.equipment.necroRing2.Att3;
                            UpgradeName.Text = App.equipment.necroRing2UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroRing2UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.necroRing2UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.necroRing2UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroRing2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroRing2.Type;
                            level.Text = App.equipment.necroRing2.Level.ToString();

                            break;


                        case "Sickle":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroSickle.Icon));
                            itemName.Text = App.equipment.necroSickle.Name;
                            itemDefenceBreak.Text = "";
                            itemDefenceValue.Text = "";
                            attribute1.Text = App.equipment.necroSickle.Description;
                            attribute2.Text = "";
                            attribute3.Text = "";
                            UpgradeName.Text = "";
                            Bonus1.Text = "";
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroSickle.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroSickle.Type;
                            level.Text = App.equipment.necroSickle.Level.ToString();

                            break;


                        case "Axe":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroAxe.Icon));
                            itemName.Text = App.equipment.necroAxe.Name;
                            itemDefenceBreak.Text = "";
                            itemDefenceValue.Text = "";
                            attribute1.Text = App.equipment.necroAxe.Description;
                            attribute2.Text = "";
                            attribute3.Text = "";
                            UpgradeName.Text = "";
                            Bonus1.Text = "";
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroAxe.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroAxe.Type;
                            level.Text = App.equipment.necroAxe.Level.ToString();

                            break;


                        case "Pick":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroPick.Icon));
                            itemName.Text = App.equipment.necroPick.Name;
                            itemDefenceBreak.Text = "";
                            itemDefenceValue.Text = "";
                            attribute1.Text = App.equipment.necroPick.Description;
                            attribute2.Text = "";
                            attribute3.Text = "";
                            UpgradeName.Text = "";
                            Bonus1.Text = "";
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroPick.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroPick.Type;
                            level.Text = App.equipment.necroPick.Level.ToString();

                            break;


                        case "AquaticWeaponA":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroWeaponAquaticA.Icon));
                            itemName.Text = App.equipment.necroWeaponAquaticA.Name;
                            attribute1.Text = "+" + App.equipment.necroWeaponAquaticA.Mod1.ToString() + " " + App.equipment.necroWeaponAquaticA.Att1;
                            attribute2.Text = "+" + App.equipment.necroWeaponAquaticA.Mod2.ToString() + " " + App.equipment.necroWeaponAquaticA.Att2;
                            attribute3.Text = "+" + App.equipment.necroWeaponAquaticA.Mod3.ToString() + " " + App.equipment.necroWeaponAquaticA.Att3;
                            UpgradeName.Text = App.equipment.necroWeaponAquaticAUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroWeaponAquaticAUpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroWeaponAquaticA.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroWeaponAquaticA.Type;
                            level.Text = App.equipment.necroWeaponAquaticA.Level.ToString();

                            break;

                        case "AquaticWeaponB":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.necroWeaponAquaticB.Icon));
                            itemName.Text = App.equipment.necroWeaponAquaticB.Name;
                            attribute1.Text = "+" + App.equipment.necroWeaponAquaticB.Mod1.ToString() + " " + App.equipment.necroWeaponAquaticB.Att1;
                            attribute2.Text = "+" + App.equipment.necroWeaponAquaticB.Mod2.ToString() + " " + App.equipment.necroWeaponAquaticB.Att2;
                            attribute3.Text = "+" + App.equipment.necroWeaponAquaticB.Mod3.ToString() + " " + App.equipment.necroWeaponAquaticB.Att3;
                            UpgradeName.Text = App.equipment.necroWeaponAquaticBUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.necroWeaponAquaticBUpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.necroWeaponAquaticB.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.necroWeaponAquaticB.Type;
                            level.Text = App.equipment.necroWeaponAquaticB.Level.ToString();

                            break;
                            #endregion

                    }
                    break;

                case 1:
                    switch (passedItemName)
                    {

                        #region Mesmer

                        case "Helm":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerHelm.Icon));
                            itemName.Text = App.equipment.mesmerHelm.Name;
                            attribute1.Text = "+" + App.equipment.mesmerHelm.Mod1.ToString() + " " + App.equipment.mesmerHelm.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerHelm.Mod2.ToString() + " " + App.equipment.mesmerHelm.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerHelm.Mod3.ToString() + " " + App.equipment.mesmerHelm.Att3;
                            UpgradeName.Text = App.equipment.mesmerHelmUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerHelmUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerHelmUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerHelmUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.mesmerHelmUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.mesmerHelmUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.mesmerHelmUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.mesmerHelm.Rarity;
                            Weight.Text = App.equipment.mesmerHelm.weightClass;
                            Type.Text = App.equipment.mesmerHelm.Type;
                            level.Text = App.equipment.mesmerHelm.Level.ToString();

                            break;

                        case "AquaticHelm":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerHelmAq.Icon));
                            itemName.Text = App.equipment.mesmerHelmAq.Name;
                            attribute1.Text = "+" + App.equipment.mesmerHelmAq.Mod1.ToString() + " " + App.equipment.mesmerHelmAq.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerHelmAq.Mod2.ToString() + " " + App.equipment.mesmerHelmAq.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerHelmAq.Mod3.ToString() + " " + App.equipment.mesmerHelmAq.Att3;
                            UpgradeName.Text = App.equipment.mesmerHelmAquaticUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerHelmAquaticUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerHelmAquaticUpgradeSlot.Bonus2;
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerHelmAq.Rarity;
                            Weight.Text = App.equipment.mesmerHelmAq.weightClass;
                            Type.Text = App.equipment.mesmerHelmAq.Type;
                            level.Text = App.equipment.mesmerHelmAq.Level.ToString();

                            break;



                        case "Backpack":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerBackpack.Icon));
                            itemName.Text = App.equipment.mesmerBackpack.Name;
                            attribute1.Text = "+" + App.equipment.mesmerBackpack.Mod1.ToString() + " " + App.equipment.mesmerBackpack.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerBackpack.Mod2.ToString() + " " + App.equipment.mesmerBackpack.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerBackpack.Mod3.ToString() + " " + App.equipment.mesmerBackpack.Att3;
                            UpgradeName.Text = App.equipment.mesmerBackpackUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerBackpackUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerBackpackUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerBackpackUpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerBackpack.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerBackpack.Type;
                            level.Text = App.equipment.mesmerBackpack.Level.ToString();

                            break;


                        case "Gloves":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerGloves.Icon));
                            itemName.Text = App.equipment.mesmerGloves.Name;
                            attribute1.Text = "+" + App.equipment.mesmerGloves.Mod1.ToString() + " " + App.equipment.mesmerGloves.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerGloves.Mod2.ToString() + " " + App.equipment.mesmerGloves.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerGloves.Mod3.ToString() + " " + App.equipment.mesmerGloves.Att3;
                            UpgradeName.Text = App.equipment.mesmerGlovesUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerGlovesUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerGlovesUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerGlovesUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.mesmerGlovesUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.mesmerGlovesUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.mesmerGlovesUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.mesmerGloves.Rarity;
                            Weight.Text = App.equipment.mesmerGloves.weightClass;
                            Type.Text = App.equipment.mesmerGloves.Type;
                            level.Text = App.equipment.mesmerGloves.Level.ToString();

                            break;


                        case "Shoulders":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerShoulders.Icon));
                            itemName.Text = App.equipment.mesmerShoulders.Name;
                            attribute1.Text = "+" + App.equipment.mesmerShoulders.Mod1.ToString() + " " + App.equipment.mesmerShoulders.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerShoulders.Mod2.ToString() + " " + App.equipment.mesmerShoulders.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerShoulders.Mod3.ToString() + " " + App.equipment.mesmerShoulders.Att3;
                            UpgradeName.Text = App.equipment.mesmerShouldersUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerShouldersUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerShouldersUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerShouldersUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.mesmerShouldersUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.mesmerShouldersUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.mesmerShouldersUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.mesmerShoulders.Rarity;
                            Weight.Text = App.equipment.mesmerShoulders.weightClass;
                            Type.Text = App.equipment.mesmerShoulders.Type;
                            level.Text = App.equipment.mesmerShoulders.Level.ToString();

                            break;


                        case "Coat":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerCoat.Icon));
                            itemName.Text = App.equipment.mesmerCoat.Name;
                            attribute1.Text = "+" + App.equipment.mesmerCoat.Mod1.ToString() + " " + App.equipment.mesmerCoat.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerCoat.Mod2.ToString() + " " + App.equipment.mesmerCoat.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerCoat.Mod3.ToString() + " " + App.equipment.mesmerCoat.Att3;
                            UpgradeName.Text = App.equipment.mesmerCoatUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerCoatUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerCoatUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerCoatUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.mesmerCoatUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.mesmerCoatUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.mesmerCoatUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.mesmerCoat.Rarity;
                            Weight.Text = App.equipment.mesmerCoat.weightClass;
                            Type.Text = App.equipment.mesmerCoat.Type;
                            level.Text = App.equipment.mesmerCoat.Level.ToString();

                            break;


                        case "Leggings":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerLeggings.Icon));
                            itemName.Text = App.equipment.mesmerLeggings.Name;
                            attribute1.Text = "+" + App.equipment.mesmerLeggings.Mod1.ToString() + " " + App.equipment.mesmerLeggings.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerLeggings.Mod2.ToString() + " " + App.equipment.mesmerLeggings.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerLeggings.Mod3.ToString() + " " + App.equipment.mesmerLeggings.Att3;
                            UpgradeName.Text = App.equipment.mesmerLeggingsUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerLeggingsUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerLeggingsUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerLeggingsUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.mesmerLeggingsUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.mesmerLeggingsUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.mesmerLeggingsUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.mesmerLeggings.Rarity;
                            Weight.Text = App.equipment.mesmerLeggings.weightClass;
                            Type.Text = App.equipment.mesmerLeggings.Type;
                            level.Text = App.equipment.mesmerLeggings.Level.ToString();

                            break;


                        case "Boots":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerBoots.Icon));
                            itemName.Text = App.equipment.mesmerBoots.Name;
                            attribute1.Text = "+" + App.equipment.mesmerBoots.Mod1.ToString() + " " + App.equipment.mesmerBoots.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerBoots.Mod2.ToString() + " " + App.equipment.mesmerBoots.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerBoots.Mod3.ToString() + " " + App.equipment.mesmerBoots.Att3;
                            UpgradeName.Text = App.equipment.mesmerBootsUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerBootsUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerBootsUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerBootsUpgradeSlot.Bonus3;
                            Bonus4.Text = "(4) " + App.equipment.mesmerBootsUpgradeSlot.Bonus4;
                            Bonus5.Text = "(5) " + App.equipment.mesmerBootsUpgradeSlot.Bonus5;
                            Bonus6.Text = "(6) " + App.equipment.mesmerBootsUpgradeSlot.Bonus6;
                            Rarity.Text = App.equipment.mesmerBoots.Rarity;
                            Weight.Text = App.equipment.mesmerBoots.weightClass;
                            Type.Text = App.equipment.mesmerBoots.Type;
                            level.Text = App.equipment.mesmerBoots.Level.ToString();

                            break;


                        case "WeaponA1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponA1.Icon));
                            itemName.Text = App.equipment.mesmerWeaponA1.Name;
                            attribute1.Text = "+" + App.equipment.mesmerWeaponA1.Mod1.ToString() + " " + App.equipment.mesmerWeaponA1.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerWeaponA1.Mod2.ToString() + " " + App.equipment.mesmerWeaponA1.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerWeaponA1.Mod3.ToString() + " " + App.equipment.mesmerWeaponA1.Att3;
                            UpgradeName.Text = App.equipment.mesmerWeaponA1UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerWeaponA1UpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerWeaponA1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerWeaponA1.Type;
                            level.Text = App.equipment.mesmerWeaponA1.Level.ToString();

                            break;


                        case "WeaponA2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponA2.Icon));
                            itemName.Text = App.equipment.mesmerWeaponA2.Name;
                            attribute1.Text = "+" + App.equipment.mesmerWeaponA2.Mod1.ToString() + " " + App.equipment.mesmerWeaponA2.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerWeaponA2.Mod2.ToString() + " " + App.equipment.mesmerWeaponA2.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerWeaponA2.Mod3.ToString() + " " + App.equipment.mesmerWeaponA2.Att3;
                            UpgradeName.Text = App.equipment.mesmerWeaponA2UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerWeaponA2UpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerWeaponA2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerWeaponA2.Type;
                            level.Text = App.equipment.mesmerWeaponA2.Level.ToString();

                            break;


                        case "WeaponB1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponB1.Icon));
                            itemName.Text = App.equipment.mesmerWeaponB1.Name;
                            attribute1.Text = "+" + App.equipment.mesmerWeaponB1.Mod1.ToString() + " " + App.equipment.mesmerWeaponB1.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerWeaponB1.Mod2.ToString() + " " + App.equipment.mesmerWeaponB1.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerWeaponB1.Mod3.ToString() + " " + App.equipment.mesmerWeaponB1.Att3;
                            UpgradeName.Text = App.equipment.mesmerWeaponB1UpgradeSlot1.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerWeaponB1UpgradeSlot1.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerWeaponB1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerWeaponB1.Type;
                            level.Text = App.equipment.mesmerWeaponB1.Level.ToString();

                            break;


                        case "WeaponB2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponB2.Icon));
                            itemName.Text = App.equipment.mesmerWeaponB2.Name;
                            attribute1.Text = "+" + App.equipment.mesmerWeaponB2.Mod1.ToString() + " " + App.equipment.mesmerWeaponB2.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerWeaponB2.Mod2.ToString() + " " + App.equipment.mesmerWeaponB2.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerWeaponB2.Mod3.ToString() + " " + App.equipment.mesmerWeaponB2.Att3;
                            UpgradeName.Text = App.equipment.mesmerWeaponB2UpgradeSlot2.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerWeaponB2UpgradeSlot2.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerWeaponB2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerWeaponB2.Type;
                            level.Text = App.equipment.mesmerWeaponB2.Level.ToString();

                            break;


                        case "Accessory1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerAccessory1.Icon));
                            itemName.Text = App.equipment.mesmerAccessory1.Name;
                            attribute1.Text = "+" + App.equipment.mesmerAccessory1.Mod1.ToString() + " " + App.equipment.mesmerAccessory1.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerAccessory1.Mod2.ToString() + " " + App.equipment.mesmerAccessory1.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerAccessory1.Mod3.ToString() + " " + App.equipment.mesmerAccessory1.Att3;
                            UpgradeName.Text = App.equipment.mesmerAccessory1UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerAccessory1UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerAccessory1UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerAccessory1UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerAccessory1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerAccessory1.Type;
                            level.Text = App.equipment.mesmerAccessory1.Level.ToString();

                            break;


                        case "Accessory2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerAccessory2.Icon));
                            itemName.Text = App.equipment.mesmerAccessory2.Name;
                            attribute1.Text = "+" + App.equipment.mesmerAccessory2.Mod1.ToString() + " " + App.equipment.mesmerAccessory2.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerAccessory2.Mod2.ToString() + " " + App.equipment.mesmerAccessory2.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerAccessory2.Mod3.ToString() + " " + App.equipment.mesmerAccessory2.Att3;
                            UpgradeName.Text = App.equipment.mesmerAccessory2UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerAccessory2UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerAccessory2UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerAccessory2UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerAccessory2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerAccessory2.Type;
                            level.Text = App.equipment.mesmerAccessory2.Level.ToString();

                            break;


                        case "Amulet":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerAmulet.Icon));
                            itemName.Text = App.equipment.mesmerAmulet.Name;
                            attribute1.Text = "+" + App.equipment.mesmerAmulet.Mod1.ToString() + " " + App.equipment.mesmerAmulet.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerAmulet.Mod2.ToString() + " " + App.equipment.mesmerAmulet.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerAmulet.Mod3.ToString() + " " + App.equipment.mesmerAmulet.Att3;
                            UpgradeName.Text = App.equipment.mesmerAmuletUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerAmuletUpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerAmuletUpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerAmuletUpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerAmulet.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerAmulet.Type;
                            level.Text = App.equipment.mesmerAmulet.Level.ToString();

                            break;


                        case "Ring1":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerRing1.Icon));
                            itemName.Text = App.equipment.mesmerRing1.Name;
                            attribute1.Text = "+" + App.equipment.mesmerRing1.Mod1.ToString() + " " + App.equipment.mesmerRing1.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerRing1.Mod2.ToString() + " " + App.equipment.mesmerRing1.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerRing1.Mod3.ToString() + " " + App.equipment.mesmerRing1.Att3;
                            UpgradeName.Text = App.equipment.mesmerRing1UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerRing1UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerRing1UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerRing1UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerRing1.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerRing1.Type;
                            level.Text = App.equipment.mesmerRing1.Level.ToString();

                            break;


                        case "Ring2":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerRing2.Icon));
                            itemName.Text = App.equipment.mesmerRing2.Name;
                            attribute1.Text = "+" + App.equipment.mesmerRing2.Mod1.ToString() + " " + App.equipment.mesmerRing2.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerRing2.Mod2.ToString() + " " + App.equipment.mesmerRing2.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerRing2.Mod3.ToString() + " " + App.equipment.mesmerRing2.Att3;
                            UpgradeName.Text = App.equipment.mesmerRing2UpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerRing2UpgradeSlot.Bonus1;
                            Bonus2.Text = "(2) " + App.equipment.mesmerRing2UpgradeSlot.Bonus2;
                            Bonus3.Text = "(3) " + App.equipment.mesmerRing2UpgradeSlot.Bonus3;
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerRing2.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerRing2.Type;
                            level.Text = App.equipment.mesmerRing2.Level.ToString();

                            break;


                        case "Sickle":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerSickle.Icon));
                            itemName.Text = App.equipment.mesmerSickle.Name;
                            itemDefenceBreak.Text = "";
                            itemDefenceValue.Text = "";
                            attribute1.Text = App.equipment.mesmerSickle.Description;
                            attribute2.Text = "";
                            attribute3.Text = "";
                            UpgradeName.Text = "";
                            Bonus1.Text = "";
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerSickle.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerSickle.Type;
                            level.Text = App.equipment.mesmerSickle.Level.ToString();

                            break;


                        case "Axe":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerAxe.Icon));
                            itemName.Text = App.equipment.mesmerAxe.Name;
                            itemDefenceBreak.Text = "";
                            itemDefenceValue.Text = "";
                            attribute1.Text = App.equipment.mesmerAxe.Description;
                            attribute2.Text = "";
                            attribute3.Text = "";
                            UpgradeName.Text = "";
                            Bonus1.Text = "";
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerAxe.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerAxe.Type;
                            level.Text = App.equipment.mesmerAxe.Level.ToString();

                            break;


                        case "Pick":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerPick.Icon));
                            itemName.Text = App.equipment.mesmerPick.Name;
                            itemDefenceBreak.Text = "";
                            itemDefenceValue.Text = "";
                            attribute1.Text = App.equipment.mesmerPick.Description;
                            attribute2.Text = "";
                            attribute3.Text = "";
                            UpgradeName.Text = "";
                            Bonus1.Text = "";
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerPick.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerPick.Type;
                            level.Text = App.equipment.mesmerPick.Level.ToString();

                            break;


                        case "AquaticWeaponA":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponAquaticA.Icon));
                            itemName.Text = App.equipment.mesmerWeaponAquaticA.Name;
                            attribute1.Text = "+" + App.equipment.mesmerWeaponAquaticA.Mod1.ToString() + " " + App.equipment.mesmerWeaponAquaticA.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerWeaponAquaticA.Mod2.ToString() + " " + App.equipment.mesmerWeaponAquaticA.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerWeaponAquaticA.Mod3.ToString() + " " + App.equipment.mesmerWeaponAquaticA.Att3;
                            UpgradeName.Text = App.equipment.mesmerWeaponAquaticAUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerWeaponAquaticAUpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerWeaponAquaticA.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerWeaponAquaticA.Type;
                            level.Text = App.equipment.mesmerWeaponAquaticA.Level.ToString();

                            break;

                        case "AquaticWeaponB":

                            imageIcon.Source = new BitmapImage(new Uri(App.equipment.mesmerWeaponAquaticB.Icon));
                            itemName.Text = App.equipment.mesmerWeaponAquaticB.Name;
                            attribute1.Text = "+" + App.equipment.mesmerWeaponAquaticB.Mod1.ToString() + " " + App.equipment.mesmerWeaponAquaticB.Att1;
                            attribute2.Text = "+" + App.equipment.mesmerWeaponAquaticB.Mod2.ToString() + " " + App.equipment.mesmerWeaponAquaticB.Att2;
                            attribute3.Text = "+" + App.equipment.mesmerWeaponAquaticB.Mod3.ToString() + " " + App.equipment.mesmerWeaponAquaticB.Att3;
                            UpgradeName.Text = App.equipment.mesmerWeaponAquaticBUpgradeSlot.Name;
                            Bonus1.Text = "(1) " + App.equipment.mesmerWeaponAquaticBUpgradeSlot.Bonus1;
                            Bonus2.Text = "";
                            Bonus3.Text = "";
                            Bonus4.Text = "";
                            Bonus5.Text = "";
                            Bonus6.Text = "";
                            Rarity.Text = App.equipment.mesmerWeaponAquaticB.Rarity;
                            Weight.Text = "";
                            Type.Text = App.equipment.mesmerWeaponAquaticB.Type;
                            level.Text = App.equipment.mesmerWeaponAquaticB.Level.ToString();

                            break;

                            #endregion
                    }
                    break;
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


    }
}
