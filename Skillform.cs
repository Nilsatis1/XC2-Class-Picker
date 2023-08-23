using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XC2_Class_Picker
{
    public partial class SKPform : Form
    {
        public SKPform(string classTxt)
        {
            InitializeComponent();

            lblXcom.SelectionAlignment = HorizontalAlignment.Left;
            lblEquipment.SelectionAlignment = HorizontalAlignment.Left;
            lblSkills.SelectionAlignment = HorizontalAlignment.Left;
            

            if (classTxt == "Shooty Ranger")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.Walk_Fire;
                lbl1.Text = "Walk Fire";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.LockedOn;
                lbl2.Text = "Locked On";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.CenterMass;
                lbl3.Text = "Center Mass";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.Executioner;
                lbl4.Text = "Executioner";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.implacable;
                lbl5.Text = "Implacable";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.rapidfire;
                lbl6.Text = "Rapid Fire";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.Rupture;
                lbl7.Text = "Rupture";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.Maim;
                xcom1.Visible = true;
                xcomlbl1.Text = "Maim";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.holotarget;
                xcom2.Visible = true;
                xcomlbl2.Text = "Holo target";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.LockedOn;
                xcom3.Visible = true;
                xcomlbl3.Text = "Locked On";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.ScrapMetal;
                xcom4.Visible = true;
                xcomlbl4.Text = "scrap Metal";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.untouchable;
                xcom5.Visible = true;
                xcomlbl5.Text = "Untouchable";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.runandgun;
                xcom6.Visible = true;
                xcomlbl6.Text = "Run & Gun";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.lethal;
                xcom7.Visible = true;
                xcomlbl7.Text = "lethal";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                xcom8.Image = Properties.Resources.Stiletto;
                xcom8.Visible = true;
                xcomlbl8.Text = "Stiletto";
                xcomlbl8.Visible = true;
                xcomlbl8.SelectionAlignment = HorizontalAlignment.Center;

                xcom9.Image = Properties.Resources.shredder;
                xcom9.Visible = true;
                xcomlbl9.Text = "Shredder";
                xcomlbl9.Visible = true;
                xcomlbl9.SelectionAlignment = HorizontalAlignment.Center;

                xcom10.Image = Properties.Resources.disablingshot;
                xcom10.Visible = true;
                xcomlbl10.Text = "Disabling";
                xcomlbl10.Visible = true;
                xcomlbl10.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.Perception;
                pcsImage.Visible = true;
                lblPcs.Text = "Perception";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "NanoScale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Ap;
                mscImg1.Visible = true;
                lblMisc1.Text = "Armor/p";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;
               

                mscImg2.Image = Properties.Resources.Dragon_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Dragon";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;
                
                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.magazine;
                Weap2.Visible = true;
                lblWeap2.Text = "ExtMagazine";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;
                
                Weap3.Image = Properties.Resources.autoloader;
                Weap3.Visible = true;
                lblWeap3.Text = "Auto Loader";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;

                Weap4.Image = Properties.Resources.Suppressor;
                Weap4.Visible = true;
                lblWeap4.Text = "Suppressor";
                lblWeap4.Visible = true;
                lblWeap4.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Overwatch Ranger")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.evervigilant;
                lbl1.Text = "Ever Vigilant";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.LockedOn;
                lbl2.Text = "Locked On";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.coolpressure;
                lbl3.Text = "Cool Pressure";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.Fortify;
                lbl4.Text = "Fortify";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.GrazingFire;
                lbl5.Text = "Grazing Fire";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.RapidReaction;
                lbl6.Text = "Rapid Reaction";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.killzone;
                lbl7.Text = "Kill Zone";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.Maim;
                xcom1.Visible = true;
                xcomlbl1.Text = "Maim";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.holotarget;
                xcom2.Visible = true;
                xcomlbl2.Text = "Holo target";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Predetor1;
                xcom3.Visible = true;
                xcomlbl3.Text = "Predator";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.ScrapMetal;
                xcom4.Visible = true;
                xcomlbl4.Text = "scrap Metal";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.untouchable;
                xcom5.Visible = true;
                xcomlbl5.Text = "Untouchable";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.runandgun;
                xcom6.Visible = true;
                xcomlbl6.Text = "Run & Gun";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.lethal;
                xcom7.Visible = true;
                xcomlbl7.Text = "lethal";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                xcom8.Image = Properties.Resources.Stiletto;
                xcom8.Visible = true;
                xcomlbl8.Text = "Stiletto";
                xcomlbl8.Visible = true;
                xcomlbl8.SelectionAlignment = HorizontalAlignment.Center;

                xcom9.Image = Properties.Resources.shredder;
                xcom9.Visible = true;
                xcomlbl9.Text = "Shredder";
                xcomlbl9.Visible = true;
                xcomlbl9.SelectionAlignment = HorizontalAlignment.Center;

                xcom10.Image = Properties.Resources.disablingshot;
                xcom10.Visible = true;
                xcomlbl10.Text = "Disabling";
                xcomlbl10.Visible = true;
                xcomlbl10.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.Perception;
                pcsImage.Visible = true;
                lblPcs.Text = "Perception";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "NanoScale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Shredder_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Shredder";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Dragon_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Dragon";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.laser_site;
                Weap1.Visible = true;
                lblWeap1.Text = "Laser Sight";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.hair_trigger;
                Weap2.Visible = true;
                lblWeap2.Text = "Hair Trigger";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.magazine;
                Weap3.Visible = true;
                lblWeap3.Text = "ExtMagazine";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;

                Weap4.Image = Properties.Resources.Suppressor;
                Weap4.Visible = true;
                lblWeap4.Text = "Suppressor";
                lblWeap4.Visible = true;
                lblWeap4.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Flamer Technical")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.FireintheHole;
                lbl1.Text = "FITH";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.NapalmX;
                lbl2.Text = "NapalmX";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.burnout;
                lbl3.Text = "Burnout";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.Phosphorus;
                lbl4.Text = "Phosphorus";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.Incinerator;
                lbl5.Text = "Incinerator";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.QuickBurn;
                lbl6.Text = "Quick Burn";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.Firestorm;
                lbl7.Text = "FireStorm";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.deepCover;
                xcom1.Visible = true;
                xcomlbl1.Text = "Deep Cover";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.holotarget;
                xcom2.Visible = true;
                xcomlbl2.Text = "Holo target";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.lightningreflexes;
                xcom3.Visible = true;
                xcomlbl3.Text = "L_Reflexes";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.LoneWolf;
                xcom4.Visible = true;
                xcomlbl4.Text = "Lone Wolf";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.Dedication;
                xcom5.Visible = true;
                xcomlbl5.Text = "Dedication";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.runandgun;
                xcom6.Visible = true;
                xcomlbl6.Text = "Run & Gun";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.mobility;
                pcsImage.Visible = true;
                lblPcs.Text = "Speed";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.hazmat;
                vestImage.Visible = true;
                lblVest.Text = "Hazmat Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;
                
                weaponImg.Image = Properties.Resources.SMG;
                weaponImg.Visible = true;
                lblWeapon.Text = "SMG";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Redscreen_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Hacking";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Shredder_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Shredding";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Auto Loader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }

            else if (classTxt == "Rocket Technical")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.FireintheHole;
                lbl1.Text = "FITH";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.bigbooms;
                lbl2.Text = "Biggest Booms";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.shredder;
                lbl3.Text = "Shredder";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.Tandem;
                lbl4.Text = "Tandem WH";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.Javelin;
                lbl5.Text = "Javelin";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.salvo;
                lbl6.Text = "Salvo";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.Bunker_buster;
                lbl7.Text = "Bunker Buster";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.deepCover;
                xcom1.Visible = true;
                xcomlbl1.Text = "Deep Cover";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.aimXcom;
                xcom2.Visible = true;
                xcomlbl2.Text = "Aim";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.BringEmOn;
                xcom3.Visible = true;
                xcomlbl3.Text = "Bring It";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.DamnGoodGround;
                xcom4.Visible = true;
                xcomlbl4.Text = "DGG";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.holotarget;
                xcom5.Visible = true;
                xcomlbl5.Text = "Holo Target";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.Rupture;
                xcom6.Visible = true;
                xcomlbl6.Text = "Rupture";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.LightEmUp;
                xcom7.Visible = true;
                xcomlbl7.Text = "LightEMUp";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                xcom8.Image = Properties.Resources.holotarget;
                xcom8.Visible = true;
                xcomlbl8.Text = "Holo Target";
                xcomlbl8.Visible = true;
                xcomlbl8.SelectionAlignment = HorizontalAlignment.Center;

                xcom9.Image = Properties.Resources.Rupture;
                xcom9.Visible = true;
                xcomlbl9.Text = "Rupture";
                xcomlbl9.Visible = true;
                xcomlbl9.SelectionAlignment = HorizontalAlignment.Center;

                xcom10.Image = Properties.Resources.HitandRun;
                xcom10.Visible = true;
                xcomlbl10.Text = "Hit & Run";
                xcomlbl10.Visible = true;
                xcomlbl10.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.defense;
                pcsImage.Visible = true;
                lblPcs.Text = "Defence";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "Nanoscale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.EXO;
                armorImg.Visible = true;
                lblArmor.Text = "EXO Suit";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Shredder_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Shredder";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;
                msc1lbl.Visible = true;

                mscImg2.Image = Properties.Resources.Redscreen_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Hacking";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.laser_site;
                Weap1.Visible = true;
                lblWeap1.Text = "Laser Sight";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Auto Loader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;

                Weap4.Image = Properties.Resources.hair_trigger;
                Weap4.Visible = true;
                lblWeap4.Text = "Hair Trigger";
                lblWeap4.Visible = true;
                lblWeap4.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Supression Gunner")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.GrazingFire;
                lbl1.Text = "Grazing Fire";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.Lockdown;
                lbl2.Text = "Lockdown";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.Mayhem;
                lbl3.Text = "Mayhem";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.IronCurtain;
                lbl4.Text = "Iron Curtain";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.DangerZone;
                lbl5.Text = "Danger Zone";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.rapidfire;
                lbl6.Text = "Rapid Fire";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.TraverseFire;
                lbl7.Text = "Traverse Fire";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.LowProfile;
                xcom1.Visible = true;
                xcomlbl1.Text = "Low Profile";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.LockNLoad;
                xcom2.Visible = true;
                xcomlbl2.Text = "LockNload";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.BringEmOn;
                xcom3.Visible = true;
                xcomlbl3.Text = "Bring It";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.WillToSurvive;
                xcom3.Visible = true;
                xcomlbl3.Text = "WTS";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.aim;
                pcsImage.Visible = true;
                lblPcs.Text = "Perception";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "Nanoscale Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.cannon;
                weaponImg.Visible = true;
                lblWeapon.Text = "Cannon";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Dragon_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Dragon";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Shredder_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Shredding";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.magazine;
                Weap2.Visible = true;
                lblWeap2.Text = "Magazine";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.hair_trigger;
                Weap3.Visible = true;
                lblWeap3.Text = "Hair Trigger";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Shooty Gunner")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.CenterMass;
                lbl1.Text = "Center Mass";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.formidable;
                lbl2.Text = "Formidable";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.shredder;
                lbl3.Text = "Shredder";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.chainshot;
                lbl4.Text = "Chainshot";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.CyclicFire;
                lbl5.Text = "Cyclical Fire";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.Rupture;
                lbl6.Text = "Rupture";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.saturationfire;
                lbl7.Text = "Saturation Fire";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.WillToSurvive;
                xcom1.Visible = true;
                xcomlbl1.Text = "Will TS";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.shadowstrike;
                xcom2.Visible = true;
                xcomlbl2.Text = "Shadow Strike";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.BringEmOn;
                xcom3.Visible = true;
                xcomlbl3.Text = "Bring It";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.aim;
                pcsImage.Visible = true;
                lblPcs.Text = "Perception";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "Nanoscale Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.cannon;
                weaponImg.Visible = true;
                lblWeapon.Text = "Cannon";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Dragon_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Dragon";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Shredder_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Shredding";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;
                
                //Weapon Mods
                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.hair_trigger;
                Weap2.Visible = true;
                lblWeap2.Text = "Hair Trigger";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.magazine;
                Weap3.Visible = true;
                lblWeap3.Text = "Magazine";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "DFA Sniper")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.deathfromabove;
                lbl1.Text = "DFA";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.CenterMass;
                lbl2.Text = "Center Mass";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.PrecisionShot;
                lbl3.Text = "Precision Shot";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.LowProfile;
                lbl4.Text = "Low Profile";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.deadeye;
                lbl5.Text = "Dead Eye";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.disablingshot;
                lbl6.Text = "Disabling";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.DoubleTap;
                lbl7.Text = "Double Tap";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.deepCover;
                xcom1.Visible = true;
                xcomlbl1.Text = "Deep Cover";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.aimXcom;
                xcom2.Visible = true;
                xcomlbl2.Text = "Aim";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Predetor1;
                xcom3.Visible = true;
                xcomlbl3.Text = "Predator";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.lethal;
                xcom4.Visible = true;
                xcomlbl4.Text = "Lethal";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.steadyhands;
                xcom5.Visible = true;
                xcomlbl5.Text = "Steady Hands";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.ApexPredator;
                xcom6.Visible = true;
                xcomlbl6.Text = "Apex Predator";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.Reposition;
                xcom7.Visible = true;
                xcomlbl7.Text = "Reposition";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.runandgun;
                xcom7.Visible = true;
                xcomlbl7.Text = "Run & Gun";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.depthperception;
                pcsImage.Visible = true;
                lblPcs.Text = "D/Perception";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "NanoScale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Sniper_Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Sniper Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Talon_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Talon";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Dragon_Rounds;
                mscImg2.Visible = true;
                lblMisc2.Text = "Dragon";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Auto Loader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.stock;
                Weap3.Visible = true;
                lblWeap3.Text = "Stock";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Holobot Sniper")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.RapidTargeting;
                lbl1.Text = "Rapid Targeting";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.phantom;
                lbl2.Text = "Phantom";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.HidefHolo;
                lbl3.Text = "HidefHolo";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.IndependentTracking;
                lbl4.Text = "I/Tracking";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.VitalPointTargeting;
                lbl5.Text = "VPT";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.MultiTargeting;
                lbl6.Text = "Multi Targeting";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.AMF;
                lbl7.Text = "AMF";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.deepCover;
                xcom1.Visible = true;
                xcomlbl1.Text = "Deep Cover";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.aimXcom;
                xcom2.Visible = true;
                xcomlbl2.Text = "Aim";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Predetor1;
                xcom3.Visible = true;
                xcomlbl3.Text = "Predator";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.lethal;
                xcom4.Visible = true;
                xcomlbl4.Text = "Lethal";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.steadyhands;
                xcom5.Visible = true;
                xcomlbl5.Text = "Steady Hands";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.ApexPredator;
                xcom6.Visible = true;
                xcomlbl6.Text = "Apex Predator";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.Reposition;
                xcom7.Visible = true;
                xcomlbl7.Text = "Reposition";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center; 
                
                //Equipment
                pcsImage.Image = Properties.Resources.aim;
                pcsImage.Visible = true;
                lblPcs.Text = "Perception";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "Nanoscale Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;
                
                armorImg.Image = Properties.Resources.Spider_Suit;
                armorImg.Visible = true;
                lblArmor.Text = "Spider Suit";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;
                
                weaponImg.Image = Properties.Resources.Sniper_Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Sniper";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Auto Loader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.stock;
                Weap3.Visible = true;
                lblWeap3.Text = "Stock";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Blade Shinobi")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.Blademaster;
                lbl1.Text = "Blademaster";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.Combatives;
                lbl2.Text = "Combatives";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.Cutthroat;
                lbl3.Text = "Cutthroat";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.bladestorm;
                lbl4.Text = "BladeStorm";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.reaper;
                lbl5.Text = "Reaper";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.Whirlwind;
                lbl6.Text = "WhirlWind";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.CoupdeGrace;
                lbl7.Text = "CoupdeGrace";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.combetfitness;
                xcom1.Visible = true;
                xcomlbl1.Text = "Combat Fitness";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.Concentration;
                xcom2.Visible = true;
                xcomlbl2.Text = "Concentration";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Dedication;
                xcom3.Visible = true;
                xcomlbl3.Text = "Dedication";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.LightningSlash;
                xcom4.Visible = true;
                xcomlbl4.Text = "Lightning Slash";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.Concentration;
                xcom4.Visible = true;
                xcomlbl4.Text = "Concentration";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.dodge;
                pcsImage.Visible = true;
                lblPcs.Text = "Agility";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.hazmat;
                vestImage.Visible = true;
                lblVest.Text = "Hazmat Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "Predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.SMG;
                weaponImg.Visible = true;
                lblWeapon.Text = "SMG";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Redscreen_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Hacking";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.med;
                mscImg2.Visible = true;
                lblMisc2.Text = "Medkit";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Auto Loader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;

            }
            else if (classTxt == "Stealth Shinobi")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.Ghostwalker;
                lbl1.Text = "Ghost Walker";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.Combatives;
                lbl2.Text = "Combatives";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.Covert;
                lbl3.Text = "Covert";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.bladestorm;
                lbl4.Text = "BladeStorm";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.HitandRun;
                lbl5.Text = "Hit & Run";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.Tradecraft;
                lbl6.Text = "Tradecraft";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.Conceal;
                lbl7.Text = "Conceal";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.combetfitness;
                xcom1.Visible = true;
                xcomlbl1.Text = "Combat Fitness";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.Concentration;
                xcom2.Visible = true;
                xcomlbl2.Text = "Concentration";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Dedication;
                xcom3.Visible = true;
                xcomlbl3.Text = "Dedication";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.LightningSlash;
                xcom4.Visible = true;
                xcomlbl4.Text = "Lightning Slash";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.dodge;
                pcsImage.Visible = true;
                lblPcs.Text = "Agility";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.hazmat;
                vestImage.Visible = true;
                lblVest.Text = "Hazmat Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.Spider_Suit;
                armorImg.Visible = true;
                lblArmor.Text = "Spider Suit";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.SMG;
                weaponImg.Visible = true;
                lblWeapon.Text = "SMG";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Redscreen_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Hacking";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.med;
                mscImg2.Visible = true;
                lblMisc2.Text = "Medkit";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Auto Loader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Shooty Shinobi")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.LoneWolf;
                lbl1.Text = "Lone Wolf";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.Executioner;
                lbl2.Text = "Executioner";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.Covert;
                lbl3.Text = "Covert";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.bladestorm;
                lbl4.Text = "Bladestorm";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.HitandRun;
                lbl5.Text = "Hit & Run";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.hunter;
                lbl6.Text = "Hunters Instinct";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.rapidfire;
                lbl7.Text = "Rapid Fire";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.CenterMass;
                xcom1.Visible = true;
                xcomlbl1.Text = "Center Mass";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.lethal;
                xcom2.Visible = true;
                xcomlbl2.Text = "Lethal";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Predetor1;
                xcom3.Visible = true;
                xcomlbl3.Text = "Predator";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.LockNLoad;
                xcom4.Visible = true;
                xcomlbl4.Text = "LocknLoad";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.Impulse;
                xcom5.Visible = true;
                xcomlbl5.Text = "Impulse";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.runandgun;
                xcom6.Visible = true;
                xcomlbl6.Text = "Run & Gun";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.combetfitness;
                xcom7.Visible = true;
                xcomlbl7.Text = "Combat Fitness";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.mobility;
                pcsImage.Visible = true;
                lblPcs.Text = "Mobility";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "Nanoscale Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.Spider_Suit;
                armorImg.Visible = true;
                lblArmor.Text = "Spider Suit";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Talon_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Talon";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.HuntersAxe;
                mscImg2.Visible = true;
                lblMisc2.Text = "Hunters Axe";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.magazine;
                Weap2.Visible = true;
                lblWeap2.Text = "Magazine";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.autoloader;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Killer Instinct Assault")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.lightningreflexes;
                lbl1.Text = "Lightning Reflexes";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.trenchgun;
                lbl2.Text = "Trenchgun";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.KillerInstinct;
                lbl3.Text = "Killer Instinct";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.extraconditioning;
                lbl4.Text = "Extra Conditioning";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.rapidfire;
                lbl5.Text = "Rapid Fire";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.untouchable;
                lbl6.Text = "Untouchable";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.lethal;
                lbl7.Text = "Lethal";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.combetfitness;
                xcom1.Visible = true;
                xcomlbl1.Text = "Combat Fitness";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.Ghostwalker;
                xcom2.Visible = true;
                xcomlbl2.Text = "Ghostwalker";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.shadowstrike;
                xcom3.Visible = true;
                xcomlbl3.Text = "Shadow Strike";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.ZoneofControl;
                xcom4.Visible = true;
                xcomlbl4.Text = "Zone of Control";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.Resilience;
                xcom5.Visible = true;
                xcomlbl5.Text = "Resilience";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.Reposition;
                xcom6.Visible = true;
                xcomlbl6.Text = "Reposition";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.QuickZap;
                xcom7.Visible = true;
                xcomlbl7.Text = "Quickzap";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                xcom8.Image = Properties.Resources.implacable;
                xcom8.Visible = true;
                xcomlbl8.Text = "implaceable";
                xcomlbl8.Visible = true;
                xcomlbl8.SelectionAlignment = HorizontalAlignment.Center;

                xcom9.Image = Properties.Resources.UnlimitedPower;
                xcom9.Visible = true;
                xcomlbl9.Text = "Unlimited Power";
                xcomlbl9.Visible = true;
                xcomlbl9.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.mobility;
                pcsImage.Visible = true;
                lblPcs.Text = "Mobility";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.hazmat;
                vestImage.Visible = true;
                lblVest.Text = "Hazmat Vest";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Shotgun;
                weaponImg.Visible = true;
                lblWeapon.Text = "Shotgun";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Talon_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Talon";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.laser_site;
                Weap1.Visible = true;
                lblWeap1.Text = "Laser Sight";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Autoloader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Breacher Assault")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.lightningreflexes;
                lbl1.Text = "Lightning Reflexes";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.CloseAndPersonal;
                lbl2.Text = "Close & Personal";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.Fortify;
                lbl3.Text = "Fortify";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.formidable;
                lbl4.Text = "Formidable";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.CloseEncounters;
                lbl5.Text = "Close Encounters";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.untouchable;
                lbl6.Text = "Untouchable";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.lethal;
                lbl7.Text = "Lethal";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.combetfitness;
                xcom1.Visible = true;
                xcomlbl1.Text = "Combat Fitness";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.ZoneofControl;
                xcom2.Visible = true;
                xcomlbl2.Text = "Zone of Control";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.Resilience;
                xcom3.Visible = true;
                xcomlbl3.Text = "Resilience";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;
             
                xcom4.Image = Properties.Resources.Reposition;
                xcom4.Visible = true;
                xcomlbl4.Text = "Reposition";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.QuickZap;
                xcom5.Visible = true;
                xcomlbl5.Text = "Quickzap";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.implacable;
                xcom6.Visible = true;
                xcomlbl6.Text = "implaceable";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.UnlimitedPower;
                xcom7.Visible = true;
                xcomlbl7.Text = "Unlimited Power";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.mobility;
                pcsImage.Visible = true;
                lblPcs.Text = "Speed";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "NanoScale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Shotgun;
                weaponImg.Visible = true;
                lblWeapon.Text = "Shotgun";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Talon_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Talons";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.laser_site;
                Weap1.Visible = true;
                lblWeap1.Text = "Laser Sight";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Autoloader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Stunner Assault")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";


                skill1.Image = Properties.Resources.lightningreflexes;
                lbl1.Text = "Lightning Reflexes";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.arculser;
                lbl2.Text = "Arc Pulser";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.StunGunner;
                lbl3.Text = "Stun Gunner";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.formidable;
                lbl4.Text = "Formidable";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.HitandRun;
                lbl5.Text = "Hit & Run";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.untouchable;
                lbl6.Text = "Untouchable";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.ChainLightning;
                lbl7.Text = "Chain Lightning";

                //Xcom abiltys
                xcom1.Image = Properties.Resources.QuickZap;
                xcom1.Visible = true;
                xcomlbl1.Text = "Quickzap";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;                

                xcom2.Image = Properties.Resources.UnlimitedPower;
                xcom2.Visible = true;
                xcomlbl2.Text = "Unlimited Power";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.Perception;
                pcsImage.Visible = true;
                lblPcs.Text = "Perceptiom";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "NanoScale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Tracer_Rounds;
                mscImg1.Visible = true;
                lblMisc1.Text = "Tracers";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.Scope;
                Weap1.Visible = true;
                lblWeap1.Text = "Scope";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.autoloader;
                Weap2.Visible = true;
                lblWeap2.Text = "Autoloader";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }

            else if (classTxt == "Overwatch Specialist")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.Sentinel;
                lbl1.Text = "Sentinal";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.FieldSurgeon;
                lbl2.Text = "Field Surgeon";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.Trojan;
                lbl3.Text = "Trojan";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.evervigilant;
                lbl4.Text = "Ever Vigilant";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.coolpressure;
                lbl5.Text = "Cool U Pressure";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.FullOverride;
                lbl6.Text = "Full Overide";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.killzone;
                lbl7.Text = "KillZone";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.Concentration;
                xcom1.Visible = true;
                xcomlbl1.Text = "Concentration";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.hunter;
                xcom2.Visible = true;
                xcomlbl2.Text = "Hunters Instincts";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.OpenFire;
                xcom3.Visible = true;
                xcomlbl3.Text = "Open Fire";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.shredder;
                xcom4.Visible = true;
                xcomlbl4.Text = "Shredder";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.ReadyForAnything;
                xcom5.Visible = true;
                xcomlbl5.Text = "RFA";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                xcom6.Image = Properties.Resources.DoubleTap;
                xcom6.Visible = true;
                xcomlbl6.Text = "Double Tap";
                xcomlbl6.Visible = true;
                xcomlbl6.SelectionAlignment = HorizontalAlignment.Center;

                xcom7.Image = Properties.Resources.CloseCombatSpecialist;
                xcom7.Visible = true;
                xcomlbl7.Text = "CCS";
                xcomlbl7.Visible = true;
                xcomlbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.hacking;
                pcsImage.Visible = true;
                lblPcs.Text = "Hacking";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.Rifle;
                weaponImg.Visible = true;
                lblWeapon.Text = "Rifle";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.med;
                mscImg1.Visible = true;
                lblMisc1.Text = "Medkit";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Skulljack;
                mscImg2.Visible = true;
                lblMisc2.Text = "SkullJack";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.hair_trigger;
                Weap1.Visible = true;
                lblWeap1.Text = "Hair Trigger";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.magazine;
                Weap2.Visible = true;
                lblWeap2.Text = "Magazine";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.laser_site;
                Weap3.Visible = true;
                lblWeap3.Text = "Hair Trigger";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (classTxt == "Support Specialist")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.revivalprotocol;
                lbl1.Text = "Revival Protocol";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.FieldSurgeon;
                lbl2.Text = "Field Surgeon";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.medicalprotocol;
                lbl3.Text = "Medical Protocol";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.fieldmedic;
                lbl4.Text = "Field Medic";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.Savior;
                lbl5.Text = "Savior";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.FullOverride;
                lbl6.Text = "Full Overide";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.Restoration;
                lbl7.Text = "Restoration";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.BlindingProtocol;
                xcom1.Visible = true;
                xcomlbl1.Text = "Blinding Protocol";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.NeutralizingAgents;
                xcom2.Visible = true;
                xcomlbl2.Text = "Neutralizing";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.shredder;
                xcom3.Visible = true;
                xcomlbl3.Text = "Shredder";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.hacking;
                pcsImage.Visible = true;
                lblPcs.Text = "Hacking";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                vestImage.Image = Properties.Resources.nanoScale;
                vestImage.Visible = true;
                lblVest.Text = "NanoScale";
                lblVest.Visible = true;
                lblVest.SelectionAlignment = HorizontalAlignment.Center;

                armorImg.Image = Properties.Resources.predatorArm;
                armorImg.Visible = true;
                lblArmor.Text = "predator";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.SMG;
                weaponImg.Visible = true;
                lblWeapon.Text = "SMG";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.med;
                mscImg1.Visible = true;
                lblMisc1.Text = "Medkit";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Skulljack;
                mscImg2.Visible = true;
                lblMisc2.Text = "SkullJack";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;

                Weap1.Image = Properties.Resources.autoloader;
                Weap1.Visible = true;
                lblWeap1.Text = "Auto Loader";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.Scope;
                Weap2.Visible = true;
                lblWeap2.Text = "Scope";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
            
            
            else if (classTxt == "Damage Grenadier")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                lblSkills.SelectionAlignment = HorizontalAlignment.Center;

                skill1.Image = Properties.Resources.NeedleGrenades;
                lbl1.Text = "Needle Grenades";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.heavyordenance;
                lbl2.Text = "Heavy Ordenance";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.boostedcores;
                lbl3.Text = "Boosted Cores";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.TandemWarheads;
                lbl4.Text = "Tandem Warheads";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.bigbooms;
                lbl5.Text = "Biggest Booms";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.volatilemix;
                lbl6.Text = "Volatile Mix";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;
                
                skill7.Image = Properties.Resources.FullKit;
                lbl7.Text = "Full Kit";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.BringEmOn;
                xcom1.Visible = true;
                xcomlbl1.Text = "Bring em";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.deepCover;
                xcom2.Visible = true;
                xcomlbl2.Text = "DeepCover";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.lightningreflexes;
                xcom3.Visible = true;
                xcomlbl3.Text = "Lightning Reflexes";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.holotarget;
                xcom4.Visible = true;
                xcomlbl4.Text = "Holo Target";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.mobility;
                pcsImage.Visible = true;
                lblPcs.Text = "Mobility";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                Vestlbl.Visible = false;

                armorImg.Image = Properties.Resources.EXO;
                armorImg.Visible = true;
                lblArmor.Text = "Exo Suit";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.SMG;
                weaponImg.Visible = true;
                lblWeapon.Text = "SMG";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Firebomb;
                mscImg1.Visible = true;
                lblMisc1.Text = "Incendiary Grenade";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

            }
            else if (classTxt == "Support Gremadier")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.lightningreflexes;
                lbl1.Text = "Lightning Reflexes";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.arculser;
                lbl2.Text = "Arc Pulser";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.StunGunner;
                lbl3.Text = "Stun Gunner";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.formidable;
                lbl4.Text = "Formidable";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.HitandRun;
                lbl5.Text = "Hit & Run";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.untouchable;
                lbl6.Text = "Untouchable";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.ChainLightning;
                lbl7.Text = "Chain Lightning";

            }
            else if (classTxt == "Support Grenadier")
            {
                //Leveling abiltys
                lblSkills.Text = classTxt + " Skills:";
                

                skill1.Image = Properties.Resources.RapidDeployment;
                lbl1.Text = "Rapid Deployment";
                lbl1.SelectionAlignment = HorizontalAlignment.Center;

                skill2.Image = Properties.Resources.heavyordenance;
                lbl2.Text = "Heavy Ordenance";
                lbl2.SelectionAlignment = HorizontalAlignment.Center;

                skill3.Image = Properties.Resources.BluescreenBombs;
                lbl3.Text = "Bluescreen Bombs";
                lbl3.SelectionAlignment = HorizontalAlignment.Center;

                skill4.Image = Properties.Resources.HEATWarheads;
                lbl4.Text = "Heat Warheads";
                lbl4.SelectionAlignment = HorizontalAlignment.Center;

                skill5.Image = Properties.Resources.StunGrenades;
                lbl5.Text = "Stun Grenades";
                lbl5.SelectionAlignment = HorizontalAlignment.Center;

                skill6.Image = Properties.Resources.salvo;
                lbl6.Text = "salvo";
                lbl6.SelectionAlignment = HorizontalAlignment.Center;

                skill7.Image = Properties.Resources.FullKit;
                lbl7.Text = "Full Kit";
                lbl7.SelectionAlignment = HorizontalAlignment.Center;

                //Xcom abiltys
                xcom1.Image = Properties.Resources.flash;
                xcom1.Visible = true;
                xcomlbl1.Text = "Flashbanger";
                xcomlbl1.Visible = true;
                xcomlbl1.SelectionAlignment = HorizontalAlignment.Center;

                xcom2.Image = Properties.Resources.deepCover;
                xcom2.Visible = true;
                xcomlbl2.Text = "DeepCover";
                xcomlbl2.Visible = true;
                xcomlbl2.SelectionAlignment = HorizontalAlignment.Center;

                xcom3.Image = Properties.Resources.lightningreflexes;
                xcom3.Visible = true;
                xcomlbl3.Text = "Lightning Reflexes";
                xcomlbl3.Visible = true;
                xcomlbl3.SelectionAlignment = HorizontalAlignment.Center;

                xcom4.Image = Properties.Resources.holotarget;
                xcom4.Visible = true;
                xcomlbl4.Text = "Holo Target";
                xcomlbl4.Visible = true;
                xcomlbl4.SelectionAlignment = HorizontalAlignment.Center;

                xcom5.Image = Properties.Resources.smoker;
                xcom5.Visible = true;
                xcomlbl5.Text = "Smoker";
                xcomlbl5.Visible = true;
                xcomlbl5.SelectionAlignment = HorizontalAlignment.Center;

                //Equipment
                pcsImage.Image = Properties.Resources.mobility;
                pcsImage.Visible = true;
                lblPcs.Text = "Mobility";
                lblPcs.Visible = true;
                lblPcs.SelectionAlignment = HorizontalAlignment.Center;

                Vestlbl.Visible = false;

                armorImg.Image = Properties.Resources.EXO;
                armorImg.Visible = true;
                lblArmor.Text = "Exo Suit";
                lblArmor.Visible = true;
                lblArmor.SelectionAlignment = HorizontalAlignment.Center;

                weaponImg.Image = Properties.Resources.SMG;
                weaponImg.Visible = true;
                lblWeapon.Text = "SMG";
                lblWeapon.Visible = true;
                lblWeapon.SelectionAlignment = HorizontalAlignment.Center;

                mscImg1.Image = Properties.Resources.Firebomb;
                mscImg1.Visible = true;
                lblMisc1.Text = "Incendiary Grenade";
                lblMisc1.Visible = true;
                lblMisc1.SelectionAlignment = HorizontalAlignment.Center;

                mscImg2.Image = Properties.Resources.Frost_Bomb;
                mscImg2.Visible = true;
                lblMisc2.Text = "Frost Bomb";
                lblMisc2.Visible = true;
                lblMisc2.SelectionAlignment = HorizontalAlignment.Center;


                Weap1.Image = Properties.Resources.autoloader;
                Weap1.Visible = true;
                lblWeap1.Text = "Auto Loader";
                lblWeap1.Visible = true;
                lblWeap1.SelectionAlignment = HorizontalAlignment.Center;

                Weap2.Image = Properties.Resources.Scope;
                Weap2.Visible = true;
                lblWeap2.Text = "Scope";
                lblWeap2.Visible = true;
                lblWeap2.SelectionAlignment = HorizontalAlignment.Center;

                Weap3.Image = Properties.Resources.Suppressor;
                Weap3.Visible = true;
                lblWeap3.Text = "Suppressor";
                lblWeap3.Visible = true;
                lblWeap3.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
            
        private void SKPform_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoldierBuilder builder = new SoldierBuilder();
            builder.Show();
        }
    }
}
