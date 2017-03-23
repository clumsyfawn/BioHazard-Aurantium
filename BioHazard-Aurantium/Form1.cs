using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace BioHazard_Aurantium
{
    public partial class thegame : Form
    {
        //************************VARIABLES************************//

        // Sound //
        int volume = 100;
        bool mute = false;

        // Game-Related Booleans //
        bool playing = false;
        bool[] movementkeypress = new bool[4];
        bool[] hotkeypress = new bool[3];

        // Player class //
        bool[] playerclass = new bool[3];

        // Weapon unclock //
        bool[] weaponunlocked = new bool[7];

        // Legendary unlock //
        bool[] legendaryunlocked = new bool[6];

        // Graphics, Angle and Direction related //
        Point mousecoordinates;
        int angle;
        Player player1 = new Player();
        MeleePlayer player3 = new MeleePlayer();
        Enemy enemy1 = new Enemy();

        //************************INITIALIZATION************************//

        public thegame()
        {
            InitializeComponent();

            // Fixes stuttering //
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            player1.Initialise();
            enemy1.Initialise(0, new Point(1100, 860));

            // If mute isn't true, play rain and main menu music sounds //
            if (mute != true)
            {
                MainMenuMusic.URL = "sounds/menu/MainMenuMusic.mp3";
                MainMenuMusic.Ctlcontrols.play();
                MainMenuMusic.settings.volume = volume;

                MainMenuRain.URL = "sounds/menu/MainMenuRain.mp3";
                MainMenuRain.Ctlcontrols.play();
                MainMenuRain.settings.volume = volume / 7;
            }

            // Sets movement key presses booleans to false //
            movementkeypress[0] = false; //W
            movementkeypress[1] = false; //S
            movementkeypress[2] = false; //A
            movementkeypress[3] = false; //D

            // Sets hotkey presses booleans to false //
            hotkeypress[0] = false; //TALENT
            hotkeypress[1] = false; //MUTE
            hotkeypress[2] = false; //ESCAPE

            // Sets chosen class to false //
            playerclass[0] = false; //ASSAULT
            playerclass[1] = false; //SCOUT
            playerclass[2] = false; //SWORDSMAN

            // Sets all weapon unlocks to false //
            weaponunlocked[0] = false; //AK47
            weaponunlocked[1] = false; //FAMAS
            weaponunlocked[2] = false; //M4A1
            weaponunlocked[3] = false; //FAL
            weaponunlocked[4] = false; //UZI
            weaponunlocked[5] = false; //P90
            weaponunlocked[6] = false; //BROADSWORD
            legendaryunlocked[0] = false; //FIVESEVEN - Legendary
            legendaryunlocked[1] = false; //AK47 - Legendary
            legendaryunlocked[2] = false; //FAMAS - Legendary
            legendaryunlocked[3] = false; //M4A1 - Legendary
            legendaryunlocked[4] = false; //P90 - Legendary
            legendaryunlocked[5] = false; //ABYSSWALKER - Legendary

        }

        //************************MAIN MENU************************//
        
        // Changing button image and play sound when mouse is over the buttons //
        private void Play_Button_MouseEnter(object sender, EventArgs e)
        {
            this.Play_Button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Play_Button1));
            MainMenuButtons.URL = "sounds/menu/MenuMouseOver.mp3";
            MainMenuButtons.Ctlcontrols.play();
            MainMenuButtons.settings.volume = volume;
        }

        private void Play_Button_MouseLeave(object sender, EventArgs e)
        {
            this.Play_Button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Play_Button0));
        }

        private void Instructions_Button_MouseEnter(object sender, EventArgs e)
        {
            this.Instructions_Button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Instructions_Button1));
            MainMenuButtons.URL = "sounds/menu/MenuMouseOver.mp3";
            MainMenuButtons.Ctlcontrols.play();
            MainMenuButtons.settings.volume = volume;
        }

        private void Instructions_Button_MouseLeave(object sender, EventArgs e)
        {
            this.Instructions_Button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Instructions_Button0));
        }

        private void Options_Button_MouseEnter(object sender, EventArgs e)
        {
            this.Options_Button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Options_Button1));
            MainMenuButtons.URL = "sounds/menu/MenuMouseOver.mp3";
            MainMenuButtons.Ctlcontrols.play();
            MainMenuButtons.settings.volume = volume;
        }

        private void Options_Button_MouseLeave(object sender, EventArgs e)
        {
            this.Options_Button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Options_Button0));
        }

        //************************PLAYBUTTON************************//

        private void Play_Button_MouseClick(object sender, MouseEventArgs e)
        {

            // Stops playing the music and rain effect //
            MainMenuMusic.URL = "sounds/menu/MainMenuMusic.mp3";
            MainMenuMusic.Ctlcontrols.stop();
            MainMenuMusic.settings.volume = volume;

            // Plays Game Start sound effect and starts the game //
            MainMenuButtons.URL = "sounds/menu/GameStart.mp3";
            MainMenuButtons.Ctlcontrols.play();
            MainMenuButtons.settings.volume = volume;

            // Hide menu //
            playing = true;
            gameloop.Enabled = true;
            Play_Button.Visible = false;
            Options_Button.Visible = false;
            Instructions_Button.Visible = false;

            BackgroundImage = (BioHazard_Aurantium.Properties.Resources.HP0);
            playerclass[2] = true;
        }

        //************************INSTRUCTIONS************************//

        private void Instructions_Button_MouseClick(object sender, MouseEventArgs e)
        {
            // Hiding Main Menu to show Instructions screen//
            instructionspanel.Visible = true;
        }

        // Back button //
        private void Back_Button_Instructions_MouseClick(object sender, MouseEventArgs e)
        {
            instructionspanel.Visible = false;
            MainMenuBackButtons.URL = "sounds/menu/MenuBack.mp3";
            MainMenuBackButtons.Ctlcontrols.play();
            MainMenuBackButtons.settings.volume = volume;
        }

        private void Back_Button_Instructions_MouseEnter(object sender, EventArgs e)
        {
            this.Back_Button_Instructions.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Back_Button1));
        }

        private void Back_Button_Instructions_MouseLeave(object sender, EventArgs e)
        {
            this.Back_Button_Instructions.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Back_Button));
        }

        //************************OPTIONS************************//

        private void Options_Button_MouseClick(object sender, MouseEventArgs e)
        {
            // Hiding Main Menu to show Options screen //
            optionspanel.Visible = true;

            // Setting Volume slider image upon entering Options screen based off volume variable //
            if (volume == 0)
            {
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume0));
            }

            if (volume == 25)
            {
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume25));
            }

            if (volume == 50)
            {
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume50));
            }

            if (volume == 75)
            {
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume75));
            }

            if (volume == 100)
            {
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume100));
            }
        }

        // Back button //
        private void Back_Button_MouseClick(object sender, MouseEventArgs e)
        {
            optionspanel.Visible = false;
            MainMenuBackButtons.URL = "sounds/menu/MenuBack.mp3";
            MainMenuBackButtons.Ctlcontrols.play();
            MainMenuBackButtons.settings.volume = volume;
        }

        private void Back_Button_Options_MouseEnter(object sender, EventArgs e)
        {
            this.Back_Button_Options.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Back_Button1));
        }

        private void Back_Button_Options_MouseLeave(object sender, EventArgs e)
        {
            this.Back_Button_Options.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Back_Button));
        }

        // Giving commands to volume buttons to change volume //
        private void volumebutton25_MouseClick(object sender, MouseEventArgs e)
        {
            volume = volume * 0 + 25;
            this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
            this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
            this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume25));
            MainMenuMusic.settings.volume = volume;
            MainMenuRain.settings.volume = volume / 7;
        }

        private void volumebutton50_MouseClick(object sender, MouseEventArgs e)
        {
            volume = volume * 0 + 50;
            this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
            this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
            this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume50));
            MainMenuMusic.settings.volume = volume;
            MainMenuRain.settings.volume = volume / 7;
            
        }

        private void volumebutton75_MouseClick(object sender, MouseEventArgs e)
        {
            volume = volume * 0 + 75;
            this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
            this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
            this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume75));
            MainMenuMusic.settings.volume = volume;
            MainMenuRain.settings.volume = volume / 7;
            
        }

        private void volumebutton100_MouseClick(object sender, MouseEventArgs e)
        {
            volume = volume * 0 + 100;
            this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
            this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
            this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume100));
            MainMenuMusic.settings.volume = volume;
            MainMenuRain.settings.volume = volume / 7;
            
        }

        // Mute button //
        private void Mute_Button_MouseClick(object sender, MouseEventArgs e)
        {
            if (mute == false)
            {
                mute = true;
                volume = volume * 0;
                MainMenuMusic.settings.volume = volume * 0;
                MainMenuRain.settings.volume = volume / 7;
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume0));
            }
            else
            {
                mute = false;
                volume = volume * 0 + 100;
                MainMenuMusic.settings.volume = volume * 0 + 100;
                MainMenuRain.settings.volume = volume / 7;
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
                this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume100));
            }
        }

        // Image change on mouse over and leave for volume buttons //
        private void volumebutton100_MouseEnter(object sender, EventArgs e)
        {
            if (volume < 100)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button1001));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button751));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button501));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button251));
            }
        }

        private void volumebutton100_MouseLeave(object sender, EventArgs e)
        {
            if (volume < 100)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100off));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            }

            if (volume == 75)
            {
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 50)
            {
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 25)
            {
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }
        }


        private void volumebutton75_MouseEnter(object sender, EventArgs e)
        {
            if (volume < 75)
            {
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button751));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button501));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button251));
            }

            if (volume > 75)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100off));
            }
        }

        private void volumebutton75_MouseLeave(object sender, EventArgs e)
        {
            if (volume < 75)
            {
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            }

            if (volume == 100)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 75)
            {
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 50)
            {
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }
            if (volume == 25)
            {
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

        }

        private void volumebutton50_MouseEnter(object sender, EventArgs e)
        {
            if (volume < 50)
            {
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button501));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button251));
            }

            if (volume > 50)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100off));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
            }
        }

        private void volumebutton50_MouseLeave(object sender, EventArgs e)
        {
            if (volume < 50)
            {
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            }

            if (volume == 100)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 75)
            {
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 50)
            {
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }
            if (volume == 25)
            {
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }
        }

        private void volumebutton25_MouseEnter(object sender, EventArgs e)
        {
            if (volume < 25)
            {
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button251));
            }

            if (volume > 25)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100off));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
            }
        }

        private void volumebutton25_MouseLeave(object sender, EventArgs e)
        {
            if (volume < 25)
            {
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
            }

            if (volume == 100)
            {
                this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button100));
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 75)
            {
                this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }

            if (volume == 50)
            {
                this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }
            if (volume == 25)
            {
                this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
            }
        }

        //************************TALENTS************************//

        private void TalentsExit_Button_MouseClick(object sender, MouseEventArgs e)
        {
            talentspanel.Visible = false;
        }

        //************************GAMELOOP************************//
        
        private void gameloop_Tick(object sender, EventArgs e)
        {
            if (playing != false)
            {
                moveplayer();
                this.Refresh();
                player1.set_angle(getangle());
            }
        }

        //************************GRAPHICS************************//

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {
            if (playing != false)
            {
                //*********PLAYER*********//
                if (((playerclass[0] == true) || (playerclass[1] == true)))
                {
                    e.Graphics.DrawImage(player1.get_currentgraphic(), player1.get_position().X, player1.get_position().Y, 50, 50);
                }

                if (playerclass[2] == true)
                {
                    e.Graphics.DrawImage(player3.get_currentgraphic(), player3.get_position().X, player3.get_position().Y, 150, 150);
                }


                //*********HUD*********//

                // Art //
                e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HUD, 0, 870, 1280, 130);
                e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.ZombiesLeft, 0, 0, 125, 26);

                // Weapons //
                switch (player1.get_currentweapon())
                {
                        //**PISTOL**//
                    case "FIVESEVEN":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.FIVESEVEN, 1100, 860, 150, 150);
                        }
                        break;

                    case "FIVESEVEN - Legendary":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.FIVESEVEN_L, 1100, 860, 150, 150);
                        }
                        break;

                        //**ASSAULT**//
                    case "AK47":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.AK47, 1100, 860, 150, 150);
                        }
                        break;

                    case "AK47 - Legendary":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.AK47_L, 1100, 860, 150, 150);
                        }
                        break;

                    case "FAMAS":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.FAMAS, 1100, 860, 150, 150);
                        }
                        break;

                    case "FAMAS - Legendary":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.FAMAS_L, 1100, 860, 150, 150);
                        }
                        break;

                    case "M4A1":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.M4A1, 1100, 860, 150, 150);
                        }
                        break;

                    case "M4A1 - Legendary":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.M4A1_L, 1100, 860, 150, 150);
                        }
                        break;

                    case "FAL":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.FAL, 1100, 860, 150, 150);
                        }
                        break;

                        //**SUBMACHINE**//
                    case "UZI":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.UZI, 1100, 860, 150, 150);
                        }
                        break;

                    case "P90":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.P90, 1100, 860, 150, 150);
                        }
                        break;

                    case "P90 - Legendary":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.P90_L, 1100, 860, 150, 150);
                        }
                        break;

                        //**MELEE**//
                    case "KNIFE":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.KNIFE, 1100, 860, 150, 150);
                        }
                        break;

                    case "BROADSWORD":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.BROADSWORD, 1100, 860, 150, 150);
                        }
                        break;

                    case "ABYSSWALKER - Legendary":
                        {
                            e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.ABYSSWALKER_L, 1100, 860, 150, 150);
                        }
                        break;


                }

                // Health //
                healthtext.Text = (player1.get_health().ToString());

                // 0 //
                if (player1.get_health() == 0)
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HP0, 109, 907, 143, 27);
                }

                // 1-24 //
                if ((player1.get_health() >= 1) && (player1.get_health() <= 24))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HP20, 109, 907, 143, 27);
                }

                // 25-44 //
                if ((player1.get_health() >= 25) && (player1.get_health() <= 44))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HP40, 109, 907, 143, 27);
                }

                // 45-64 //
                if ((player1.get_health() >= 45) && (player1.get_health() <= 64))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HP60, 109, 907, 143, 27);
                }

                // 65-84 //
                if ((player1.get_health() >= 65) && (player1.get_health() <= 84))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HP80, 109, 907, 143, 27);
                }

                // 85-100 //
                if ((player1.get_health() >= 85) && (player1.get_health() <= 100))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.HP100, 109, 907, 143, 27);  
                }

                // Charge //

                // 0 //
                if (((player1.get_charge() >= 0) || (player1.get_charge() <= 24)))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.CH0, 250, 730, 750, 180);
                }
                // 25 //
                if ((player1.get_charge() >= 25) && (player1.get_charge() <= 49))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.CH25, 250, 730, 750, 180);
                }
                // 50 //
                if ((player1.get_charge() >= 50) && (player1.get_charge() <= 74))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.CH50, 250, 730, 750, 180);
                }
                // 75 //
                if ((player1.get_charge() >= 75) && (player1.get_charge() <= 99))
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.CH75, 250, 730, 750, 180);
                }
                // 100 //
                if (player1.get_charge() == 100)
                {
                    e.Graphics.DrawImage(BioHazard_Aurantium.Properties.Resources.CH100, 250, 730, 750, 180);
               
                // Crosshair //
                    Bitmap crosshairb = new Bitmap(BioHazard_Aurantium.Properties.Resources.Crosshair2);
                    crosshairb.MakeTransparent(crosshairb.GetPixel(0, 0));
                    Graphics crosshairg = Graphics.FromImage(crosshairb);
                    IntPtr ptr = crosshairb.GetHicon();
                    Cursor = new System.Windows.Forms.Cursor(ptr);
                }
                else
                {
                    Bitmap cursorb = new Bitmap(BioHazard_Aurantium.Properties.Resources.Cursor);
                    cursorb.MakeTransparent(cursorb.GetPixel(0, 0));
                    Graphics cursorg = Graphics.FromImage(cursorb);
                    IntPtr ptr = cursorb.GetHicon();
                    Cursor = new System.Windows.Forms.Cursor(ptr);
                }
            }
        }

        //************************MOVEMENT&HOTKEYS************************//

        // When corresponding key is pressed, sets boolean values to true //
        private void thegame_KeyDown(object sender, KeyEventArgs e)
        {
            //*********MOVEMENT*********//
            if (playing != false)
            {
                if (e.KeyCode == Keys.W)
                {
                    movementkeypress[0] = true;
                }

                if (e.KeyCode == Keys.S)
                {
                    movementkeypress[1] = true;
                }

                if (e.KeyCode == Keys.A)
                {
                    movementkeypress[2] = true;
                }

                if (e.KeyCode == Keys.D)
                {
                    movementkeypress[3] = true;
                }
            }

            if (((playerclass[0] == true) || (playerclass[1] == true)))
            {
                //*********GAME HOTKEYS*********//

                // Weapon slots for ASSAULT class//

                if (playerclass[0] == true)
                {
                    //*****DEFAULT*****//
                    if (e.KeyCode == Keys.D1)
                    {
                        if (player1.get_weaponslot(0) != "Empty")
                        {
                            player1.change_weapon(0);
                        }
                    }

                    //*****WEAPON UNLOCKS*****//

                    if (weaponunlocked[0] == true)
                    {
                        // AK47 //
                        if (e.KeyCode == Keys.D2)
                        {
                            if (player1.get_weaponslot(1) != "Empty")
                            {
                                player1.change_weapon(2);
                            }
                        }

                        // FAMAS //
                        if (weaponunlocked[1] == true)
                        {
                            if (e.KeyCode == Keys.D3)
                            {
                                if (player1.get_weaponslot(2) != "Empty")
                                {
                                    player1.change_weapon(3);
                                }
                            }
                        }

                        // M4A1 //
                        if (weaponunlocked[2] == true)
                        {
                            if (e.KeyCode == Keys.D4)
                            {
                                if (player1.get_weaponslot(3) != "Empty")
                                {
                                    player1.change_weapon(4);
                                }
                            }
                        }

                        // FAL //
                        if (weaponunlocked[3] == true)
                        {
                            if (e.KeyCode == Keys.D5)
                            {
                                if (player1.get_weaponslot(4) != "Empty")
                                {
                                    player1.change_weapon(5);
                                }
                            }
                        }
                    }
                }

                // Weapon slots for SCOUT class//

                //*****DEFAULT*****//
                if (playerclass[1] == true)
                {
                    if (e.KeyCode == Keys.D1)
                    {
                        if (player1.get_weaponslot(0) != "Empty")
                        {
                            player1.change_weapon(0);
                        }
                    }

                    //*****WEAPON UNLOCKS*****//

                    // UZI //
                    if (weaponunlocked[4] == true)
                    {
                        if (e.KeyCode == Keys.D2)
                        {
                            if (player1.get_weaponslot(1) != "Empty")
                            {
                                player1.change_weapon(6);
                            }
                        }
                    }

                    // P90 //
                    if (weaponunlocked[4] == true)
                    {
                        if (e.KeyCode == Keys.D3)
                        {
                            if (player1.get_weaponslot(2) != "Empty")
                            {
                                player1.change_weapon(7);
                            }
                        }
                    }
                }
            }

            if (playerclass[2] == true)
            {
                // Weapon slots for SWORDSMAN class//

                //*****DEFAULT*****//
                if (e.KeyCode == Keys.D1)
                {
                    if (player1.get_weaponslot(0) != "Empty")
                    {
                        player1.change_weapon(0);
                    }
                }

                //*****WEAPON UNLOCKS*****//

                // BROADSWORD //
                if (weaponunlocked[6] == true)
                {
                    if (e.KeyCode == Keys.D1)
                    {
                        if (player1.get_weaponslot(0) != "Empty")
                        {
                            player1.change_weapon(1);
                        }
                    }
                }
            }

            //*********MENU HOTKEYS*********//
            if (e.KeyCode == Keys.N)
            {
                hotkeypress[0] = true;
                hotkeypressed();
            }

            if (e.KeyCode == Keys.M)
            {
                hotkeypress[1] = true;
                hotkeypressed();
            }

            if (e.KeyCode == Keys.Escape)
            {
                hotkeypress[2] = true;
                hotkeypressed();
            }
        }
            
        

        // When key is released, boolean values are set to false //
        private void thegame_KeyUp(object sender, KeyEventArgs e)
        {
            //*********MOVEMENT*********//
            if (playing != false)
            {
                if (e.KeyCode == Keys.W)
                {
                    movementkeypress[0] = false;
                }

                if (e.KeyCode == Keys.S)
                {
                    movementkeypress[1] = false;
                }

                if (e.KeyCode == Keys.A)
                {
                    movementkeypress[2] = false;
                }

                if (e.KeyCode == Keys.D)
                {
                    movementkeypress[3] = false;
                }
            }

            //*********GAME HOTKEYS*********//

            //*********MENU HOTKEYS*********//
            if (e.KeyCode == Keys.N)
            {
                hotkeypress[0] = false;
            }

            if (e.KeyCode == Keys.M)
            {
                hotkeypress[1] = false;
            }

            if (e.KeyCode == Keys.Escape)
            {
                hotkeypress[2] = false;
            }

        }

        //************************KEY FUNCTIONS************************//

        // Moves player in a direction depending on key pressed //
        private void moveplayer()
        {
            if (((playerclass[0] == true) || (playerclass[1] == true)))
            {
                //up//
                if ((movementkeypress[0] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == false))
                {
                    player1.move_up();
                }
                //up-right//
                if ((movementkeypress[0] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == true))
                {
                    player1.move_upright();
                }
                //up-left//
                if ((movementkeypress[0] == true) && (movementkeypress[2] == true) && (movementkeypress[3] == false))
                {
                    player1.move_upleft();
                }

                //down//
                if ((movementkeypress[1] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == false))
                {
                    player1.move_down();
                }

                //down-right//
                if ((movementkeypress[1] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == true))
                {
                    player1.move_downright();
                }

                //down-left//
                if ((movementkeypress[1] == true) && (movementkeypress[2] == true) && (movementkeypress[3] == false))
                {
                    player1.move_downleft();
                }

                //right//
                if ((movementkeypress[3] == true) && (movementkeypress[1] == false) && (movementkeypress[0] == false))
                {
                    player1.move_right();
                }
                //left//
                if ((movementkeypress[2] == true) && (movementkeypress[1] == false) && (movementkeypress[0] == false))
                {
                    player1.move_left();
                }
            }

            if (playerclass[2] == true)
            {
                //up//
                if ((movementkeypress[0] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == false))
                {
                    player3.move_up();
                }
                //up-right//
                if ((movementkeypress[0] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == true))
                {
                    player3.move_upright();
                }
                //up-left//
                if ((movementkeypress[0] == true) && (movementkeypress[2] == true) && (movementkeypress[3] == false))
                {
                    player3.move_upleft();
                }

                //down//
                if ((movementkeypress[1] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == false))
                {
                    player3.move_down();
                }

                //down-right//
                if ((movementkeypress[1] == true) && (movementkeypress[2] == false) && (movementkeypress[3] == true))
                {
                    player3.move_downright();
                }

                //down-left//
                if ((movementkeypress[1] == true) && (movementkeypress[2] == true) && (movementkeypress[3] == false))
                {
                    player3.move_downleft();
                }

                //right//
                if ((movementkeypress[3] == true) && (movementkeypress[1] == false) && (movementkeypress[0] == false))
                {
                    player3.move_right();
                }
                //left//
                if ((movementkeypress[2] == true) && (movementkeypress[1] == false) && (movementkeypress[0] == false))
                {
                    player3.move_left();
                }
            }
        }

        // Activates hotkey function when button is pressed //
        private void hotkeypressed()
        {
            // Talents //
            if (hotkeypress[0] == true)
            {
                if (talentspanel.Visible == false)
                {
                    talentspanel.Visible = true;
                }
                else
                {
                    talentspanel.Visible = false;
                }
            }

            // Mute //
            if (hotkeypress[1] == true)
            {
                if (mute == false)
                {
                    mute = true;
                    MainMenuMusic.settings.volume = volume * 0;
                    MainMenuRain.settings.volume = 25;
                    this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
                    this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50off));
                    this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75off));
                    this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25off));
                    this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume0));
                }
                else
                {
                    mute = false;
                    MainMenuMusic.settings.volume = volume * 0 + 100;
                    MainMenuRain.settings.volume = volume / 7;
                    this.volumebutton25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
                    this.volumebutton50.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button50));
                    this.volumebutton75.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button75));
                    this.volumebutton100.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Volume_Button25));
                    this.volumepercentage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.volume100));
                }
            }

            // Escape Menu //
            if (hotkeypress[2] == true)
            {
                if (playing == true)
                {
                    playing = false;
                    Play_Button.Visible = true;
                    Options_Button.Visible = true;
                    Instructions_Button.Visible = true;

                }
                else
                {
                    playing = true;
                    Play_Button.Visible = false;
                    Options_Button.Visible = false;
                    Instructions_Button.Visible = false;
                }
            }
        }

        //************************COORDINATES&ANGLE************************//

        // Get mouse coordinates //
        private void thegame_MouseMove(object sender, MouseEventArgs e)
        {
            mousecoordinates = e.Location;
        }

        // Get angle //
        private int getangle()
        {
            if (((playerclass[0] == true) || (playerclass[1] == true)))
            {
                //RIGHT SIDE
                if (mousecoordinates.X >= player1.get_centreposition().X)
                {
                    // UP RIGHT
                    if (mousecoordinates.Y < player1.get_centreposition().Y)
                    {
                        double adj = player1.get_centreposition().Y - mousecoordinates.Y;
                        double opp = mousecoordinates.X - player1.get_centreposition().X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI);
                    }
                    //BOTTOM RIGHT
                    else
                    {
                        double opp = mousecoordinates.Y - player1.get_centreposition().Y;
                        double adj = mousecoordinates.X - player1.get_centreposition().X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI) + 90;
                    }
                }
                //LEFT SIDE
                else
                {
                    //UP LEFT
                    if (mousecoordinates.Y < player1.get_centreposition().Y)
                    {
                        double opp = player1.get_centreposition().Y - mousecoordinates.Y;
                        double adj = player1.get_centreposition().X - mousecoordinates.X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI) + 270;
                    }
                    //BOTTOM LEFT
                    else
                    {
                        double adj = mousecoordinates.Y - player1.get_centreposition().Y;
                        double opp = player1.get_centreposition().X - mousecoordinates.X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI) + 180;
                    }
                }
            }

            if (playerclass[2] == true)
            {
                //RIGHT SIDE
                if (mousecoordinates.X >= player3.get_centreposition().X)
                {
                    // UP RIGHT
                    if (mousecoordinates.Y < player3.get_centreposition().Y)
                    {
                        double adj = player3.get_centreposition().Y - mousecoordinates.Y;
                        double opp = mousecoordinates.X - player3.get_centreposition().X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI);
                    }
                    //BOTTOM RIGHT
                    else
                    {
                        double opp = mousecoordinates.Y - player3.get_centreposition().Y;
                        double adj = mousecoordinates.X - player3.get_centreposition().X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI) + 90;
                    }
                }
                //LEFT SIDE
                else
                {
                    //UP LEFT
                    if (mousecoordinates.Y < player3.get_centreposition().Y)
                    {
                        double opp = player3.get_centreposition().Y - mousecoordinates.Y;
                        double adj = player3.get_centreposition().X - mousecoordinates.X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI) + 270;
                    }
                    //BOTTOM LEFT
                    else
                    {
                        double adj = mousecoordinates.Y - player3.get_centreposition().Y;
                        double opp = player3.get_centreposition().X - mousecoordinates.X;

                        angle = (int)((Math.Atan(opp / adj)) * 180 / Math.PI) + 180;
                    }
                }
            }
            
            return angle;
        }
    }
}
