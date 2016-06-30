using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Console.WriteLine("Listening...");
        }

        bool IsPlanted = false;

        void OnNewGameState(GameState gs)
        {
            CTScoreLabel.Text = gs.Map.TeamCT.Score.ToString();
            TScoreLabel.Text = gs.Map.TeamT.Score.ToString();
            Console.WriteLine("writing...");

            if (!IsPlanted &&
               gs.Round.Phase == RoundPhase.Live &&
               gs.Round.Bomb == BombState.Planted &&
               gs.Previously.Round.Bomb == BombState.Undefined)
            {
                Console.WriteLine("Bomb has been planted.");
                IsPlanted = true;
            }
            else if (IsPlanted && gs.Round.Phase == RoundPhase.FreezeTime)
            {
                IsPlanted = false;
            }
        }
    }
}
