using AmericanTruckSimulatorTrainer.StylingFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmericanTruckSimulatorTrainer
{
    public partial class Trainer : Form
    {

        public Trainer()
        {
            InitializeComponent();

            Globals.gifImage = new GIF(Globals.gifPath);
            Globals.gifImage.ReverseAtEnd = false; //dont reverse at end
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            Thread ProcessThread = new Thread(new ThreadStart(UpdateGifThread));
            ProcessThread.Start();
        }

        public void UpdateGifThread()
        {
            while (true)
            {
                gif.Image = Globals.gifImage.GetNextFrame();
                Thread.Sleep(10000);
            }
        }

        private void gif_Click(object sender, EventArgs e)
        {

        }
    }
}
