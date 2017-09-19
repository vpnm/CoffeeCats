using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Fun
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region Onload
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region CatCrate_Picturebox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 1000 CC", "Buy a Cat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panel2.Visible = false;
                panel1.Visible = false;
                pictureBox1.Enabled = false;
                MessageBox.Show("Come back again for more cats!", "Purchase was successful");
                Form1.test = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 1000 CC", "Buy a Cat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panel2.Visible = false;
                panel3.Visible = false;
                pictureBox2.Enabled = false;
                MessageBox.Show("Come back again for more cats!", "Purchase was successful");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 1000 CC", "Buy a Cat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panel1.Visible = false;
                panel3.Visible = false;
                pictureBox3.Enabled = false;
                MessageBox.Show("Come back again for more cats!", "Purchase was successful");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion

        #region Back_Button
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        #endregion

        #region Coffee_Picturebox
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 1500 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 1500 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 1500 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion
    }
}
