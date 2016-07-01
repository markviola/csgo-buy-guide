using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CSGSI;
using CSGSI.Nodes;

namespace csgo_round_helper
{
    public partial class RoundManager : Form
    {
        public RoundManager(GameStateListener gsl)
        {
            InitializeComponent();

            gsl = new GameStateListener(3000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
            if (!gsl.Start())
            {
                Environment.Exit(0);
            }
           
        }

        bool plantedThisRound = false;
        String userID = null;

        void OnNewGameState(GameState gs)
        {

            if(userID == null)
            {
                userID = gs.Player.SteamID;
                nameLabel.Text = gs.Player.Name;
            }


            if (!plantedThisRound && gs.Round.Phase == RoundPhase.Live &&
               gs.Round.Bomb == BombState.Planted && gs.Previously.Round.Bomb == BombState.Undefined)
            {
                Console.WriteLine("Bomb has been planted.");
                plantedThisRound = true;
            }

            // Update interface state when round ends
            if(gs.Round.Phase == RoundPhase.Over)
            {
                plantedThisRound = false;
                CTScoreLabel.Text = gs.Map.TeamCT.Score.ToString();
                TScoreLabel.Text = gs.Map.TeamT.Score.ToString();
            }

            // Check if the user is the player being observed
            if(userID == gs.Player.SteamID)
            {
                bool havePrimary = false, haveSecondary = false;
                List<WeaponNode> grenades = new List<WeaponNode>();
                for (int i = 0; i < gs.Player.Weapons.Count; i++)
                {
                    WeaponType weaponType = gs.Player.Weapons[i].Type;
                    if(weaponType == WeaponType.MachineGun || weaponType == WeaponType.Rifle || weaponType == WeaponType.Shotgun
                        || weaponType == WeaponType.SniperRifle || weaponType == WeaponType.SubmachineGun)
                    {
                        setPrimary(gs.Player.Weapons[i]);
                        havePrimary = true;
                    }
                    else if(weaponType == WeaponType.Pistol)
                    {
                        setSecondary(gs.Player.Weapons[i]);
                        haveSecondary = true;
                    }
                    else if(weaponType == WeaponType.Grenade)
                    {
                        grenades.Add(gs.Player.Weapons[i]);
                        setGrenades(grenades);
                    }
                }
                clearWeapons(havePrimary, haveSecondary);
            }
           
        }

        // Set the image of the primary weapon that the player owns
        void setPrimary(WeaponNode primary)
        {
            String name = primary.Name;
            String picPath = System.AppDomain.CurrentDomain.BaseDirectory + "imgs/" + name + ".png";
            if(File.Exists(picPath))
            {
                primaryPicBox.Image = Image.FromFile(picPath);
                Char.ToUpper(name[7]);
                primaryLabel.Text = name.Substring(7);
                
            }
        }

        // Set the image of the secondary weapon that the player owns
        void setSecondary(WeaponNode secondary)
        {
            String name = secondary.Name;
            String picPath = System.AppDomain.CurrentDomain.BaseDirectory + "imgs/" + name + ".png";
            if (File.Exists(picPath))
            {
                secondaryPicBox.Image = Image.FromFile(picPath);
                Char.ToUpper(name[7]);
                secondaryLabel.Text = name.Substring(7);
            }
        }

        // Set the images for the grenades the player owns
        void setGrenades(List<WeaponNode> grenades)
        {
            List<PictureBox> grenadePicBoxes = new List<PictureBox>();
            grenadePicBoxes.Add(nadePicBox1);
            grenadePicBoxes.Add(nadePicBox2);
            grenadePicBoxes.Add(nadePicBox3);
            grenadePicBoxes.Add(nadePicBox4);

            for (int i = 0; i < 4; i++)
            {
                if(i < grenades.Count)
                {
                    String picPath = System.AppDomain.CurrentDomain.BaseDirectory + "imgs/" +
                    grenades.ElementAt(i).Name + ".png";
                    if (File.Exists(picPath))
                    {
                        grenadePicBoxes.ElementAt(i).Image = Image.FromFile(picPath);
                    }
                }
                else
                {
                    grenadePicBoxes.ElementAt(i).Image = null;
                }
            }
        }

        // Empty the PictureBox if the player doesn't own the corresponding weapon
        void clearWeapons(bool havePrimary, bool haveSecondary)
        {
            if(!havePrimary)
            {
                primaryPicBox.Image = null;
            }

            if (!haveSecondary)
            {
                secondaryPicBox.Image = null;
            }
        }

    }

}


