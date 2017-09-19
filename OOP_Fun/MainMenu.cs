using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace OOP_Fun
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Load Game Button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.test = true;
            Form1.Show();
            this.Hide();
        }
        #endregion

        #region New Game Button
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.test2 = true;
            Form1.Show();
            this.Hide();
           
        }
        #endregion

        #region Sound Effect
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.get_away_from_me);
            player.Play();
        }
        #endregion

    }
}
