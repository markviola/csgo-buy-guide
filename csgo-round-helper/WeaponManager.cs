using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgo_round_helper
{
    class WeaponManager
    {
        private static WeaponManager instance;
        private List<Weapon> Weapons;

        public WeaponManager()
        {
            Weapons = new List<Weapon>();

            // Add all weapons
            addWeapon(new Weapon("P250", "Pistol", 300));
            addWeapon(new Weapon("Dual Berettas", "Pistol", 500));
            addWeapon(new Weapon("Tec-9", "Pistol", 500));
            addWeapon(new Weapon("Five-Seven", "Pistol", 500));
            addWeapon(new Weapon("CZ75", "Pistol", 500));
            addWeapon(new Weapon("Desert Eagle", "Pistol", 700));

            addWeapon(new Weapon("Nova", "Shotgun", 1200));
            addWeapon(new Weapon("Sawed-off", "Shotgun", 1200));
            addWeapon(new Weapon("MAG-7", "Shotgun", 1800));
            addWeapon(new Weapon("XM1014", "Shotgun", 2000));

            addWeapon(new Weapon("MAC-10", "Submachine Gun", 1050));
            addWeapon(new Weapon("UMP-45", "Submachine Gun", 1200));
            addWeapon(new Weapon("MP9", "Submachine Gun", 1250));
            addWeapon(new Weapon("PP-Bizon", "Submachine Gun", 1400));
            addWeapon(new Weapon("MP7", "Submachine Gun", 1700));
            addWeapon(new Weapon("P90", "Submachine Gun", 2350));

            addWeapon(new Weapon("Galil AR", "Rifle", 2000));
            addWeapon(new Weapon("FAMAS", "Rifle", 2250));
            addWeapon(new Weapon("AK-47", "Rifle", 2700));
            addWeapon(new Weapon("SG 553", "Rifle", 3000));
            addWeapon(new Weapon("M4A4-S", "Rifle", 3100));
            addWeapon(new Weapon("M4A4", "Rifle", 3100));
            addWeapon(new Weapon("AUG", "Rifle", 3300));

            addWeapon(new Weapon("M249", "Heavy", 5200));
            addWeapon(new Weapon("Negev", "Heavy", 5700));

            addWeapon(new Weapon("SSG 08", "Sniper Rifle", 1700));
            addWeapon(new Weapon("AWP", "Sniper Rifle", 4750));
            addWeapon(new Weapon("G3SG1", "Sniper Rifle", 5000));
            addWeapon(new Weapon("SCAR-20", "Sniper Rifle", 5000));
        }

        public static WeaponManager getInstance()
        {
            if(instance == null)
            {
                instance = new WeaponManager();
            }
            return instance;
        }

        public void addWeapon(Weapon newWeapon)
        {
            Weapons.Add(newWeapon);
        }

        // Return a list of all weapons with the type, pistol
        public List<Weapon> getPistols()
        {
            List<Weapon> pistols = new List<Weapon>();
            for(int i =0; i < Weapons.Count; i++)
            {
                if(Weapons.ElementAt(i).getType() == "Pistol")
                {
                    pistols.Add(Weapons.ElementAt(i));
                }
            }
            return pistols;
        }

        // Return a list of all weapons with the type, submachine guns
        public List<Weapon> getSubmachines()
        {
            List<Weapon> submachines = new List<Weapon>();
            for (int i = 0; i < Weapons.Count; i++)
            {
                if (Weapons.ElementAt(i).getType() == "Submachine Gun")
                {
                    submachines.Add(Weapons.ElementAt(i));
                }
            }
            return submachines;
        }

        // Return a list of all weapons with the type, rifle
        public List<Weapon> getRifles()
        {
            List<Weapon> rifles = new List<Weapon>();
            for (int i = 0; i < Weapons.Count; i++)
            {
                if (Weapons.ElementAt(i).getType() == "Rifle")
                {
                    rifles.Add(Weapons.ElementAt(i));
                }
            }
            return rifles;
        }

        // Return a list of all weapons with the type, heavy
        public List<Weapon> getHeavys()
        {
            List<Weapon> heavys = new List<Weapon>();
            for (int i = 0; i < Weapons.Count; i++)
            {
                if (Weapons.ElementAt(i).getType() == "Heavy")
                {
                    heavys.Add(Weapons.ElementAt(i));
                }
            }
            return heavys;
        }

        // Return a list of all weapons with the type, heavy
        public List<Weapon> getSnipers()
        {
            List<Weapon> snipers = new List<Weapon>();
            for (int i = 0; i < Weapons.Count; i++)
            {
                if (Weapons.ElementAt(i).getType() == "Sniper Rifle")
                {
                    snipers.Add(Weapons.ElementAt(i));
                }
            }
            return snipers;
        }
    }
}
