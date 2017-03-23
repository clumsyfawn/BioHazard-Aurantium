using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace BioHazard_Aurantium
{
    class Weapon
    {
        //************************VARIABLES************************//

        int damagedealt;

        int ammo;
        int currentammo;
        int clipsize;

        int reloadtime;
        int firerate;

        string weapontype;
        bool melee;

        SoundPlayer firing;

        //************************INITIALIZATION************************//
        public void Initialise(string newweapontype)
        {
            weapontype = newweapontype;

            switch (weapontype)
            {
                case "FIVESEVEN":
                    {
                        // Attributes //
                        int damagedealt = 25;
                        int ammo = 100;
                        int currentammo = 20;
                        int clipsize = 20;
                        int reloadtime = 2000;
                        int firerate = 333;

                        melee = false;
                    }
                    break;

                case "KNIFE":
                    {
                        // Attributes //
                        int damagedealt = 50;
                        int firerate = 500;
                        melee = true;
                    }
                    break;
            }
        }
    }
}
