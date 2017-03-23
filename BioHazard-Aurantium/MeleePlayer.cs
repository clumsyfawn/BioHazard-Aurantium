using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;

namespace BioHazard_Aurantium
{
    class MeleePlayer
    {
        //************************VARIABLES************************//

        //Graphic, Angle, Position Related //
        Point position;

        int angle;
        int direction;
        int animation;
        int frame;

        //Player attributes//
        int speed;
        int health;
        int maxhealth;
        int charge;
        int maxcharge;

        //Weapons//
        string[] weapons = new string[3];
        byte currentweapon;
        byte currentweaponanimationnumber;

        //Talents//
        int skillpoints;
        int EXP;

        //************************INITIALIZATION************************//
        public void Initialise()
        {

            // Setting attributes at the start of the game //
            position = new Point(0, 0);
            direction = 0;
            angle = 180;

            health = 100;
            maxhealth = 100;
            charge = 0;
            maxcharge = 100;
            speed = 5;

            EXP = 0;
            skillpoints = 0;

            // Setting starting weapons //

            currentweapon = 0;
            currentweaponanimationnumber = 0;

            // Starting weapon //

            weapons[0] = "KNIFE";


            //************************NORMAL WEAPON************************//

            // Melee //
            weapons[1] = "BROADSWORD";

            //************************LEGENDARY WEAPONS************************//

            // Melee //
            weapons[2] = "ABYSSWALKER - Legendary";

    
            //************************SOUND************************//

            // Setting sounds //
            meleeplayer_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
            //player_audio[1] = new SoundPlayer(Properties.Resources.TakingDamageSound);
            //player_audio[2] = new SoundPlayer(Properties.Resources.ReloadingSound);
            //player_audio[3] = new SoundPlayer(Properties.Resources.AchievementSound);


            //************************IMAGES************************//

            string imagepath = "images/meleeplayer/";

            for (int setnumber = 0; setnumber < 8; setnumber++)
            {
                for (int animationnumber = 0; animationnumber < 10; animationnumber++)
                {
                    animations[(10 * setnumber) + animationnumber].frames = new List<Bitmap>();
                    int imagecount = Directory.GetFiles(imagepath + setnumber + "/" + animationnumber + "/", "*.png", SearchOption.AllDirectories).Length;
                    for (int framenumber = 0; framenumber < imagecount; framenumber++)
                    {
                        //Loads the image //
                        animations[(10 * setnumber) + animationnumber].frames.Add(new Bitmap(imagepath + setnumber + "/" + animationnumber + "/" + framenumber + ".png"));
                    }
                }
            }

            animation = 0;
            frame = 0;
        }

        //************************ANIMATION************************//

        // How many pictures there are altogether //
        animation_frames[] animations = new animation_frames[74];

        // Gets the players angle //
        public int get_playerangle()
        {
            return angle;
        }

        // Gets the weapon that the player is holding //
        public string get_currentweapon()
        {
            return weapons[currentweapon];
        }

        // Animation data//
        struct animation_frames
        {
            public List<Bitmap> frames;
        }

        // Changes the animation //
        public void change_animation(int animationnumber)
        {
            if (animationnumber != animation)
            {
                frame = 0;
            }

            if (animationnumber != -1)
            {
                animation = currentweaponanimationnumber + animationnumber;
            }
            else
            {
                animationnumber = 46;
            }
        }

        // Plays the animation //
        public void play_animation()
        {
            if (frame < animations[(10 * direction) + animation].frames.Count)
            {
                frame++;
            }
            else
            {
                if ((animation >= 3) && (animation <= 5))
                {
                    frame = 0;
                }
                else
                {
                    if (animation != 10)
                    {
                        change_animation(0);
                    }
                    else
                    {
                        // Nothing, You are Dead //
                    }
                }
            }
        }




        //************************POSITION************************//

        // Sets position //
        public void set_position(Point newposition)
        {
            position = newposition;
        }

        // Gets player position //
        public Point get_position()
        {
            return position;
        }

        // Gets players centre position //
        public Point get_centreposition()
        {
            return new Point(position.X + (150 / 2), position.Y + (150 / 2));
        }

        // Gets player image //
        public Bitmap get_currentgraphic()
        {
            return animations[(10 * direction) + animation].frames[frame];
        }

        //************************PLAYER ATTRIBUTES************************//

        // Gets the players current health //
        public int get_health()
        {
            return health;
        }

        // Gets the players maximum health //
        public int get_maxhealth()
        {
            return maxhealth;
        }

        // Gets the players charge //
        public int get_charge()
        {
            return charge;
        }

        // Ges the players maximum charge //
        public int get_maxcharge()
        {
            return maxcharge;
        }

