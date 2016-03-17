using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace gw2Prototype
{

    /******
    
        NOTE, GW2 does not have a method or a way to actually get character models yet, this may be implemented in the future.
        So, right now there will be no head shot of a character which would normally sit beside the basic information.
        
        
    *******/ 




    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        /// 

        // Class for the character specializations
        internal class Specializations
        {

            #region traits getters/setters

            #region Specializations One
            internal string specializationOneBackground { get; set; }
            internal string specializationOneIcon { get; set; }
            #endregion

            #region Specialization Minor Trait One
            internal string specOneMinorTraitOne { get; set; }
            internal string specOneMinorTraitTwo { get; set; }
            internal string specOneMinorTraitThree { get; set; }
            #endregion

            #region Specialization Major Trait One
            internal string specOneMajorTraitOne { get; set; }
            internal string specOneMajorTraitTwo { get; set; }
            internal string specOneMajorTraitThree { get; set; }
            internal string specOneMajorTraitFour { get; set; }
            internal string specOneMajorTraitFive { get; set; }
            internal string specOneMajorTraitSix { get; set; }
            internal string specOneMajorTraitSeven { get; set; }
            internal string specOneMajorTraitEight { get; set; }
            internal string specOneMajorTraitNine { get; set; }
            #endregion

            #region Specializations Two

            internal string specializationTwoBackground { get; set; }
            internal string specializationTwoIcon { get; set; }
            #endregion

            #region Specialization Minor Trait Two
            internal string specTwoMinorTraitOne { get; set; }
            internal string specTwoMinorTraitTwo { get; set; }
            internal string specTwoMinorTraitThree { get; set; }
            #endregion

            #region Specialization Major Trait Two
            internal string specTwoMajorTraitOne { get; set; }
            internal string specTwoMajorTraitTwo { get; set; }
            internal string specTwoMajorTraitThree { get; set; }
            internal string specTwoMajorTraitFour { get; set; }
            internal string specTwoMajorTraitFive { get; set; }
            internal string specTwoMajorTraitSix { get; set; }
            internal string specTwoMajorTraitSeven { get; set; }
            internal string specTwoMajorTraitEight { get; set; }
            internal string specTwoMajorTraitNine { get; set; }
            #endregion

            #region Specializations Three

            internal string specializationThreeBackground { get; set; }
            internal string specializationThreeIcon { get; set; }
            #endregion

            #region Specialization Minor Trait Three
            internal string specThreeMinorTraitOne { get; set; }
            internal string specThreeMinorTraitTwo { get; set; }
            internal string specThreeMinorTraitThree { get; set; }
            #endregion

            #region Specialization Major Trait Three
            internal string specThreeMajorTraitOne { get; set; }
            internal string specThreeMajorTraitTwo { get; set; }
            internal string specThreeMajorTraitThree { get; set; }
            internal string specThreeMajorTraitFour { get; set; }
            internal string specThreeMajorTraitFive { get; set; }
            internal string specThreeMajorTraitSix { get; set; }
            internal string specThreeMajorTraitSeven { get; set; }
            internal string specThreeMajorTraitEight { get; set; }
            internal string specThreeMajorTraitNine { get; set; }
            #endregion

            #endregion



            internal Specializations
                (
                    string specializationonebackground,
                    string specializationoneicon,

                    string speconeminortraitone,
                    string speconeminortraittwo,
                    string speconeminortraitthree,

                        string speconemajortraitone,
                        string speconemajortraittwo,
                        string speconemajortraitthree,
                        string speconemajortraitfour,
                        string speconemajortraitfive,
                        string speconemajortraitsix,
                        string speconemajortraitseven,
                        string speconemajortraiteight,
                        string speconemajortraitnine,


                string specializationtwobackground,
                string specializationtwoicon,

                    string spectwominortraitone,
                    string spectwominortraittwo,
                    string spectwominortraitthree,

                        string spectwomajortraitone,
                        string spectwomajortraittwo,
                        string spectwomajortraitthree,
                        string spectwomajortraitfour,
                        string spectwomajortraitfive,
                        string spectwomajortraitsix,
                        string spectwomajortraitseven,
                        string spectwomajortraiteight,
                        string spectwomajortraitnine,

                string specializationthreebackground,
                string specializationthreeicon,

                    string specthreeminortraitone,
                    string specthreeminortraittwo,
                    string specthreeminortraitthree,

                        string specthreemajortraitfour,
                        string specthreemajortraitone,
                        string specthreemajortraittwo,
                        string specthreemajortraitthree,
                        string specthreemajortraitfive,
                        string specthreemajortraitsix,
                        string specthreemajortraitseven,
                        string specthreemajortraiteight,
                        string specthreemajortraitnine

                )
            {

                specializationOneBackground = specializationonebackground;
                specializationOneIcon = specializationoneicon;

                specOneMinorTraitOne = speconeminortraitone;
                specOneMinorTraitTwo = speconeminortraittwo;
                specOneMinorTraitThree = speconeminortraitthree;


                specOneMajorTraitOne = speconemajortraitone;
                specOneMajorTraitTwo = speconemajortraittwo;
                specOneMajorTraitThree = speconemajortraitthree;
                specOneMajorTraitFour = speconemajortraitfour;
                specOneMajorTraitFive = speconemajortraitfive;
                specOneMajorTraitSix = speconemajortraitsix;
                specOneMajorTraitSeven = speconemajortraitseven;
                specOneMajorTraitEight = speconemajortraiteight;
                specOneMajorTraitNine = speconemajortraitnine;



                specializationTwoBackground = specializationtwobackground;
                specializationTwoIcon = specializationtwoicon;

                specTwoMinorTraitOne = spectwominortraitone;
                specTwoMinorTraitTwo = spectwominortraittwo;
                specTwoMinorTraitThree = spectwominortraitthree;


                specTwoMajorTraitOne = spectwomajortraitone;
                specTwoMajorTraitTwo = spectwomajortraittwo;
                specTwoMajorTraitThree = spectwomajortraitthree;
                specTwoMajorTraitFour = spectwomajortraitfour;
                specTwoMajorTraitFive = spectwomajortraitfive;
                specTwoMajorTraitSix = spectwomajortraitsix;
                specTwoMajorTraitSeven = spectwomajortraitseven;
                specTwoMajorTraitEight = spectwomajortraiteight;
                specTwoMajorTraitNine = spectwomajortraitnine;


                specializationThreeBackground = specializationthreebackground;
                specializationThreeIcon = specializationthreeicon;

                specThreeMinorTraitOne = specthreeminortraitone;
                specThreeMinorTraitTwo = specthreeminortraittwo;
                specThreeMinorTraitThree = specthreeminortraitthree;


                specThreeMajorTraitOne = specthreemajortraitone;
                specThreeMajorTraitTwo = specthreemajortraittwo;
                specThreeMajorTraitThree = specthreemajortraitthree;
                specThreeMajorTraitFour = specthreemajortraitfour;
                specThreeMajorTraitFive = specthreemajortraitfive;
                specThreeMajorTraitSix = specthreemajortraitsix;
                specThreeMajorTraitSeven = specthreemajortraitseven;
                specThreeMajorTraitEight = specthreemajortraiteight;
                specThreeMajorTraitNine = specthreemajortraitnine;

            }
        }

        #region Necromancer Specs
        static internal Specializations Necromancer = new Specializations(

             "https://render.guildwars2.com/file/DDF39DBD61CCC1BCDD03B271080869251D097041/1012073.png",
             "https://render.guildwars2.com/file/2D34377B04051FFDCDB553C7DCDABCD5DFBB68D7/1012011.png",

             "https://render.guildwars2.com/file/080173CE4527AF48B3F90770C8FB676343EBDB02/1012603.png",
             "https://render.guildwars2.com/file/FD34100F781539CF49B657412CDBD9B170D6C964/1012605.png",
             "https://render.guildwars2.com/file/F9CC326D70BFDFAED0054C27F721362AFB32177E/1012604.png",

             "https://render.guildwars2.com/file/4FDFAB1B3BFF06F6044A491B04967C5D03526B0B/1012594.png",
             "https://render.guildwars2.com/file/EFCE14DF279DDD28C54077500B03DEC1B692120A/1012595.png",
             "https://render.guildwars2.com/file/2431E825115DA7FF690C091C2316AAB9F493B93A/1012596.png",
             "https://render.guildwars2.com/file/FED2475CCB0936A368AB44DA729EE0AFACBBBE06/1012597.png",
             "https://render.guildwars2.com/file/6272F31C9A6D02196C0891040C4A9C0108901BDA/1012598.png",
             "https://render.guildwars2.com/file/7BC853D02CC59AD43A677E3D515674AA1D3FE164/1012599.png",
             "https://render.guildwars2.com/file/EEB462072294673B6ADC280A2374216047529798/1012600.png",
             "https://render.guildwars2.com/file/ADD8DB0EA734C99FE123FF0A513E0D124FD4AC2E/1012601.png",
             "https://render.guildwars2.com/file/9775E905A6CBDF95CB106A0F95B79E74132CAF9C/1012602.png",


             "https://render.guildwars2.com/file/47F5CA90475E566650EF540BA82CA69C1C0332B1/1012063.png",
             "https://render.guildwars2.com/file/D1D9C63AD9CC05FC1B19970556B0C1E0ADD77905/1012006.png",

             "https://render.guildwars2.com/file/34F665FF0ADC0CAED190126A0E40DEF99BFCABCB/1012543.png",
             "https://render.guildwars2.com/file/0DF523B154B8FD9F2E2B95F72A534E7C80352D2A/1012544.png",
             "https://render.guildwars2.com/file/FCCF489066E7F22BFECB5F165060E2A5C96B5AC9/1012545.png",

             "https://render.guildwars2.com/file/9348E1E1E5F166C69149984029A15FE2F2D9F40D/1012534.png",
             "https://render.guildwars2.com/file/09266890E7D1517B2D634E026A67696ABDBCDBC3/1012535.png",
             "https://render.guildwars2.com/file/E44619EFE79BCAE2030E0A3A1CDBAE411A062403/1012536.png",
             "https://render.guildwars2.com/file/B8310A13D0A908D9BBFC2607010AF79E399394AE/1012537.png",
             "https://render.guildwars2.com/file/BF29CCF73E0706164344A239B165671BF0357294/1012538.png",
             "https://render.guildwars2.com/file/22B370D754AC1D69A8FE66DCCB36BE940455E5EA/1012539.png",
             "https://render.guildwars2.com/file/E30A6FB90D92AAC603A61EB9DF9E520959FB04FD/1012540.png",
             "https://render.guildwars2.com/file/0F286EE6A91BB2E628DD2703EE5E3E35070AFD0E/1012541.png",
             "https://render.guildwars2.com/file/7732E03BF4E6CD02BAFF0DDC04780A6F177549CE/1012542.png",


             "https://render.guildwars2.com/file/0956926B4A5109E07EFAB556E5DBEDCBC2B67C3B/1012071.png",
             "https://render.guildwars2.com/file/A5A95CB5FADD99F59E07400907F0782B659574A9/1012010.png",

             "https://render.guildwars2.com/file/2C254E1B7AEA1101FA25FCE610EB074E32B8CD02/1012591.png",
             "https://render.guildwars2.com/file/75273DA6696969760BB6D765E56D0CDCD0ABBA43/1012592.png",
             "https://render.guildwars2.com/file/022357BDC7179BBBF7679BD0A5B80EF59E02B050/1012593.png",

             "https://render.guildwars2.com/file/C161543798EAA41863E26E3250FD534E4C1E357C/1012582.png",
             "https://render.guildwars2.com/file/33961B371EDB0C0DC8FCC9963E0C9F103D6891DB/1012583.png",
             "https://render.guildwars2.com/file/6DDE13189AD8C45020D1CC1F0803E329F26839CB/1012584.png",
             "https://render.guildwars2.com/file/59A0DA7819F43F1B5E689B14CE0D0ABCC0EF3173/1012585.png",
             "https://render.guildwars2.com/file/9BC34679FF900F4A387672CACB7BDAF59FB64956/1012586.png",
             "https://render.guildwars2.com/file/0FF8E9ACE2E2105C0CF69696D12AADC000EF75A5/1012587.png",
             "https://render.guildwars2.com/file/B50377784BDB3749A47EB879DB43B9086B757F0C/1012588.png",
             "https://render.guildwars2.com/file/D2360AB8930CAA809136287E6DA03DA37360E1A7/1012589.png",
             "https://render.guildwars2.com/file/A309650463ECED29B2ADB89E0DC402662377BB99/1012590.png"

             );
        #endregion

        #region Mesmer Specs

        static internal Specializations Mesmer = new Specializations(


            "https://render.guildwars2.com/file/2C436DDDC3244409EEBF470A0AE3ED7CED1F99C0/1012055.png",
            "https://render.guildwars2.com/file/4B61EA5997709A5DC1E46FF50CEDF2A13C1F0C3D/1012002.png",

            "https://render.guildwars2.com/file/1762C27D3D729F0EDBD4EAF7F4DBAB7FAD6CC2F1/1012495.png",
            "https://render.guildwars2.com/file/B4500EF704977F28CB059D40424B5B031DFC10B7/1012496.png",
             "https://render.guildwars2.com/file/DBA1050B30E4FBB4CEAFDF01217E7E07D4EF6459/1012497.png",

             "https://render.guildwars2.com/file/E9CB4990C405C00D34DB07C5C5291FD5E90EF90C/1012486.png",
             "https://render.guildwars2.com/file/4337F2F9DCC4F7A6022997409400423F7A1BB946/1012487.png",
             "https://render.guildwars2.com/file/914DB240AB9CB47ADC437F9760B4D86BF838673A/1012488.png",
             "https://render.guildwars2.com/file/1F25AB72D072AE0FE9E3221A7D5D10AD7040406D/1012489.png",
             "https://render.guildwars2.com/file/B6C6AAC9506E3904F7CEEDC82629D2BEE54A7EF3/1012490.png",
             "https://render.guildwars2.com/file/D83AA1E34F35E91D577752E07E1207A5F5713D57/1012491.png",
             "https://render.guildwars2.com/file/A6A23D55F25BF223A75AB62AA5D0E9C17D3BCB3C/1012492.png",
             "https://render.guildwars2.com/file/4614953C566CB8F9B7169DA6E8C4060C29E9F65B/1012493.png",
             "https://render.guildwars2.com/file/E029766272E10A957B954B12B20FD916474D5A01/1012494.png",


            "https://render.guildwars2.com/file/DC30B4FF5377E80F21F4E912E8D548B004C95042/1012059.png",
            "https://render.guildwars2.com/file/BCC2C316C4FC2823679E0FD062C5A87E96E460CC/1012004.png",

            "https://render.guildwars2.com/file/1E329F3FA4BA08107AD9DC96F116BA1DE479BF73/103741.png",
            "https://render.guildwars2.com/file/7BA394DC345278D4912EEAE94F072A06B9C932F2/1012532.png",
            "https://render.guildwars2.com/file/090D289158520416A4402EBE9C92257E1309020D/1012533.png",

            "https://render.guildwars2.com/file/4A1C386EE156DAACE137FB07060CC507EEE1E0B4/1012522.png",
            "https://render.guildwars2.com/file/2636BEBF0E35923BC4407739D0DC7DC223932F0C/1012523.png",
            "https://render.guildwars2.com/file/FA0AE3A437419F325D682180687C5C7FF014602D/1012524.png",
            "https://render.guildwars2.com/file/D4A345BC1A72A50B7C7449B7759BAB15664064F7/1012525.png",
            "https://render.guildwars2.com/file/99A30379D5040427FD0FBC5DEDB6950376AB5B1C/1012526.png",
            "https://render.guildwars2.com/file/1503DDC5B62526D71901E3A7F891A6F4445D80C8/1012527.png",
            "https://render.guildwars2.com/file/EC7602C0FABB72AFB01379563ED7FB76079BB9CA/1012528.png",
            "https://render.guildwars2.com/file/A2B419927562110402010EEF084BF953905D54E5/1012529.png",
             "https://render.guildwars2.com/file/B07D6EA99FEC210636A00E47B260F80D060DB546/1012530.png",


            "https://render.guildwars2.com/file/B00D98B31B13416811B8484FC146C49B1E055BAC/1012061.png",
            "https://render.guildwars2.com/file/A6D57C63D9EFB3FE75C9DAF8CBE603D8F45A635F/1012005.png",

           "https://render.guildwars2.com/file/3AA5FD383BE64BEFDCD1F011E2F526297DAA4868/1012519.png",
           "https://render.guildwars2.com/file/E9BA251055B444E693144A9AF5FD1CF8266BEFA6/1012520.png",
            "https://render.guildwars2.com/file/A03500F90501130C214507C2A9B4B5CAF7C5219C/1012521.png",

             "https://render.guildwars2.com/file/2C1BCA6C6F6763E90D0226BC2FD8DFA8403E9E47/1012510.png",
             "https://render.guildwars2.com/file/F225A021EB41754E4E0C9FCB46F40F7212DA41CE/1012511.png",
             "https://render.guildwars2.com/file/20D83E25D6A9D930AA01EB0D3ABAEAD6577B0762/1012512.png",
             "https://render.guildwars2.com/file/D5969DA633174AC5F52AB700F937A524E6E95DDE/1012513.png",
             "https://render.guildwars2.com/file/EE4D54D0D53E4B57C00F179BD97ED990230736DE/1012514.png",
             "https://render.guildwars2.com/file/DBC6799E4A18BA9B9ABE280DAE35362DA9DAE00E/1012515.png",
             "https://render.guildwars2.com/file/0214C11C1C217134B2565C5201C70E9A653B2C06/1012516.png",
             "https://render.guildwars2.com/file/E625ADB94CF699763B23A7A82E255B55A44C1B16/1012517.png",
             "https://render.guildwars2.com/file/E1EFE39620B9A00D140A5C493ABB3180E2B2B511/1012518.png"

            );

        #endregion


        //Equipment Class nested with each armor slot on the character, within that each piece of armor/equipment contains an upgrade slot class. 
        internal class equipment
        {
            internal class HelmAquatic
            {

                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }


                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal int Defence { get; set; }
                internal string weightClass { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal HelmAquatic(
                    string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Backpack
            {
                internal class UpgradeComponentJewel
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }


                    internal UpgradeComponentJewel(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                    }
                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Backpack(
                    string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Helm
            {

                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string weightClass { get; set; }
                internal int Defence { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Helm(
                       string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Gloves
            {
                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string weightClass { get; set; }
                internal int Defence { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Gloves(
                     string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Shoulders
            {
                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }


                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string weightClass { get; set; }
                internal int Defence { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Shoulders(
                      string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Coat
            {
                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }


                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string weightClass { get; set; }
                internal int Defence { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Coat(
                     string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Leggings
            {
                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }



                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string weightClass { get; set; }
                internal int Defence { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Leggings(
                       string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Boots
            {

                internal class UpgradeComponentRune
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }
                    internal string Bonus4 { get; set; }
                    internal string Bonus5 { get; set; }
                    internal string Bonus6 { get; set; }

                    internal UpgradeComponentRune(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3,
                        string bonus4,
                        string bonus5,
                        string bonus6
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                        Bonus4 = bonus4;
                        Bonus5 = bonus5;
                        Bonus6 = bonus6;
                    }
                }

 
                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string weightClass { get; set; }
                internal int Defence { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Boots(
                            string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string weightclass,
                    int defence,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    weightClass = weightclass;
                    Defence = defence;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class WeaponA1
            {

                internal class UpgradeComponentSigil
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }






                    internal UpgradeComponentSigil(
                        string name,
                        string bonus1
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                    }

                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal WeaponA1(
                      string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class WeaponA2
            {
                internal class UpgradeComponentSigil
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }






                    internal UpgradeComponentSigil(
                        string name,
                        string bonus1
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                    }

                }



                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal WeaponA2(
                          string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class WeaponB1
            {

                internal class UpgradeComponentSigil
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }






                    internal UpgradeComponentSigil(
                        string name,
                        string bonus1
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                    }

                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal WeaponB1(
                       string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class WeaponB2
            {

                internal class UpgradeComponentSigil
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }






                    internal UpgradeComponentSigil(
                        string name,
                        string bonus1
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                    }

                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal WeaponB2(
                        string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Accessory1
            {

                internal class UpgradeComponentJewel
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }


                    internal UpgradeComponentJewel(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                    }
                }



                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Accessory1(
                       string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Accessory2
            {
                internal class UpgradeComponentJewel
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }


                    internal UpgradeComponentJewel(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                    }
                }



                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Accessory2(
                     string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Amulet
            {

                internal class UpgradeComponentJewel
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }


                    internal UpgradeComponentJewel(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                    }
                }


                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Amulet(
                     string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Ring1
            {
                internal class UpgradeComponentJewel
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }


                    internal UpgradeComponentJewel(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                    }
                }


                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Ring1(
                      string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Ring2
            {
                internal class UpgradeComponentJewel
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }
                    internal string Bonus2 { get; set; }
                    internal string Bonus3 { get; set; }


                    internal UpgradeComponentJewel(
                        string name,
                        string bonus1,
                        string bonus2,
                        string bonus3
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                        Bonus2 = bonus2;
                        Bonus3 = bonus3;
                    }
                }


                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal Ring2(
                    string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,

                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3
                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class Sickle
            {
                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }



                internal Sickle(
                    string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon
                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                }
            }
            internal class Axe
            {
                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }

                internal Axe(
                    string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon
                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                }
            }
            internal class Pick
            {
                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }


                internal Pick(
                    string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon
                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                }
            }
            internal class WeaponAquaticA
            {

                internal class UpgradeComponentSigil
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }






                    internal UpgradeComponentSigil(
                        string name,
                        string bonus1
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                    }

                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal WeaponAquaticA(
                       string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }
            internal class WeaponAquaticB
            {

                internal class UpgradeComponentSigil
                {
                    internal string Name { get; set; }
                    internal string Bonus1 { get; set; }






                    internal UpgradeComponentSigil(
                        string name,
                        string bonus1
                        )
                    {
                        Name = name;
                        Bonus1 = bonus1;
                    }

                }

                internal string Name { get; set; }
                internal string Description { get; set; }
                internal string Type { get; set; }
                internal int Level { get; set; }
                internal string Rarity { get; set; }
                internal string Icon { get; set; }
                internal string Att1 { get; set; }
                internal int Mod1 { get; set; }
                internal string Att2 { get; set; }
                internal int Mod2 { get; set; }
                internal string Att3 { get; set; }
                internal int Mod3 { get; set; }



                internal WeaponAquaticB(
                      string name,
                    string description,
                    string type,
                    int level,
                    string rarity,
                    string icon,
                    string att1,
                    int mod1,
                    string att2,
                    int mod2,
                    string att3,
                    int mod3

                    )
                {
                    Name = name;
                    Description = description;
                    Type = type;
                    Level = level;
                    Rarity = rarity;
                    Icon = icon;
                    Att1 = att1;
                    Mod1 = mod1;
                    Att2 = att2;
                    Mod2 = mod2;
                    Att3 = att3;
                    Mod3 = mod3;
                }
            }

            #region Necro Equipment
            static internal HelmAquatic necroHelmAq = new HelmAquatic(
                "Gavbeorn Breather",
                "",
                "HelmAquatic",
                80,
                "Masterwork",
                "https://render.guildwars2.com/file/FA1D042B0845BED8DA3CFA0FAA0837D5EB0207A6/61297.png",
                "Light",
                80,
                "Condition Damage",
                49,
                "Precision",
                35,
                "Toughness",
                35
                );

            static internal App.equipment.HelmAquatic.UpgradeComponentRune necroHelmAquaticUpgradeSlot = new App.equipment.HelmAquatic.UpgradeComponentRune(
                "Superior Rune of Vampirism",
                "+ 25 Power",
                "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
                "+50 Power",
                "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
                "+100 Power",
                "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
                );


            static internal Backpack necroBackpack = new Backpack(
                "Rabid Spineguard",
                "",
                "Back",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/03B65C435B15EB2C10E04F3454B03718AAF3AE90/61004.png",
                "Condition Damage",
                30,
                "Precision",
                21,
                "Toughness",
                21
                );
            static internal App.equipment.Backpack.UpgradeComponentJewel necroBackpackUpgradeSlot = new App.equipment.Backpack.UpgradeComponentJewel(
    "Exquisite Opal Jewel",
    "+24 Precision",
    "+15 Ferocity",
    "+15 Power"
    );

            static internal Boots necroBoots = new Boots(
                "Valkyrie Exalted Boots",
                "",
                "Boots",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/AE26D521B64460E45F69FBD7784313D4BAF070CA/61520.png",
                "Light",
                133,
                "Power",
                45,
                "CritDamage",
                32,
                "Vitality",
                32
                );

            static internal App.equipment.Boots.UpgradeComponentRune necroBootsUpgradeSlot = new App.equipment.Boots.UpgradeComponentRune(
    "Superior Rune of Vampirism",
    "+ 25 Power",
    "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
    "+50 Power",
    "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
    "+100 Power",
    "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
    );

            static internal Gloves necroGloves = new Gloves(
                "Valkyrie Exalted Gloves",
                "",
                "Gloves",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/77EC710506D20A724036E55D12054903D2F42763/61522.png",
                "Light",
                133,
                "Power",
                45,
                "CritDamage",
                32,
                "Vitality",
                32
                );

            static internal App.equipment.Gloves.UpgradeComponentRune necroGlovesUpgradeSlot = new App.equipment.Gloves.UpgradeComponentRune(
                "Superior Rune of Vampirism",
                "+ 25 Power",
                "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
                "+50 Power",
                "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
                "+100 Power",
                "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
                );


            static internal Helm necroHelm = new Helm(
                 "Valkyrie Exalted Masque",
                 "",
                 "Helm",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/0F2101315C12A3E75263224DEA3B946FFD0801E0/61523.png",
                 "Light",
                 73,
                 "Power",
                 60,
                 "CritDamage",
                 43,
                 "Vitality",
                 43
                 );

            static internal App.equipment.Helm.UpgradeComponentRune necroHelmUpgradeSlot = new App.equipment.Helm.UpgradeComponentRune(
                 "Superior Rune of Vampirism",
                 "+ 25 Power",
                 "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
                 "+50 Power",
                 "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
                 "+100 Power",
                 "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
                 );


            static internal Leggings necroLeggings = new Leggings(
                 "Valkyrie Exalted Pants",
                 "",
                 "Leggings",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/A74E3461167960693591EF5E4AE1A81C0CBD03B2/61524.png",
                 "Light",
                 194,
                 "Power",
                 90,
                 "CritDamage",
                 64,
                 "Vitality",
                 64
                 );

            static internal App.equipment.Leggings.UpgradeComponentRune necroLeggingsUpgradeSlot = new App.equipment.Leggings.UpgradeComponentRune(
    "Superior Rune of Vampirism",
    "+ 25 Power",
    "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
    "+50 Power",
    "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
    "+100 Power",
    "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
    );

            static internal Shoulders necroShoulders = new Shoulders(
                 "Valkyrie Exalted Mantle",
                 "",
                 "Shoulders",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/CB1168666B9D67CBF119DF365333327B72226E06/61525.png",
                 "Light",
                 73,
                 "Power",
                 45,
                 "CritDamage",
                 32,
                 "Vitality",
                 32
                 );

            static internal App.equipment.Shoulders.UpgradeComponentRune necroShouldersUpgradeSlot = new App.equipment.Shoulders.UpgradeComponentRune(
    "Superior Rune of Vampirism",
    "+ 25 Power",
    "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
    "+50 Power",
    "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
    "+100 Power",
    "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
    );

            static internal Coat necroCoat = new Coat(
                 "Valkyrie Exalted Coat",
                 "",
                 "Coat",
                 80,
                 "Exotic",
                "https://render.guildwars2.com/file/072F6E4D010C68014D725D9066AEE7EECB2CC1CA/61521.png",
                 "Light",
                 314,
                 "Power",
                 134,
                 "CritDamage",
                 96,
                 "Vitality",
                 96
                 );

            static internal App.equipment.Coat.UpgradeComponentRune necroCoatUpgradeSlot = new App.equipment.Coat.UpgradeComponentRune(
    "Superior Rune of Vampirism",
    "+ 25 Power",
    "15% chance when struck to cause your next attack to steal life. (Cooldown: 25s)",
    "+50 Power",
    "After using your healing skill, your next attack skill steals health. (Cooldown: 10s)",
    "+100 Power",
    "When struck below 25% health, you steal health from nearby foes. (Cooldown: 40s)"
    );


            static internal Accessory1 necroAccessory1 = new Accessory1(
                 "Opal Orichalcum Earring",
                 "",
                 "Accessory",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/5007F9AD422CA0F47619EC48DF1CE5E0D1B40276/433702.png",
                 "Precision",
                 75,
                 "Power",
                 53,
                 "CritDamage",
                 53
                 );

            static internal App.equipment.Accessory1.UpgradeComponentJewel necroAccessory1UpgradeSlot = new App.equipment.Accessory1.UpgradeComponentJewel(
    "Exquisite Opal Jewel",
    "+24 Precision",
    "+15 Ferocity",
    "+15 Power"
    );


            static internal Accessory2 necroAccessory2 = new Accessory2(
                 "Opal Orichalcum Earring",
                 "",
                 "Accessory",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/5007F9AD422CA0F47619EC48DF1CE5E0D1B40276/433702.png",
                 "Precision",
                 75,
                 "Power",
                 53,
                 "CritDamage",
                 53
                 );

            static internal App.equipment.Accessory2.UpgradeComponentJewel necroAccessory2UpgradeSlot = new App.equipment.Accessory2.UpgradeComponentJewel(
    "Exquisite Opal Jewel",
    "+24 Precision",
    "+15 Ferocity",
    "+15 Power"
    );

            static internal Ring1 necroRing1 = new Ring1(
                 "Opal Orichalcum Ring",
                 "",
                 "Ring",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/C0151CD7E203F6476DCC41292F6D17E2369269CE/455588.png",
                 "Precision",
                 90,
                 "Power",
                 64,
                 "CritDamage",
                 64
                 );

            static internal App.equipment.Ring1.UpgradeComponentJewel necroRing1UpgradeSlot = new App.equipment.Ring1.UpgradeComponentJewel(
    "Exquisite Opal Jewel",
    "+24 Precision",
    "+15 Ferocity",
    "+15 Power"
    );

            static internal Ring2 necroRing2 = new Ring2(
                 "Opal Orichalcum Ring",
                 "",
                 "Ring",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/C0151CD7E203F6476DCC41292F6D17E2369269CE/455588.png",
                 "Precision",
                 90,
                 "Power",
                 64,
                 "CritDamage",
                 64
                 );

            static internal App.equipment.Ring2.UpgradeComponentJewel necroRing2UpgradeSlot = new App.equipment.Ring2.UpgradeComponentJewel(
    "Exquisite Opal Jewel",
    "+24 Precision",
    "+15 Ferocity",
    "+15 Power"
    );

            static internal Amulet necroAmulet = new Amulet(
                 "Opal Orichalcum Amulet",
                 "",
                 "Amulet",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/02E9EFDEF9587130A25F17AC396913FBBE3C716D/455602.png",
                 "Precision",
                 120,
                 "Power",
                 85,
                 "CritDamage",
                 85
                 );

            static internal App.equipment.Amulet.UpgradeComponentJewel necroAmuletUpgradeSlot = new App.equipment.Amulet.UpgradeComponentJewel(
    "Exquisite Opal Jewel",
    "+24 Precision",
    "+15 Ferocity",
    "+15 Power"
    );

            static internal WeaponAquaticA necroWeaponAquaticA = new WeaponAquaticA(
                 "Peasant's Solution",
                 "",
                 "Trident",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/790BD144AC98471C6B2C260DDD750CB954077B0C/780589.png",
                 "Power",
                 239,
                 "Precision",
                 171,
                 "CritDamage",
                 171
                 );

            static internal App.equipment.WeaponAquaticA.UpgradeComponentSigil necroWeaponAquaticAUpgradeSlot = new App.equipment.WeaponAquaticA.UpgradeComponentSigil(
"Minor Sigil of Malice",
"+5 % condition duration"
);

            static internal WeaponAquaticB necroWeaponAquaticB = new WeaponAquaticB(
                 "Harpoon of the Dragon's Deep",
                 "",
                 "Harpoon",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/43D82F0C4D0B0B5D75AE650DC75D37F5137B13E0/648122.png",
                 "Power",
                 239,
                 "Precision",
                 171,
                 "CritDamage",
                 171
                 );

            static internal App.equipment.WeaponAquaticB.UpgradeComponentSigil necroWeaponAquaticBUpgradeSlot = new App.equipment.WeaponAquaticB.UpgradeComponentSigil(
"Major Sigil of Malice",
"+7% condition duration"
);

            static internal WeaponA1 necroWeaponA1 = new WeaponA1(
                 "Assassin's Pearl Carver",
                 "",
                 "Dagger",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/3EB97D4B966B1848CF6A2B4A1C1D736BF4C3E3B1/67756.png",
                 "Precision",
                 120,
                 "Power",
                 85,
                 "CritDamage",
                 85
                 );

            static internal App.equipment.WeaponA1.UpgradeComponentSigil necroWeaponA1UpgradeSlot = new App.equipment.WeaponA1.UpgradeComponentSigil(
"Superior Sigil of Air",
"50% Chance on Critical: Cause a Lightning Strike (Cooldown: 3 Seconds)"
    );


            static internal WeaponA2 necroWeaponA2 = new WeaponA2(
                 "Assassin's Pearl Siren",
                 "",
                 "Warhorn",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/E3B22966AB23651DFF28FBE10AF2F503FE029029/67820.png",
                 "Precision",
                 120,
                 "Power",
                 85,
                 "CritDamage",
                 85
                 );

            static internal App.equipment.WeaponA2.UpgradeComponentSigil necroWeaponA2UpgradeSlot = new App.equipment.WeaponA2.UpgradeComponentSigil(
"Superior Sigil of Fire",
"50% Chance on Critical: Trigger a Flame Blast for area of effect damage (240 radius). (Cooldown: 5 Seconds)"
);

            static internal WeaponB1 necroWeaponB1 = new WeaponB1(
                 "Assassin's Pearl Quarterstaff",
                 "",
                 "Staff",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/FAD2A5B1BC93C70E110F09595F7D50C9B12B500A/67802.png",
                 "Precision",
                 239,
                 "Power",
                 171,
                 "CritDamage",
                 171
                 );

            static internal App.equipment.WeaponB1.UpgradeComponentSigil necroWeaponB1UpgradeSlot1 = new App.equipment.WeaponB1.UpgradeComponentSigil(
"Superior Sigil of Air",
"50% Chance on Critical: Cause a Lightning Strike (Cooldown: 3 Seconds)"
);
            static internal App.equipment.WeaponB1.UpgradeComponentSigil necroWeaponB1UpgradeSlot2 = new App.equipment.WeaponB1.UpgradeComponentSigil(
"Superior Sigil of Fire",
"50% Chance on Critical: Trigger a Flame Blast for area of effect damage (240 radius). (Cooldown: 5 Seconds)"
);


            static internal Sickle necroSickle = new Sickle(
                 "Master Harvesting Sickle",
                 "More efficient at gathering resources and uncovering rare components.",
                 "Foraging",
                 60,
                 "Masterwork",
                 "https://render.guildwars2.com/file/EFBB674F9965A2304CBAC39376230396D73EBCFD/534199.png"
                 );

            static internal Axe necroAxe = new Axe(
                 "Orichalcum Logging Axe",
                 "Used to chop down all saplings.",
                 "Logging",
                 60,
                 "Fine",
                 "https://render.guildwars2.com/file/201CC6E60448CB4BA8AD919C74904EE1F9AEC54F/66597.png"
                 );

            static internal Pick necroPick = new Pick(
                 "Orichalcum Mining Pick",
                 "Used to mine all metals.",
                 "Mining",
                 60,
                 "Fine",
                 "https://render.guildwars2.com/file/DB422F44CD5FC897E1255D601736CD4807D2DF22/526358.png"
                 );

            #endregion

            #region Memser Equipment
            static internal HelmAquatic mesmerHelmAq = new HelmAquatic(
                "Cloth Aquabreather",
                "Quaggan found this in a shipwreck underwater. Quaggan doesn't need it. OoOOoo! It's very nice, though! —Leemoola",
                "HelmAquatic",
                60,
                "Masterwork",
                "https://render.guildwars2.com/file/FA1D042B0845BED8DA3CFA0FAA0837D5EB0207A6/61297.png",
                "Light",
                40,
                "Condition Damage",
                49,
                "Precision",
                35,
                "Toughness",
                35
                );

            static internal Backpack mesmerBackpack = new Backpack(
                "Lucky Great Ram Lantern",
                "",
                "Back",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/2EF6A574CDA4670CF20D47460294754F0B21DD43/947642.png",
                "Condition Damage",
                30,
                "Toughness",
                21,
                "Vitality",
                21
                );

            static internal Coat mesmerCoat = new Coat(
                "Dire Exalted Coat",
                "",
                "Coat",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/072F6E4D010C68014D725D9066AEE7EECB2CC1CA/61521.png",
                "Light",
                314,
                "ConditionDamage",
                134,
                "Toughness",
                96,
                "Vitality",
                96
                );

            static internal Boots mesmerBoots = new Boots(
                "Dire Exalted Boots",
                "",
                "Boots",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/AE26D521B64460E45F69FBD7784313D4BAF070CA/61520.png",
                "Light",
                133,
                "ConditionDamage",
                45,
                "Toughness",
                32,
                "Vitality",
                32
                );

            static internal Gloves mesmerGloves = new Gloves(
                "Dire Exalted Gloves",
                "",
                "Gloves",
                80,
                "Exotic",
                "https://render.guildwars2.com/file/77EC710506D20A724036E55D12054903D2F42763/61522.png",
                "Light",
                133,
                "ConditionDamage",
                45,
                "Toughness",
                32,
                "Vitality",
                32
                );

            static internal Helm mesmerHelm = new Helm(
                 "Dire Exalted Masque",
                 "",
                 "Helm",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/0F2101315C12A3E75263224DEA3B946FFD0801E0/61523.png",
                 "Light",
                 73,
                 "ConditionDamage",
                 60,
                 "Toiughness",
                 43,
                 "Vitality",
                 43
                 );

            static internal Leggings mesmerLeggings = new Leggings(
                 "Dire Exalted Pants",
                 "",
                 "Leggings",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/A74E3461167960693591EF5E4AE1A81C0CBD03B2/61524.png",
                 "Light",
                 194,
                 "ConditionDamage",
                 90,
                 "Toughness",
                 64,
                 "Vitality",
                 64
                 );

            static internal Shoulders mesmerShoulders = new Shoulders(
                 "Dire Exalted Mantle",
                 "",
                 "Shoulders",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/CB1168666B9D67CBF119DF365333327B72226E06/61525.png",
                 "Light",
                 73,
                 "ConditionDamage",
                 45,
                 "Toughness",
                 32,
                 "Vitality",
                 32
                 );

            static internal Accessory1 mesmerAccessory1 = new Accessory1(
                 "Fang of Tequatl",
                 "",
                 "Accessory",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/090C47B6BFC5F70B5BA83D3B0F4630A51F07ED34/220642.png",
                 "ConditionDamage",
                 75,
                 "Toughness",
                 53,
                 "Vitality",
                 53
                 );

            static internal Accessory2 mesmerAccessory2 = new Accessory2(
                 "Fang of Tequatl",
                 "",
                 "Accessory",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/090C47B6BFC5F70B5BA83D3B0F4630A51F07ED34/220642.png",
                 "ConditionDamage",
                 75,
                 "Toughness",
                 53,
                 "Vitality",
                 53
                 );

            static internal Ring1 mesmerRing1 = new Ring1(
                 "Traveler's Ring",
                 "",
                 "Ring",
                 80,
                 "Exotic",
                "https://render.guildwars2.com/file/0A402568104F5BE5BC644665653302005F6266CF/66800.png",
                 "ConditionDamage",
                 90,
                 "Toughness",
                 64,
                 "Vitality",
                 64
                 );

            static internal Ring2 mesmerRing2 = new Ring2(
                 "Traveler's Ring",
                 "",
                 "Ring",
                 80,
                 "Exotic",
                "https://render.guildwars2.com/file/0A402568104F5BE5BC644665653302005F6266CF/66800.png",
                 "ConditionDamage",
                 90,
                 "Toughness",
                 64,
                 "Vitality",
                 64
                 );

            static internal Amulet mesmerAmulet = new Amulet(
                 "Stargazer Pendant",
                 "The jotun have many secrets. This is but one.",
                 "Amulet",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/35A76FF749801A31BDE750017C2DF371DB200D4A/222374.png",
                 "ConditionDamage",
                 120,
                 "Toughness",
                 85,
                 "Vitality",
                 85
                 );

            static internal WeaponAquaticA mesmerWeaponAquaticA = new WeaponAquaticA(
                 "Dragonspine",
                 "",
                 "Trident",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/0A4416F8145D073822FB0AA8E6DB1EE09110DDDE/780590.png",
                 "ConditionDamage",
                 239,
                 "Power",
                 171,
                 "Vitality",
                 171
                 );

            static internal WeaponAquaticB mesmerWeaponAquaticB = new WeaponAquaticB(
                 "Rampager's Krait Trident",
                 "",
                 "Harpoon",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/E76304981F7A94C09D06BEC252740B97C49219B0/574970.png",
                 "Power",
                 239,
                 "Precision",
                 171,
                 "ConditionDamage",
                 171
                 );

            static internal WeaponA1 mesmerWeaponA1 = new WeaponA1(
                 "Dire Pearl Rod",
                 "",
                 "Scepter",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/09C51476177A48D86C44965D3034F4A8EA073A48/67794.png",
                 "ConditionDamage",
                 120,
                 "Toughness",
                 85,
                 "Vitality",
                 85
                 );

            static internal WeaponA2 mesmerWeaponA2 = new WeaponA2(
                 "Berserker's Bandit Focus",
                 "",
                 "Focus",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/920324A8CC464AC205D62208E75C70CF7FE6A492/63483.png",
                 "Power",
                 120,
                 "Precision",
                 85,
                 "CritDamage",
                 85
                 );

            static internal WeaponB1 mesmerWeaponB1 = new WeaponB1(
                 "Berserker's Pearl Sabre",
                 "",
                 "Sword",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/9BBF12452129E90C7FD30C0EF60A630A507ECDEF/67808.png",
                 "Power",
                 239,
                 "Precision",
                 171,
                 "CritDamage",
                 171
                 );

            static internal WeaponB2 mesmerWeaponB2 = new WeaponB2(
                 "Berserker's Bandit Revolver",
                 "",
                 "Pistol",
                 80,
                 "Exotic",
                 "https://render.guildwars2.com/file/3B0702BD5B1956056D037604FB0707140B2C21B9/66738.png",
                 "Power",
                 239,
                 "Precision",
                 171,
                 "CritDamage",
                 171
                );

            static internal Sickle mesmerSickle = new Sickle(
                 "Master Harvesting Sickle",
                 "More efficient at gathering resources and uncovering rare components.",
                 "Foraging",
                 35,
                 "Masterwork",
                 "https://render.guildwars2.com/file/EFBB674F9965A2304CBAC39376230396D73EBCFD/534199.png"
                 );

            static internal Axe mesmerAxe = new Axe(
                 "Master Logging Axe",
                 "More efficient at gathering resources and uncovering rare components.",
                 "Logging",
                 15,
                 "Masterwork",
                 "https://render.guildwars2.com/file/201CC6E60448CB4BA8AD919C74904EE1F9AEC54F/66597.png"
                 );

            static internal Pick mesmerPick = new Pick(
                 "Master Mining Pick",
                 "More efficient at gathering resources and uncovering rare components.",
                 "Mining",
                 60,
                 "Fine",
                 "https://render.guildwars2.com/file/DB422F44CD5FC897E1255D601736CD4807D2DF22/526358.png"
                 );



            static internal App.equipment.HelmAquatic.UpgradeComponentRune mesmerHelmAquaticUpgradeSlot = new App.equipment.HelmAquatic.UpgradeComponentRune(
                "Minor Rune of Rata Sum",
                "+10 Precision",
                "+4% Poison Duration",
                "",
				"",
				"",
				""
				);

			static internal App.equipment.Backpack.UpgradeComponentJewel mesmerBackpackUpgradeSlot = new App.equipment.Backpack.UpgradeComponentJewel(
    "Exquisite Chrysocola Jewel",
    "+25 Condition Damage",
    "+15 Power",
    "15 Vitality"            
	);


			static internal App.equipment.Boots.UpgradeComponentRune mesmerBootsUpgradeSlot = new App.equipment.Boots.UpgradeComponentRune(
    "Superior Rune of Perplexity",
 "+25 Condition Damage",
"+10% Confusion Duration",
"+50 Condition Damage",
"25% chance when struck to inflict 3 stacks of confusion for 5 seconds. (Cooldown: 25 Seconds)",
"+100 Condition Damage",
"+20% confusion duration; when you interrupt a foe, cause 5 stacks of confusion for 8 seconds. (Cooldown: 15s)"
    );

			static internal App.equipment.Gloves.UpgradeComponentRune mesmerGlovesUpgradeSlot = new App.equipment.Gloves.UpgradeComponentRune(
    "Superior Rune of Perplexity",
 "+25 Condition Damage",
"+10% Confusion Duration",
"+50 Condition Damage",
"25% chance when struck to inflict 3 stacks of confusion for 5 seconds. (Cooldown: 25 Seconds)",
"+100 Condition Damage",
"+20% confusion duration; when you interrupt a foe, cause 5 stacks of confusion for 8 seconds. (Cooldown: 15s)"
    );


            static internal App.equipment.Helm.UpgradeComponentRune mesmerHelmUpgradeSlot = new App.equipment.Helm.UpgradeComponentRune(
    "Superior Rune of Perplexity",
 "+25 Condition Damage",
"+10% Confusion Duration",
"+50 Condition Damage",
"25% chance when struck to inflict 3 stacks of confusion for 5 seconds. (Cooldown: 25 Seconds)",
"+100 Condition Damage",
"+20% confusion duration; when you interrupt a foe, cause 5 stacks of confusion for 8 seconds. (Cooldown: 15s)"
    );


            static internal App.equipment.Leggings.UpgradeComponentRune mesmerLeggingsUpgradeSlot = new App.equipment.Leggings.UpgradeComponentRune(
    "Superior Rune of Perplexity",
 "+25 Condition Damage",
"+10% Confusion Duration",
"+50 Condition Damage",
"25% chance when struck to inflict 3 stacks of confusion for 5 seconds. (Cooldown: 25 Seconds)",
"+100 Condition Damage",
"+20% confusion duration; when you interrupt a foe, cause 5 stacks of confusion for 8 seconds. (Cooldown: 15s)"
    );

            static internal App.equipment.Shoulders.UpgradeComponentRune mesmerShouldersUpgradeSlot = new App.equipment.Shoulders.UpgradeComponentRune(
    "Superior Rune of Perplexity",
 "+25 Condition Damage",
"+10% Confusion Duration",
"+50 Condition Damage",
"25% chance when struck to inflict 3 stacks of confusion for 5 seconds. (Cooldown: 25 Seconds)",
"+100 Condition Damage",
"+20% confusion duration; when you interrupt a foe, cause 5 stacks of confusion for 8 seconds. (Cooldown: 15s)"
    );


            static internal App.equipment.Coat.UpgradeComponentRune mesmerCoatUpgradeSlot = new App.equipment.Coat.UpgradeComponentRune(
    "Superior Rune of Perplexity",
 "+25 Condition Damage",
"+10% Confusion Duration",
"+50 Condition Damage",
"25% chance when struck to inflict 3 stacks of confusion for 5 seconds. (Cooldown: 25 Seconds)",
"+100 Condition Damage",
"+20% confusion duration; when you interrupt a foe, cause 5 stacks of confusion for 8 seconds. (Cooldown: 15s)"
    );

            static internal App.equipment.Accessory1.UpgradeComponentJewel mesmerAccessory1UpgradeSlot = new App.equipment.Accessory1.UpgradeComponentJewel(
    "Exquisite Chrysocola Jewel",
    "+25 Condition Damage",
    "+15 Power",
    "15 Vitality"
    );

            static internal App.equipment.Accessory2.UpgradeComponentJewel mesmerAccessory2UpgradeSlot = new App.equipment.Accessory2.UpgradeComponentJewel(
    "Exquisite Chrysocola Jewel",
    "+25 Condition Damage",
    "+15 Power",
    "15 Vitality"
    );

            static internal App.equipment.Ring1.UpgradeComponentJewel mesmerRing1UpgradeSlot = new App.equipment.Ring1.UpgradeComponentJewel(	
    "Exquisite Chrysocola Jewel",
    "+25 Condition Damage",
    "+15 Power",
    "15 Vitality"
    );

            static internal App.equipment.Ring2.UpgradeComponentJewel mesmerRing2UpgradeSlot = new App.equipment.Ring2.UpgradeComponentJewel(
    "Exquisite Chrysocola Jewel",
    "+25 Condition Damage",
    "+15 Power",
    "15 Vitality"
    );

            static internal App.equipment.Amulet.UpgradeComponentJewel mesmerAmuletUpgradeSlot = new App.equipment.Amulet.UpgradeComponentJewel(
    "Exquisite Chrysocola Jewel",
    "+25 Condition Damage",
    "+15 Power",
    "15 Vitality"
    );

            static internal App.equipment.WeaponAquaticA.UpgradeComponentSigil mesmerWeaponAquaticAUpgradeSlot = new App.equipment.WeaponAquaticA.UpgradeComponentSigil(
"Superior Sigil of Venom",
"Increase Inflicted Poison Duration: 20%"
);

			static internal App.equipment.WeaponAquaticB.UpgradeComponentSigil mesmerWeaponAquaticBUpgradeSlot = new App.equipment.WeaponAquaticB.UpgradeComponentSigil(
"Superior Sigil of Benevolence",
"Gain a charge that grants 0.5% outgoing healing effectiveness toward other allies each time you kill a foe, five if you kill an enemy player. (Max 25 stacks; ends on down.) (Only one attribute-stacking sigil can be active at a time.)"

);

            static internal App.equipment.WeaponA1.UpgradeComponentSigil mesmerWeaponA1UpgradeSlot = new App.equipment.WeaponA1.UpgradeComponentSigil(
"Superior Sigil of Corruption",
"Gain a charge of +10 condition damage each time you kill a foe, five if you kill an enemy player. (Max 25 stacks; ends on down.) (Only one attribute-stacking sigil can be active at a time.)"
);

			static internal App.equipment.WeaponA2.UpgradeComponentSigil mesmerWeaponA2UpgradeSlot = new App.equipment.WeaponA2.UpgradeComponentSigil(
"Superior Sigil of Strength",
"60% Chance on Critical: Gain Might (10 Seconds) (Cooldown: 1 Second)"
);


			static internal App.equipment.WeaponB1.UpgradeComponentSigil mesmerWeaponB1UpgradeSlot1 = new App.equipment.WeaponB1.UpgradeComponentSigil(
                "Superior Sigil of Corruption",
                "Gain a charge of +10 condition damage each time you kill a foe, five if you kill an enemy player. (Max 25 stacks; ends on down.) (Only one attribute-stacking sigil can be active at a time.)"
);
            static internal App.equipment.WeaponB1.UpgradeComponentSigil mesmerWeaponB2UpgradeSlot2 = new App.equipment.WeaponB1.UpgradeComponentSigil(
"Superior Sigil of Purity",
"60% Chance on Hit: Remove a Condition (Cooldown: 10 Seconds)"
);





            #endregion


        }


        //Character class which contains the basic information: Name, Class, Level, Guild, etc... 
        //Also contains the attributes tied to the character - usually these stats would be of a baseline stat, then the attributes would change based on the gear, weapons, and character build.
        internal class Character
        {

            #region basic Information

            internal int Id { get; set; }
            internal string Name { get; set; }
            internal int Level { get; set; }
            internal string Guild { get; set; }
            internal string characterClass { get; set; }
            internal string professionBackground { get; set; }

            internal int traitLineOne { get; set; }
            internal int traitLineTwo { get; set; }
            internal int traitLineThree { get; set; }


            #endregion

            #region Attributes

            internal int powerAtt { get; set; }
            internal int toughnessAtt { get; set; }
            internal int vitalityAtt { get; set; }
            internal int precisionAtt { get; set; }
            internal int ferocityAtt { get; set; }
            internal int conditionDamageAtt { get; set; }
            internal int expertiseAtt { get; set; }
            internal int concentrationAtt { get; set; }
            internal int agonyResistenceAtt { get; set; }
            internal double professionAttribute { get; set; }
            internal int armorAtt { get; set; }
            internal int healthAtt { get; set; }
            internal double criticalChanceAtt { get; set; }
            internal double criticalDamageAtt { get; set; }
            internal int healingAtt { get; set; }
            internal double conditionDurationAtt { get; set; }
            internal double boonDurationAtt { get; set; }
            internal double magicFindAtt { get; set; }

            #endregion

            internal Character(
                int id,
                string name,
                int level,
                string guild,
                string characterclass,
                string professionbackground,
                int traitlineone,
                int traitlinetwo,
                int traitlinethree,

                int poweratt,
                int toughnessatt,
                int vitalityatt,
                int precisionatt,
                int ferocityatt,
                int conditiondamageatt,
                int expertiseatt,
                int concentrationatt,
                int agonyresistenceatt,
                double professionattribute,
                int armoratt,
                int healthatt,
                double criticalchanceatt,
                double criticaldamageatt,
                int healingatt,
                double conditiondurationatt,
                double boondurationatt,
                double magicfindatt

                )
            {
                Id = id;
                Name = name;
                Level = level;
                Guild = guild;
                characterClass = characterclass;
                professionBackground = professionbackground;
                traitLineOne = traitlineone;
                traitLineTwo = traitlinetwo;
                traitLineThree = traitlinethree;


                powerAtt = poweratt;
                toughnessAtt = toughnessatt;
                vitalityAtt = vitalityatt;
                precisionAtt = precisionatt;
                ferocityAtt = ferocityatt;
                conditionDamageAtt = conditiondamageatt;
                expertiseAtt = expertiseatt;
                concentrationAtt = concentrationatt;
                agonyResistenceAtt = agonyresistenceatt;
                professionAttribute = professionattribute;
                armorAtt = armoratt;
                healthAtt = healthatt;
                criticalChanceAtt = criticalchanceatt;
                criticalDamageAtt = criticaldamageatt;
                healingAtt = healingatt;
                conditionDurationAtt = conditiondurationatt;
                boonDurationAtt = boondurationatt;
                magicFindAtt = magicfindatt;

            }
        }

        #region Character Necro
        static internal Character person1 = new Character(
            0,
            "Ardarkar Valkyrie",
            80,
            "Butthole Surfers [BHS]",
            "Necromancer",
            "https://wiki.guildwars2.com/images/1/14/Necromancer_03_concept_art.jpg",
            53,
            19,
            50,
            2158,
            1035,
            1299,
            1850,
            863,
            50,
            0,
            0,
            0,
            15,
            1955,
            22000,
            44.47,
            207.5,
            150,
            0.0,
            0.0,
            105


            );

        #endregion

        #region Character Mesmer
        static internal Character person2 = new Character(
            1,
            "Doctor Mccoy",
            80,
            "Xx Running Amok [Amok]",
            "Mesmer",
            "https://wiki.guildwars2.com/images/8/82/Mesmer_02_concept_art.jpg",
            10,
            23,
            24,
            1210,
            1724,
            1814,
            1085,
            85,
            1344,
            0,
            0,
            0,
            18,
            2644,
            24062,
            8.4,
            155.6,
            0,
            0.0,
            0.0,
            105

            );

        #endregion


        public App()
        {
            Microsoft.ApplicationInsights.WindowsAppInitializer.InitializeAsync(
                Microsoft.ApplicationInsights.WindowsCollectors.Metadata |
                Microsoft.ApplicationInsights.WindowsCollectors.Session);
            this.InitializeComponent();



            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = false;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }
            // Ensure the current window is active
            Window.Current.Activate();
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

    }
}
