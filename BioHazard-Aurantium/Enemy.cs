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
    class Enemy
    {
        //************************VARIABLES************************//

        //Animation & Direction//
        Point position;
        int angle;
        int direction;
        int animation;
        int frame;

        //Zombie attributes//
        int speed;
        int health;

        int damagedealt;
        int expvalue;

        //************************INITIALIZATION************************//

        public void Initialise(int zombietype, Point spawnlocation)
        {
            //Position & Direction//
            position = spawnlocation;
            direction = 0;

            //Type of Zombies//
            switch (zombietype)
            {

                //**********EASY**********//

                // Civilian //
                case 0:
                    {

                        health = 0;
                        speed = 0;
                        damagedealt = 0;
                        expvalue = 0;

                        enemy_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[1] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[2] = new SoundPlayer(Properties.Resources.DeathSound);
                    }
                    break;

                // Dog //
                case 1:
                    {
                        health = 0;
                        speed = 0;
                        damagedealt = 0;
                        expvalue = 0;

                        enemy_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[1] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[2] = new SoundPlayer(Properties.Resources.DeathSound);
                    }
                    break;

                //**********MEDIUM**********//

                // Military // 
                case 2:
                    {
                        health = 0;
                        speed = 0;
                        damagedealt = 0;
                        expvalue = 0;

                        enemy_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[1] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[2] = new SoundPlayer(Properties.Resources.DeathSound);
                    }
                    break;


                case 3:
                    {
                        health = 0;
                        speed = 0;
                        damagedealt = 0;
                        expvalue = 0;

                        enemy_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[1] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[2] = new SoundPlayer(Properties.Resources.DeathSound);
                    }
                    break;

                //**********HARD**********//

                // Abomination //
                case 4:
                    {
                        health = 0;
                        speed = 0;
                        damagedealt = 0;
                        expvalue = 0;

                        enemy_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[1] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[2] = new SoundPlayer(Properties.Resources.DeathSound);
                    }
                    break;

                // Necromancer //
                case 5:
                    {
                        health = 0;
                        speed = 0;
                        damagedealt = 0;
                        expvalue = 0;

                        enemy_audio[0] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[1] = new SoundPlayer(Properties.Resources.DeathSound);
                        enemy_audio[3] = new SoundPlayer(Properties.Resources.DeathSound);
                    }
                    break;

            }

            // Images path //
            string imagepath = "images/enemy/";

            for (int setnumber = 0; setnumber < 6; setnumber++)
            {
                for (int animationnumber = 0; animationnumber < 8; animationnumber++)
                {
                    animations[(6 * setnumber) + animationnumber].frames = new List<Bitmap>();
                    int imagecount = Directory.GetFiles(imagepath + setnumber + "/" + animationnumber + "/", ".png", SearchOption.AllDirectories).Length;
                    for (int framenumber = 0; framenumber < imagecount; framenumber++)
                    {
                        //Loads the image //
                        animations[(10 * setnumber) + animationnumber].frames.Add(new Bitmap(imagepath + setnumber + "/" + animationnumber + "/" + framenumber + ".png"));
                    }
                }
            }

        }


        //************************ANIMATION************************//

        //Total amount of images //
        struct animation_frames
        {
            public List<Bitmap> frames;
        }

        // 8 Directions, 3 Animations(Attack, Getting hit,Die) //
        animation_frames[] animations = new animation_frames[48];

        // Gets current graphic //
        public Bitmap get_currentgraphic()
        {
            return animations[(3 * direction) + animation].frames[frame];
        }

        // Changes the image //
        public void change_animation(int animationnumber)
        {
            animation = animationnumber;
        }

        // Plays the animation //
        public void play_animation()
        {
            if (frame < animations[(3 * direction) + animation].frames.Count)
            {
                frame++;
            }
            else
            {
                if (animation == 0)
                {
                    frame = 0;
                }
                else
                {
                    if (animation == 1)
                    {
                        change_animation(0);
                    }
                    else
                    {
                        //Zombie is Dead//
                    }
                }
            }
        }

        //************************ZOMBIE ATTRIBUTES************************//

        // Reduces zombies health //
        public void reduce_Health(int amount)
        {
            health -= amount;
        }

        // How much damage zombie deals //
        public int get_damagedealt()
        {
            return damagedealt;
        }

        // How much exp zombie rewards //
        public int get_expvalue()
        {
            return expvalue;
        }

        //************************POSITION&DIRECTION************************//
        
        // Gets position //
        public Point get_position()
        {
            return position;
        }

        // Gets necromanced position //
        public Point get_necromanced()
        {
            return position;
        }

        // Gets direction //
        public int get_direction()
        {
            return direction;
        }

        // Sets direction
        public void set_direction(int newdirection)
        {
            direction = newdirection;
        }

        //************************MOVEMENT************************//

        public void move_forward()
        {
            switch (direction)
            {
                    // UP //
                case 0:
                    {
                        position = new Point(position.X, position.Y - speed);
                    }
                break;
                    // UP-RIGHT //
                case 1:
                {
                    position = new Point(position.X + (int)(speed * 0.75), position.Y - (int)(speed * 0.75));
                }
                break;
                    // RIGHT //
                case 2:
                {
                    position = new Point(position.X + speed, position.Y);
                }
                break;
                    // DOWN-RIGHT //
                case 3:
                {
                    position = new Point(position.X + (int)(speed * 0.75), position.Y + (int)(speed * 0.75));
                }
                break;
                    // DOWN //
                case 4:
                {
                    position = new Point(position.X, position.Y + speed);
                }
                break;
                    // DOWN-LEFT //
                case 5:
                {
                    position = new Point(position.X - (int)(speed * 0.75), position.Y + (int)(speed * 0.75));
                }
                break;
                    // LEFT //
                case 6:
                {
                    position = new Point(position.X - speed, position.Y);
                }
                break;
                    // UP-LEFT //
                case 7:
                {
                    position = new Point(position.X - (int)(speed * 0.75), position.Y - (int)(speed * 0.75));

                }
                break;

            }
        }

        //************************SOUND************************//

        //0 - Moan
        //1 - Attack
        //2 - Move
        //3 - Necromance

        // Creates the sound players //
        SoundPlayer[] enemy_audio = new SoundPlayer[4];

        // Sets volume //
        public void play_sound(int soundposition, int volume)
        {
            uint newvolume = (ushort.MaxValue / 4) * (uint)volume;
            waveOutSetVolume(IntPtr.Zero, newvolume);
            enemy_audio[soundposition].Play();
        }

        // Imports importand DLLs //
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("Winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);


    }
}