        // Gets players speed //
        public int get_speed()
        {
            return speed;
        }

        // Gets the players EXP //
        public int get_EXP()
        {
            return EXP;
        }

        // Gets the players Skill Points //
        public int get_skillpoints()
        {
            return skillpoints;
        }

        // Reduces players health //
        public void reduce_health(int amount)
        {
            health -= amount;
        }

        // Increases players health //
        public void increase_health(int amount)
        {
            if (health + amount > maxhealth)
            {
                health = maxhealth;
            }
            else
            {
                health += amount;
            }
        }

        // Increases EXP //
        public void increase_EXP(int amount)
        {
            EXP += amount;
        }

        // Increases Skill Points //
        public void increase_skillpoints(int amount)
        {
            skillpoints += amount;
        }

        // Decreases Skill Points //
        public void decrease_skillpoints(int amount)
        {
            skillpoints -= amount;
        }

        // Gets current weapon slot //
        public string get_weaponslot(int slot_number)
        {
            return weapons[slot_number];
        }

        //************************MOVEMENT************************//

        // UP //
        public void move_up()
        {
            position = new Point(position.X, position.Y -= get_speed());
        }
        // UP-RIGHT //
        public void move_upright()
        {
            position = new Point(position.X + (int)(get_speed() * 0.77), position.Y - (int)(get_speed() * 0.77));
        }
        // UP-LEFT //
        public void move_upleft()
        {
            position = new Point(position.X - (int)(get_speed() * 0.77), position.Y - (int)(get_speed() * 0.77));
        }
        // DOWN //
        public void move_down()
        {
            position = new Point(position.X, position.Y += get_speed());
        }
        // DOWN-RIGHT //
        public void move_downright()
        {
            position = new Point(position.X + (int)(get_speed() * 0.77), position.Y + (int)(get_speed() * 0.77));
        }
        // DOWN-LEFT //
        public void move_downleft()
        {
            position = new Point(position.X - (int)(get_speed() * 0.77), position.Y + (int)(get_speed() * 0.77));
        }
        // LEFT //
        public void move_left()
        {
            position = new Point(position.X -= get_speed(), position.Y);
        }
        // RIGHT //
        public void move_right()
        {
            position = new Point(position.X += get_speed(), position.Y);
        }

        //************************ANGLE************************//
        public void set_angle(int degrees)
        {
            angle = degrees;

            // UP //
            if (((angle >= 335) || (angle <= 25)))
            {
                direction = 0;
            }
            // UP-RIGHT //
            if ((angle >= 25) && (angle < 70))
            {
                direction = 1;
            }
            // RIGHT //
            if ((angle >= 70) && (angle < 115))
            {
                direction = 2;
            }
            // DOWN-RIGHT //
            if ((angle >= 115) && (angle < 160))
            {
                direction = 3;
            }
            // DOWN //
            if ((angle >= 160) && (angle < 205))
            {
                direction = 4;
            }
            // DOWN-LEFT //
            if ((angle >= 205) && (angle < 250))
            {
                direction = 5;
            }
            // LEFT //
            if ((angle >= 250) && (angle < 295))
            {
                direction = 6;
            }
            // UP-LEFT //
            if ((angle >= 295) && (angle < 335))
            {
                direction = 7;
            }
        }

        //************************WEAPONS************************//

        // Change the weapon //
        public void change_weapon(byte weaponslot)
        {
            currentweapon = weaponslot;

            switch (weapons[currentweapon])
            {
                case "KNIFE":
                    {
                        currentweaponanimationnumber = 0;
                    }
                    break;

                case "BROADSWORD":
                    {
                        currentweaponanimationnumber = 0;
                    }
                    break;

                case "ABYSSWALKER - Legendary":
                    {
                        currentweaponanimationnumber = 0;
                    }
                    break;
            }
        }

        // Sets new weapons to slot //
        public void set_weapons(string newweapon)
        {
            for (int x = 0; x < weapons.Length; x++)
            {
                if (weapons[x] == "Empty")
                {
                    weapons[x] = newweapon;
                    break;
                }
                else
                {
                    if (x == weapons.Length - 1)
                    {
                        weapons[currentweapon] = newweapon;
                    }
                }
            }
        }

        //************************SOUND************************//

        // Sets volume //
        public void play_Sound(int soundposition, int volume)
        {
            uint newvolume = (ushort.MaxValue / 4) * (uint)volume;
            waveOutSetVolume(IntPtr.Zero, newvolume);
            meleeplayer_audio[soundposition].Play();
        }

        // Creates sound players //
        SoundPlayer[] meleeplayer_audio = new SoundPlayer[5];

        // Imports DLLs //
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("Winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
    }
}
