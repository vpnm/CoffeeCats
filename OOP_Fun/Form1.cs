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
using System.Xml.Serialization;
using System.Media;

namespace OOP_Fun
{
    public partial class Form1 : Form
    {
        #region Form
        public Form1()
        {
            InitializeComponent();
            CatOne = OOP_Fun.Properties.Resources.HappyCat1;
            CatOne2 = OOP_Fun.Properties.Resources.HappyCat2;
            CatOne3 = OOP_Fun.Properties.Resources.HappyCat3;
            CatOne4 = OOP_Fun.Properties.Resources.HappyCat4;
            CatOne5 = OOP_Fun.Properties.Resources.HappyCat5;
            CatOne6 = OOP_Fun.Properties.Resources.HappyCat6;
            CatOne7 = OOP_Fun.Properties.Resources.HappyCat7;
            CatOne8 = OOP_Fun.Properties.Resources.HappyCat8;
            CatOne9 = OOP_Fun.Properties.Resources.HappyCat9;
            CatOne10 = OOP_Fun.Properties.Resources.HappyCat10;
            Wood = OOP_Fun.Properties.Resources.woodencrate;
            FullBowl = OOP_Fun.Properties.Resources.full_food_bowl;
            EmptyBowl = OOP_Fun.Properties.Resources.cats_bowl;
            pictureBox17.MouseDown += pictureBox17_MouseDown;
            pictureBox18.MouseDown += pictureBox18_MouseDown;
            pictureBox19.MouseDown += pictureBox19_MouseDown;
            pictureBox20.AllowDrop = true;
            pictureBox20.DragEnter += pictureBox20_DragEnter;
            pictureBox20.DragDrop += pictureBox20_DragDrop;
        }
        #endregion

        #region Values
        static string rootLocation = typeof(Program).Assembly.Location;
        static string fullPathToSound = Path.Combine(rootLocation, @"Sounds\cash_register_x.wav");
        static string fullPathToSound2 = Path.Combine(rootLocation, @"Sounds\CatsEating.wav");
        static string fullPathToSound3 = Path.Combine(rootLocation, @"Sounds\SoundBowlFilling.wav");
        int index1 = fullPathToSound.IndexOf(@"\OOP_Fun.exe");
        int index2 = fullPathToSound2.IndexOf(@"\OOP_Fun.exe");
        int index3 = fullPathToSound3.IndexOf(@"\OOP_Fun.exe");
        public static bool test = false;
        public static bool test2 = false;
        public static bool loaded = false;
        public static bool text = false;
        public static bool text2 = false;
        public static bool text3 = false;
        public static bool switchP = false;
        public static bool LQon = false;
        public static bool MQon = false;
        public static bool HQon = false;
        public static bool FoodInBowl = false;
        public static bool Working = false;
        public static bool ButtonOn = true;
        public static bool ButtonOn2 = true;
        public static bool ButtonOn3 = true;
        public static bool CatLimit = true;
        public static bool CatLimit2 = true;
        string result3; //Cash Register 
        string result4; //Cats Eating 
        string result5; //Bowl Filling
        string S2 = "Default.xml";
        private Image CatOne;
        private Image CatOne2;
        private Image CatOne3;
        private Image CatOne4;
        private Image CatOne5;
        private Image CatOne6;
        private Image CatOne7;
        private Image CatOne8;
        private Image CatOne9;
        private Image CatOne10;
        private Image Wood;
        private Image FullBowl;
        private Image EmptyBowl;
        private int MoneyM = 10000;
        private int CatsC;
        private int LQC = 50;
        private int MQC;
        private int HQC;
        private int TotalCoffee;
        private int LQPoo;
        private int MQPoo;
        private int HQPoo;
        private int Poo;
        private int counter;
        private int ApartmentLevel = 1;
        private int CatCount;
        #endregion

        #region On Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Cash Register Sound
            if (index1 != -1)
            {
                result3 = fullPathToSound.Remove(index1) + @"\Sounds\cash_register_x.wav";
            }
            else
            {
                MessageBox.Show("Error Try Again Nicholas!!!!");
            }
            #endregion

            #region Cats Eating Sound 
            if (index2 != -1)
            {
                result4 = fullPathToSound2.Remove(index2) + @"\Sounds\CatsEating.wav";
            }
            else
            {
                MessageBox.Show("Error Try Again Nicholas!!!!");
            }
            #endregion

            #region Bowl Filling Sound 
            if (index3 != -1)
            {
                result5 = fullPathToSound3.Remove(index3) + @"\Sounds\SoundBowlFilling.wav";
            }
            else
            {
                MessageBox.Show("Error Try Again Nicholas!!!!");
            }
            #endregion

            #region LoadingSave       
            if (test == true)
            {
                if (File.Exists("data.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Information));
                    FileStream read = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Information info = (Information)xs.Deserialize(read);
                    label18.Text = info.catName;
                    label16.Text = info.catName2;
                    label3.Text = info.catName3;
                    label8.Text = info.catName4;
                    label10.Text = info.catName5;
                    label2.Text = info.catName6;
                    label12.Text = info.catName7;
                    label11.Text = info.catName8;
                    label19.Text = info.catName9;
                    label20.Text = info.catName10;
                    MoneyM = info.money;
                    CatsC = info.cats;
                    LQC = info.lQCoffee;
                    MQC = info.mQCoffee;
                    HQC = info.hQCoffee;
                    LQPoo = info.lQPoo;
                    MQPoo = info.mQPoo;
                    HQPoo = info.hQPoo;
                    ApartmentLevel = info.apartmentLV;

                    #region LoadP1
                    if (info.pic == "1")
                    {
                        pictureBox1.Image = CatOne;
                    }
                    else if (info.pic == "2")
                    {
                        pictureBox1.Image = CatOne2;
                    }
                    else if (info.pic == "3")
                    {
                        pictureBox1.Image = CatOne3;
                    }
                    else if (info.pic == "4")
                    {
                        pictureBox1.Image = CatOne4;
                    }
                    else if (info.pic == "5")
                    {
                        pictureBox1.Image = CatOne5;
                    }
                    else if (info.pic == "6")
                    {
                        pictureBox1.Image = CatOne6;
                    }
                    else if (info.pic == "7")
                    {
                        pictureBox1.Image = CatOne7;
                    }
                    else if (info.pic == "8")
                    {
                        pictureBox1.Image = CatOne8;
                    }
                    else if (info.pic == "9")
                    {
                        pictureBox1.Image = CatOne9;
                    }
                    else if (info.pic == "10")
                    {
                        pictureBox1.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP2
                    if (info.pic2 == "1")
                    {
                        pictureBox2.Image = CatOne;
                    }
                    else if (info.pic2 == "2")
                    {
                        pictureBox2.Image = CatOne2;
                    }
                    else if (info.pic2 == "3")
                    {
                        pictureBox2.Image = CatOne3;
                    }
                    else if (info.pic2 == "4")
                    {
                        pictureBox2.Image = CatOne4;
                    }
                    else if (info.pic2 == "5")
                    {
                        pictureBox2.Image = CatOne5;
                    }
                    else if (info.pic2 == "6")
                    {
                        pictureBox2.Image = CatOne6;
                    }
                    else if (info.pic2 == "7")
                    {
                        pictureBox2.Image = CatOne7;
                    }
                    else if (info.pic2 == "8")
                    {
                        pictureBox2.Image = CatOne8;
                    }
                    else if (info.pic2 == "9")
                    {
                        pictureBox2.Image = CatOne9;
                    }
                    else if (info.pic2 == "10")
                    {
                        pictureBox2.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP3
                    if (info.pic3 == "1")
                    {
                        pictureBox3.Image = CatOne;
                    }
                    else if (info.pic3 == "2")
                    {
                        pictureBox3.Image = CatOne2;
                    }
                    else if (info.pic3 == "3")
                    {
                        pictureBox3.Image = CatOne3;
                    }
                    else if (info.pic3 == "4")
                    {
                        pictureBox3.Image = CatOne4;
                    }
                    else if (info.pic3 == "5")
                    {
                        pictureBox3.Image = CatOne5;
                    }
                    else if (info.pic3 == "6")
                    {
                        pictureBox3.Image = CatOne6;
                    }
                    else if (info.pic3 == "7")
                    {
                        pictureBox3.Image = CatOne7;
                    }
                    else if (info.pic3 == "8")
                    {
                        pictureBox3.Image = CatOne8;
                    }
                    else if (info.pic3 == "9")
                    {
                        pictureBox3.Image = CatOne9;
                    }
                    else if (info.pic3 == "10")
                    {
                        pictureBox3.Image = CatOne10;
                    }
                    #endregion

                    #region loadP4
                    if (info.pic4 == "1")
                    {
                        pictureBox4.Image = CatOne;
                    }
                    else if (info.pic4 == "2")
                    {
                        pictureBox4.Image = CatOne2;
                    }
                    else if (info.pic4 == "3")
                    {
                        pictureBox4.Image = CatOne3;
                    }
                    else if (info.pic4 == "4")
                    {
                        pictureBox4.Image = CatOne4;
                    }
                    else if (info.pic4 == "5")
                    {
                        pictureBox4.Image = CatOne5;
                    }
                    else if (info.pic4 == "6")
                    {
                        pictureBox4.Image = CatOne6;
                    }
                    else if (info.pic4 == "7")
                    {
                        pictureBox4.Image = CatOne7;
                    }
                    else if (info.pic4 == "8")
                    {
                        pictureBox4.Image = CatOne8;
                    }
                    else if (info.pic4 == "9")
                    {
                        pictureBox4.Image = CatOne9;
                    }
                    else if (info.pic4 == "10")
                    {
                        pictureBox4.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP5
                    if (info.pic5 == "1")
                    {
                        pictureBox5.Image = CatOne;
                    }
                    else if (info.pic5 == "2")
                    {
                        pictureBox5.Image = CatOne2;
                    }
                    else if (info.pic5 == "3")
                    {
                        pictureBox5.Image = CatOne3;
                    }
                    else if (info.pic5 == "4")
                    {
                        pictureBox5.Image = CatOne4;
                    }
                    else if (info.pic5 == "5")
                    {
                        pictureBox5.Image = CatOne5;
                    }
                    else if (info.pic5 == "6")
                    {
                        pictureBox5.Image = CatOne6;
                    }
                    else if (info.pic5 == "7")
                    {
                        pictureBox5.Image = CatOne7;
                    }
                    else if (info.pic5 == "8")
                    {
                        pictureBox5.Image = CatOne8;
                    }
                    else if (info.pic5 == "9")
                    {
                        pictureBox5.Image = CatOne9;
                    }
                    else if (info.pic5 == "10")
                    {
                        pictureBox5.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP6
                    if (info.pic6 == "1")
                    {
                        pictureBox5.Image = CatOne;
                    }
                    else if (info.pic6 == "2")
                    {
                        pictureBox6.Image = CatOne2;
                    }
                    else if (info.pic6 == "3")
                    {
                        pictureBox6.Image = CatOne3;
                    }
                    else if (info.pic6 == "4")
                    {
                        pictureBox6.Image = CatOne4;
                    }
                    else if (info.pic6 == "5")
                    {
                        pictureBox6.Image = CatOne5;
                    }
                    else if (info.pic6 == "6")
                    {
                        pictureBox6.Image = CatOne6;
                    }
                    else if (info.pic6 == "7")
                    {
                        pictureBox6.Image = CatOne7;
                    }
                    else if (info.pic6 == "8")
                    {
                        pictureBox6.Image = CatOne8;
                    }
                    else if (info.pic6 == "9")
                    {
                        pictureBox6.Image = CatOne9;
                    }
                    else if (info.pic6 == "10")
                    {
                        pictureBox6.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP7
                    if (info.pic7 == "1")
                    {
                        pictureBox7.Image = CatOne;
                    }
                    else if (info.pic7 == "2")
                    {
                        pictureBox7.Image = CatOne2;
                    }
                    else if (info.pic7 == "3")
                    {
                        pictureBox7.Image = CatOne3;
                    }
                    else if (info.pic7 == "4")
                    {
                        pictureBox7.Image = CatOne4;
                    }
                    else if (info.pic7 == "5")
                    {
                        pictureBox7.Image = CatOne5;
                    }
                    else if (info.pic7 == "6")
                    {
                        pictureBox7.Image = CatOne6;
                    }
                    else if (info.pic7 == "7")
                    {
                        pictureBox7.Image = CatOne7;
                    }
                    else if (info.pic7 == "8")
                    {
                        pictureBox7.Image = CatOne8;
                    }
                    else if (info.pic7 == "9")
                    {
                        pictureBox7.Image = CatOne9;
                    }
                    else if (info.pic7 == "10")
                    {
                        pictureBox7.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP8
                    if (info.pic8 == "1")
                    {
                        pictureBox8.Image = CatOne;
                    }
                    else if (info.pic8 == "2")
                    {
                        pictureBox8.Image = CatOne2;
                    }
                    else if (info.pic8 == "3")
                    {
                        pictureBox8.Image = CatOne3;
                    }
                    else if (info.pic8 == "4")
                    {
                        pictureBox8.Image = CatOne4;
                    }
                    else if (info.pic8 == "5")
                    {
                        pictureBox8.Image = CatOne5;
                    }
                    else if (info.pic8 == "6")
                    {
                        pictureBox8.Image = CatOne6;
                    }
                    else if (info.pic8 == "7")
                    {
                        pictureBox8.Image = CatOne7;
                    }
                    else if (info.pic8 == "8")
                    {
                        pictureBox8.Image = CatOne8;
                    }
                    else if (info.pic8 == "9")
                    {
                        pictureBox8.Image = CatOne9;
                    }
                    else if (info.pic8 == "10")
                    {
                        pictureBox8.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP9
                    if (info.pic9 == "1")
                    {
                        pictureBox9.Image = CatOne;
                    }
                    else if (info.pic9 == "2")
                    {
                        pictureBox9.Image = CatOne2;
                    }
                    else if (info.pic9 == "3")
                    {
                        pictureBox9.Image = CatOne3;
                    }
                    else if (info.pic9 == "4")
                    {
                        pictureBox9.Image = CatOne4;
                    }
                    else if (info.pic9 == "5")
                    {
                        pictureBox9.Image = CatOne5;
                    }
                    else if (info.pic9 == "6")
                    {
                        pictureBox9.Image = CatOne6;
                    }
                    else if (info.pic9 == "7")
                    {
                        pictureBox9.Image = CatOne7;
                    }
                    else if (info.pic9 == "8")
                    {
                        pictureBox9.Image = CatOne8;
                    }
                    else if (info.pic9 == "9")
                    {
                        pictureBox9.Image = CatOne9;
                    }
                    else if (info.pic9 == "10")
                    {
                        pictureBox9.Image = CatOne10;
                    }
                    #endregion

                    #region LoadP10
                    if (info.pic10 == "1")
                    {
                        pictureBox10.Image = CatOne;
                    }
                    else if (info.pic10 == "2")
                    {
                        pictureBox10.Image = CatOne2;
                    }
                    else if (info.pic10 == "3")
                    {
                        pictureBox10.Image = CatOne3;
                    }
                    else if (info.pic10 == "4")
                    {
                        pictureBox10.Image = CatOne4;
                    }
                    else if (info.pic10 == "5")
                    {
                        pictureBox10.Image = CatOne5;
                    }
                    else if (info.pic10 == "6")
                    {
                        pictureBox10.Image = CatOne6;
                    }
                    else if (info.pic10 == "7")
                    {
                        pictureBox10.Image = CatOne7;
                    }
                    else if (info.pic10 == "8")
                    {
                        pictureBox10.Image = CatOne8;
                    }
                    else if (info.pic10 == "9")
                    {
                        pictureBox10.Image = CatOne9;
                    }
                    else if (info.pic10 == "10")
                    {
                        pictureBox10.Image = CatOne10;
                    }
                    #endregion
                    read.Close();

                    timer1.Start();
                }
            }
            #endregion

            #region DefaultFile
            if (test2 == true)
            {
                if (File.Exists(S2))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Information));
                    FileStream read = new FileStream(S2, FileMode.Open, FileAccess.Read, FileShare.Read);
                    Information info = (Information)xs.Deserialize(read);
                    label18.Text = info.catName;
                    CatsC = info.cats;

                    #region LoadP1
                    if (info.pic == "1")
                    {
                        pictureBox1.Image = CatOne;
                    }
                    else if (info.pic == "2")
                    {
                        pictureBox1.Image = CatOne2;
                    }
                    else if (info.pic == "3")
                    {
                        pictureBox1.Image = CatOne3;
                    }
                    else if (info.pic == "4")
                    {
                        pictureBox1.Image = CatOne4;
                    }
                    else if (info.pic == "5")
                    {
                        pictureBox1.Image = CatOne5;
                    }
                    else if (info.pic == "6")
                    {
                        pictureBox1.Image = CatOne6;
                    }
                    else if (info.pic == "7")
                    {
                        pictureBox1.Image = CatOne7;
                    }
                    else if (info.pic == "8")
                    {
                        pictureBox1.Image = CatOne8;
                    }
                    else if (info.pic == "9")
                    {
                        pictureBox1.Image = CatOne9;
                    }
                    else if (info.pic == "10")
                    {
                        pictureBox1.Image = CatOne10;
                    }
            #endregion

            timer1.Start();
                }
            }
        }
        #endregion

        #endregion

        #region Panels
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Shopping Cart Button
        private void ShoppingCart_Click(object sender, EventArgs e)
        {
            if (switchP == false)
            {
               
                pictureBox12.Enabled = true;
                panel14.Visible = false;
                panel1.Visible = true;
                panel16.Visible = false;
                pictureBox20.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel7.Visible = true;
                panel15.Visible = true;
                ShoppingCart.Text = "Return";
                switchP = true;
            } else
            {
                button2_Click(sender, e);
                ShoppingCart.Text = "Shopping Cart";
                switchP = false;
                ButtonOn = true;
                ButtonOn2 = true;
                ButtonOn3 = true;

            }
           
           
            
        }
        #endregion

        #region Random Namen Function
        private void RefreshTiles()
        {
            int[] numbers = new int[10]
           {
              1, 2, 3, 4, 5, 6, 7, 8, 9, 0
           };

            Random rd = new Random();
            int randomIndex = rd.Next(0, 10);
            int randomNumber = numbers[randomIndex];

            if (randomNumber == 0)
            {
                label26.Text = "Toby";
                label21.Text = "Toby";
                label24.Text = "Toby";
                pictureBox13.Image = CatOne;
                pictureBox11.Image = CatOne;
                pictureBox12.Image = CatOne;
            }

            if (randomNumber == 1)
            {
                label26.Text = "Walter";
                label21.Text = "Walter";
                label24.Text = "Walter";
                pictureBox13.Image = CatOne2;
                pictureBox11.Image = CatOne2;
                pictureBox12.Image = CatOne2;
            }

            if (randomNumber == 2)
            {
                label26.Text = "Fauchi";
                label21.Text = "Fauchi";
                label24.Text = "Fauchi";
                pictureBox13.Image = CatOne3;
                pictureBox11.Image = CatOne3;
                pictureBox12.Image = CatOne3;
            }

            if (randomNumber == 3)
            {
                label26.Text = "Feebe";
                label21.Text = "Feebe";
                label24.Text = "Feebe";
                pictureBox13.Image = CatOne4;
                pictureBox11.Image = CatOne4;
                pictureBox12.Image = CatOne4;
            }

            if (randomNumber == 4)
            {
                label26.Text = "Muhhhm";
                label21.Text = "Muhhhm";
                label24.Text = "Muhhhm";
                pictureBox13.Image = CatOne5;
                pictureBox11.Image = CatOne5;
                pictureBox12.Image = CatOne5;
            }

            if (randomNumber == 5)
            {
                label26.Text = "skats";
                label21.Text = "skats";
                label24.Text = "skats";
                pictureBox13.Image = CatOne6;
                pictureBox11.Image = CatOne6;
                pictureBox12.Image = CatOne6;
            }

            if (randomNumber == 6)
            {
                label26.Text = "Kiruto";
                label21.Text = "Kiruto";
                label24.Text = "Kiruto";
                pictureBox13.Image = CatOne7;
                pictureBox11.Image = CatOne7;
                pictureBox12.Image = CatOne7;
            }

            if (randomNumber == 7)
            {
                label26.Text = "Sung";
                label21.Text = "Sung";
                label24.Text = "Sung";
                pictureBox13.Image = CatOne8;
                pictureBox11.Image = CatOne8;
                pictureBox12.Image = CatOne8;
            }

            if (randomNumber == 8)
            {
                label26.Text = "Sweetie";
                label21.Text = "Sweetie";
                label24.Text = "Sweetie";
                pictureBox13.Image = CatOne9;
                pictureBox11.Image = CatOne9;
                pictureBox12.Image = CatOne9;
            }

            if (randomNumber == 9)
            {
                label26.Text = "Jannik";
                label21.Text = "Jannik";
                label24.Text = "Jannik";
                pictureBox13.Image = CatOne10;
                pictureBox11.Image = CatOne10;
                pictureBox12.Image = CatOne10;
            }
        }
        #endregion

        #region On Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Information info = new Information();
                info.catName = label18.Text;
                info.catName2 = label16.Text;
                info.catName3 = label3.Text;
                info.catName4 = label8.Text;
                info.catName5 = label10.Text;
                info.catName6 = label2.Text;
                info.catName7 = label12.Text;
                info.catName8 = label11.Text;
                info.catName9 = label19.Text;
                info.catName10 = label20.Text;
                info.money = MoneyM;
                info.cats = CatsC;
                info.lQCoffee = LQC;
                info.mQCoffee = MQC;
                info.hQCoffee = HQC;
                info.lQPoo = LQPoo;
                info.mQPoo = MQPoo;
                info.hQPoo = HQPoo;
                info.apartmentLV = ApartmentLevel;
       
                #region Pic
                if (pictureBox1.Image == CatOne)
                {
                    info.pic = "1";
                } else if (pictureBox1.Image == CatOne2)
                {
                    info.pic = "2";
                } else if (pictureBox1.Image == CatOne3)
                {
                    info.pic = "3";
                } else if (pictureBox1.Image == CatOne4)
                {
                    info.pic = "4";
                }
                else if (pictureBox1.Image == CatOne5)
                {
                    info.pic = "5";
                }
                else if (pictureBox1.Image == CatOne6)
                {
                    info.pic = "6";
                }
                else if (pictureBox1.Image == CatOne7)
                {
                    info.pic = "7";
                }
                else if (pictureBox1.Image == CatOne8)
                {
                    info.pic = "8";
                }
                else if (pictureBox1.Image == CatOne9)
                {
                    info.pic = "9";
                }
                else if (pictureBox1.Image == CatOne10)
                {
                    info.pic = "10";
                }
                #endregion

                #region Pic Two
                if (pictureBox2.Image == CatOne)
                {
                    info.pic2 = "1";
                }
                else if (pictureBox2.Image == CatOne2)
                {
                    info.pic2 = "2";
                }
                else if (pictureBox2.Image == CatOne3)
                {
                    info.pic2 = "3";
                }
                else if (pictureBox2.Image == CatOne4)
                {
                    info.pic2 = "4";
                }
                else if (pictureBox2.Image == CatOne5)
                {
                    info.pic2 = "5";
                }
                else if (pictureBox2.Image == CatOne6)
                {
                    info.pic2 = "6";
                }
                else if (pictureBox2.Image == CatOne7)
                {
                    info.pic2 = "7";
                }
                else if (pictureBox2.Image == CatOne8)
                {
                    info.pic2 = "8";
                }
                else if (pictureBox2.Image == CatOne9)
                {
                    info.pic2 = "9";
                }
                else if (pictureBox2.Image == CatOne10)
                {
                    info.pic2 = "10";
                }
                #endregion

                #region Pic Three
                if (pictureBox3.Image == CatOne )
                {
                    info.pic3 = "1";
                }
                else if (pictureBox3.Image == CatOne2)
                {
                    info.pic3 = "2";
                }
                else if (pictureBox3.Image == CatOne3)
                {
                    info.pic3 = "3";
                }
                else if (pictureBox3.Image == CatOne4)
                {
                    info.pic3 = "4";
                }
                else if (pictureBox3.Image == CatOne5)
                {
                    info.pic3 = "5";
                }
                else if (pictureBox3.Image == CatOne6)
                {
                    info.pic3 = "6";
                }
                else if (pictureBox3.Image == CatOne7)
                {
                    info.pic3 = "7";
                }
                else if (pictureBox3.Image == CatOne8)
                {
                    info.pic3 = "8";
                }
                else if (pictureBox3.Image == CatOne9)
                {
                    info.pic3 = "9";
                }
                else if (pictureBox3.Image == CatOne10)
                {
                    info.pic3 = "10";
                }
                #endregion

                #region Pic Four
                if (pictureBox4.Image == CatOne)
                {
                    info.pic4 = "1";
                }
                else if (pictureBox4.Image == CatOne2)
                {
                    info.pic4 = "2";
                }
                else if (pictureBox4.Image == CatOne3)
                {
                    info.pic4 = "3";
                }
                else if (pictureBox4.Image == CatOne4)
                {
                    info.pic4 = "4";
                }
                else if (pictureBox4.Image == CatOne5)
                {
                    info.pic4 = "5";
                }
                else if (pictureBox4.Image == CatOne6)
                {
                    info.pic4 = "6";
                }
                else if (pictureBox4.Image == CatOne7)
                {
                    info.pic4 = "7";
                }
                else if (pictureBox4.Image == CatOne8)
                {
                    info.pic4 = "8";
                }
                else if (pictureBox4.Image == CatOne9)
                {
                    info.pic4 = "9";
                }
                else if (pictureBox4.Image == CatOne10)
                {
                    info.pic4 = "10";
                }
                #endregion

                #region Pic Five
                if (pictureBox5.Image == CatOne)
                {
                    info.pic5 = "1";
                }
                else if (pictureBox5.Image == CatOne2)
                {
                    info.pic5 = "2";
                }
                else if (pictureBox5.Image == CatOne3)
                {
                    info.pic5 = "3";
                }
                else if (pictureBox5.Image == CatOne4)
                {
                    info.pic5 = "4";
                }
                else if (pictureBox5.Image == CatOne5)
                {
                    info.pic5 = "5";
                }
                else if (pictureBox5.Image == CatOne6)
                {
                    info.pic5 = "6";
                }
                else if (pictureBox5.Image == CatOne7)
                {
                    info.pic5 = "7";
                }
                else if (pictureBox5.Image == CatOne8)
                {
                    info.pic5 = "8";
                }
                else if (pictureBox5.Image == CatOne9)
                {
                    info.pic5 = "9";
                }
                else if (pictureBox5.Image == CatOne10)
                {
                    info.pic5 = "10";
                }
                #endregion

                #region Pic Six
                if (pictureBox6.Image == CatOne)
                {
                    info.pic6 = "1";
                }
                else if (pictureBox6.Image == CatOne2)
                {
                    info.pic6 = "2";
                }
                else if (pictureBox6.Image == CatOne3)
                {
                    info.pic6 = "3";
                }
                else if (pictureBox6.Image == CatOne4)
                {
                    info.pic6 = "4";
                }
                else if (pictureBox6.Image == CatOne5)
                {
                    info.pic6 = "5";
                }
                else if (pictureBox6.Image == CatOne6)
                {
                    info.pic6 = "6";
                }
                else if (pictureBox6.Image == CatOne7)
                {
                    info.pic6 = "7";
                }
                else if (pictureBox6.Image == CatOne8)
                {
                    info.pic6 = "8";
                }
                else if (pictureBox6.Image == CatOne9)
                {
                    info.pic6 = "9";
                }
                else if (pictureBox6.Image == CatOne10)
                {
                    info.pic6 = "10";
                }
                #endregion

                #region Pic Seven
                if (pictureBox7.Image == CatOne)
                {
                    info.pic7 = "1";
                }
                else if (pictureBox7.Image == CatOne2)
                {
                    info.pic7 = "2";
                }
                else if (pictureBox7.Image == CatOne3)
                {
                    info.pic7 = "3";
                }
                else if (pictureBox7.Image == CatOne4)
                {
                    info.pic7 = "4";
                }
                else if (pictureBox7.Image == CatOne5)
                {
                    info.pic7 = "5";
                }
                else if (pictureBox7.Image == CatOne6)
                {
                    info.pic7 = "6";
                }
                else if (pictureBox7.Image == CatOne7)
                {
                    info.pic7 = "7";
                }
                else if (pictureBox7.Image == CatOne8)
                {
                    info.pic7 = "8";
                }
                else if (pictureBox7.Image == CatOne9)
                {
                    info.pic7 = "9";
                }
                else if (pictureBox7.Image == CatOne10)
                {
                    info.pic7 = "10";
                }
                #endregion

                #region Pic Eight
                if (pictureBox8.Image == CatOne)
                {
                    info.pic8 = "1";
                }
                else if (pictureBox8.Image == CatOne2)
                {
                    info.pic8 = "2";
                }
                else if (pictureBox8.Image == CatOne3)
                {
                    info.pic8 = "3";
                }
                else if (pictureBox8.Image == CatOne4)
                {
                    info.pic8 = "4";
                }
                else if (pictureBox8.Image == CatOne5)
                {
                    info.pic8 = "5";
                }
                else if (pictureBox8.Image == CatOne6)
                {
                    info.pic8 = "6";
                }
                else if (pictureBox8.Image == CatOne7)
                {
                    info.pic8 = "7";
                }
                else if (pictureBox8.Image == CatOne8)
                {
                    info.pic8 = "8";
                }
                else if (pictureBox8.Image == CatOne9)
                {
                    info.pic8 = "9";
                }
                else if (pictureBox8.Image == CatOne10)
                {
                    info.pic8 = "10";
                }
                #endregion

                #region Pic Nine
                if (pictureBox9.Image == CatOne)
                {
                    info.pic9 = "1";
                }
                else if (pictureBox9.Image == CatOne2)
                {
                    info.pic9 = "2";
                }
                else if (pictureBox9.Image == CatOne3)
                {
                    info.pic9 = "3";
                }
                else if (pictureBox9.Image == CatOne4)
                {
                    info.pic9 = "4";
                }
                else if (pictureBox9.Image == CatOne5)
                {
                    info.pic9 = "5";
                }
                else if (pictureBox9.Image == CatOne6)
                {
                    info.pic9 = "6";
                }
                else if (pictureBox9.Image == CatOne7)
                {
                    info.pic9 = "7";
                }
                else if (pictureBox9.Image == CatOne8)
                {
                    info.pic9 = "8";
                }
                else if (pictureBox9.Image == CatOne9)
                {
                    info.pic9 = "9";
                }
                else if (pictureBox9.Image == CatOne10)
                {
                    info.pic9 = "10";
                }
                #endregion

                #region Pic Ten
                if (pictureBox10.Image == CatOne)
                {
                    info.pic10 = "1";
                }
                else if (pictureBox10.Image == CatOne2)
                {
                    info.pic10 = "2";
                }
                else if (pictureBox10.Image == CatOne3)
                {
                    info.pic10 = "3";
                }
                else if (pictureBox10.Image == CatOne4)
                {
                    info.pic10 = "4";
                }
                else if (pictureBox10.Image == CatOne5)
                {
                    info.pic10 = "5";
                }
                else if (pictureBox10.Image == CatOne6)
                {
                    info.pic10 = "6";
                }
                else if (pictureBox10.Image == CatOne7)
                {
                    info.pic10 = "7";
                }
                else if (pictureBox10.Image == CatOne8)
                {
                    info.pic10 = "8";
                }
                else if (pictureBox10.Image == CatOne9)
                {
                    info.pic10 = "9";
                }
                else if (pictureBox10.Image == CatOne10)
                {
                    info.pic = "10";
                }
                #endregion

                SaveData.SaveXml(info, "data.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.Exit();


        }
        #endregion

        #region Back To Main Screen
        private void button2_Click(object sender, EventArgs e)
        {
            panel14.Visible = true;
            panel1.Visible = true;
            panel16.Visible = true;
            panel10.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel4.Visible = true;
            panel3.Visible = true;
            panel5.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;
            pictureBox20.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel11.Visible = false;
            panel15.Visible = false;
            if (text == true)
            {
                if (string.IsNullOrEmpty(label18.Text))
                {
                    label18.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox1.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label16.Text))
                {
                    label16.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox2.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label3.Text))
                {
                    label3.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox3.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label8.Text))
                {
                    label8.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox4.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label10.Text))
                {
                    label10.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox5.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label2.Text))
                {
                    label2.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox10.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label12.Text))
                {
                    label12.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox9.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label11.Text))
                {
                    label11.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox8.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label19.Text))
                {
                    label19.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox7.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
                else if (string.IsNullOrEmpty(label20.Text))
                {
                    label20.Text = label26.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox6.Image = pictureBox13.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text = false;
                }
            }

            if (text2 == true)
            {
                if (string.IsNullOrEmpty(label18.Text))
                {
                    label18.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox1.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label16.Text))
                {
                    label16.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox2.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label3.Text))
                {
                    label3.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox3.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label8.Text))
                {
                    label8.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox4.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label10.Text))
                {
                    label10.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox5.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label2.Text))
                {
                    label2.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox10.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label12.Text))
                {
                    label12.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox9.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label11.Text))
                {
                    label11.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox8.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label19.Text))
                {
                    label19.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox7.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
                else if (string.IsNullOrEmpty(label20.Text))
                {
                    label20.Text = label21.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox6.Image = pictureBox11.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text2 = false;
                }
            }

            if (text3 == true)
            {
                if (string.IsNullOrEmpty(label18.Text))
                {
                    label18.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox1.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label16.Text))
                {
                    label16.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox2.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label3.Text))
                {
                    label3.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox3.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label8.Text))
                {
                    label8.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox4.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label10.Text))
                {
                    label10.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox5.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label2.Text))
                {
                    label2.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox10.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label12.Text))
                {
                    label12.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox9.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label11.Text))
                {
                    label11.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox8.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label19.Text))
                {
                    label19.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox7.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
                else if (string.IsNullOrEmpty(label20.Text))
                {
                    label20.Text = label24.Text;
                    label26.Text = "Meow Meow";
                    label21.Text = "Purrrrrr";
                    label24.Text = "Hisssss";
                    pictureBox6.Image = pictureBox12.Image;
                    pictureBox13.Image = Wood;
                    pictureBox11.Image = Wood;
                    pictureBox12.Image = Wood;
                    text3 = false;
                }
            }
        }

        #endregion

        #region Buy Cat PictureBox
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (ButtonOn2 == true)
            {
                DialogResult dialogResult = MessageBox.Show("Cost 1000 CC", "Buy a Cat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (MoneyM >= 1000)
                    {
                        MoneyM = MoneyM - 1000;
                        CatsC = CatsC + 1;
                        if (string.IsNullOrEmpty(label18.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label16.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label3.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label8.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label10.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label2.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label12.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label11.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label19.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                        else if (string.IsNullOrEmpty(label20.Text))
                        {
                            RefreshTiles();
                            text = true;
                            panel8.Visible = false;
                            panel9.Visible = false;
                            ButtonOn2 = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough Cat Coins!");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                 //   MessageBox.Show("Come back anytime!");
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (ButtonOn3 == true)
            {
                DialogResult dialogResult = MessageBox.Show("Cost 1000 CC", "Buy a Cat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (MoneyM >= 1000)
                    {
                        MoneyM = MoneyM - 1000;
                        CatsC = CatsC + 1;
                        if (string.IsNullOrEmpty(label18.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label16.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label3.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label8.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label10.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label2.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label12.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label11.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label19.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                        else if (string.IsNullOrEmpty(label20.Text))
                        {
                            RefreshTiles();
                            text2 = true;
                            panel10.Visible = false;
                            panel9.Visible = false;
                            ButtonOn3 = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough Cat Coins!");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                //    MessageBox.Show("Come back anytime!");
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (ButtonOn == true)
            {
                DialogResult dialogResult = MessageBox.Show("Cost 1000 CC", "Buy a Cat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (MoneyM >= 1000)
                    {
                        MoneyM = MoneyM - 1000;
                        CatsC = CatsC + 1;
                        if (string.IsNullOrEmpty(label18.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label16.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label3.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label8.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label10.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label2.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label12.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label11.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label19.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                        else if (string.IsNullOrEmpty(label20.Text))
                        {
                            RefreshTiles();
                            text3 = true;
                            panel8.Visible = false;
                            panel10.Visible = false;
                            ButtonOn = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough Cat Coins!");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                  //  MessageBox.Show("Come back anytime!");
                }
            }
        }
        #endregion

        #region Buy Coffee PictureBox
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 10 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MoneyM >= 10)
                {
                    MoneyM = MoneyM - 10;
                    LQC = LQC + 10;
                } else
                {
                    MessageBox.Show("Not enough Cat Coins");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something els
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 20 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MoneyM >= 20)
                {
                    MoneyM = MoneyM - 20;
                    MQC = MQC + 10;
                }
                else
                {
                    MessageBox.Show("Not enough Cat Coins");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 30 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MoneyM >= 30)
                {
                    MoneyM = MoneyM - 30;
                    HQC = HQC + 10;
                }
                else
                {
                    MessageBox.Show("Not enough Cat Coins");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 100 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MoneyM >= 100)
                {
                    MoneyM = MoneyM - 100;
                    LQC = LQC + 100;
                }
                else
                {
                    MessageBox.Show("Not enough Cat Coins");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something els
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 200 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MoneyM >= 200)
                {
                    MoneyM = MoneyM - 200;
                    MQC = MQC + 100;
                }
                else
                {
                    MessageBox.Show("Not enough Cat Coins");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cost 300 CC", "Purchase Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MoneyM >= 300)
                {
                    MoneyM = MoneyM - 300;
                    HQC = HQC + 100;
                }
                else
                {
                    MessageBox.Show("Not enough Cat Coins");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        #endregion

        #region Edit Buttons
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label18.Text))
            {
                MessageBox.Show("No cat name present!");

            } else
            {
                if (textBox1.Visible == false)
                {
                    textBox1.Visible = true;
                    button13.Visible = true;
                }
                else
                {
                    textBox1.Visible = false;
                    button13.Visible = false;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label16.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox7.Visible == false)
                {
                    textBox7.Visible = true;
                    button14.Visible = true;
                }
                else
                {
                    textBox7.Visible = false;
                    button14.Visible = false;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label3.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox6.Visible == false)
                {
                    textBox6.Visible = true;
                    button15.Visible = true;
                }
                else
                {
                    textBox6.Visible = false;
                    button15.Visible = false;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label8.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox5.Visible == false)
                {
                    textBox5.Visible = true;
                    button16.Visible = true;
                }
                else
                {
                    textBox5.Visible = false;
                    button16.Visible = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label10.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox4.Visible == false)
                {
                    textBox4.Visible = true;
                    button17.Visible = true;
                }
                else
                {
                    textBox4.Visible = false;
                    button17.Visible = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label2.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox3.Visible == false)
                {
                    textBox3.Visible = true;
                    button18.Visible = true;
                }
                else
                {
                    textBox3.Visible = false;
                    button18.Visible = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label12.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox2.Visible == false)
                {
                    textBox2.Visible = true;
                    button19.Visible = true;
                }
                else
                {
                    textBox2.Visible = false;
                    button19.Visible = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label11.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox10.Visible == false)
                {
                    textBox10.Visible = true;
                    button20.Visible = true;
                }
                else
                {
                    textBox10.Visible = false;
                    button20.Visible = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label19.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox9.Visible == false)
                {
                    textBox9.Visible = true;
                    button21.Visible = true;
                }
                else
                {
                    textBox9.Visible = false;
                    button21.Visible = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label20.Text))
            {
                MessageBox.Show("No cat name present!");
            }
            else
            {
                if (textBox8.Visible == false)
                {
                    textBox8.Visible = true;
                    button22.Visible = true;
                }
                else
                {
                    textBox8.Visible = false;
                    button22.Visible = false;
                }
            }
        }

        #endregion

        #region Edit Save Buttons
        private void button13_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label18.Text = textBox1.Text;
                    button3_Click(sender, e);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox7.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label16.Text = textBox7.Text;
                    button12_Click(sender, e);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label3.Text = textBox6.Text;
                    button11_Click(sender, e);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label8.Text = textBox5.Text;
                    button10_Click(sender, e);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label10.Text = textBox4.Text;
                    button9_Click(sender, e);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label2.Text = textBox3.Text;
                    button8_Click(sender, e);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label12.Text = textBox2.Text;
                    button7_Click(sender, e);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox10.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label11.Text = textBox10.Text;
                    button6_Click(sender, e);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox9.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label19.Text = textBox9.Text;
                    button5_Click(sender, e);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (MoneyM >= 100)
            {
                if (string.IsNullOrEmpty(textBox8.Text))
                {
                    MessageBox.Show("No cat name present!");
                }
                else {
                    MoneyM = MoneyM - 100;
                    label20.Text = textBox8.Text;
                    button4_Click(sender, e);
                }
            }
        }

        #endregion

        #region On Form Closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CatOne.Dispose();
            CatOne2.Dispose();
            CatOne3.Dispose();
            CatOne4.Dispose();
            CatOne5.Dispose();
            CatOne6.Dispose();
            CatOne7.Dispose();
            CatOne8.Dispose();
            CatOne9.Dispose();
            CatOne10.Dispose();
        }
        #endregion

        #region Values Refresh
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCC.Text = MoneyM.ToString();
            labelCats.Text = CatsC.ToString();
            labelCoffeeLQ.Text = LQC.ToString();
            labelCoffeeMQ.Text = MQC.ToString();
            labelCoffeeHQ.Text = HQC.ToString();
            TotalCoffee = LQC + MQC + HQC;
            labelCoffeeTotal.Text = TotalCoffee.ToString();
            Poo = LQPoo + MQPoo + HQPoo;
            labelPooTotal.Text = Poo.ToString();
            labelApartmentSize.Text = ApartmentLevel.ToString();
            if (ApartmentLevel == 2)
            {
                label36.Text = "/ 10";
            }

            #region CatLimiter
            if (CatLimit == true)
            {
                if (ApartmentLevel == 1 && CatsC == 5)
                {
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    pictureBox13.Enabled = false;
                    CatLimit2 = false;
                }
                else
                {
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    pictureBox13.Enabled = true;
                    CatLimit2 = true;
                }
            }
            #endregion

            #region CatLimiter Two
            if (CatLimit2 == true)
            {
                if (CatsC == 10)
                {
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    pictureBox13.Enabled = false;
                    CatLimit = false;
                }
                else
                {
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    pictureBox13.Enabled = true;
                }
            }
            #endregion

            #region SellCatLoopFix
            if (string.IsNullOrEmpty(label18.Text))
            {
                button3.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                checkBox1.Enabled = true;
            }

            if (string.IsNullOrEmpty(label16.Text))
            {
                button12.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {
                button12.Enabled = true;
                checkBox2.Enabled = true;
            }

            if (string.IsNullOrEmpty(label3.Text))
            {
                button11.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                button11.Enabled = true;
                checkBox3.Enabled = true;
            }

            if (string.IsNullOrEmpty(label8.Text))
            {
                button10.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                button10.Enabled = true;
                checkBox4.Enabled = true;
            }

            if (string.IsNullOrEmpty(label10.Text))
            {
                button9.Enabled = false;
                checkBox5.Enabled = false;
            }
            else
            {
                button9.Enabled = true;
                checkBox5.Enabled = true;
            }

            if (string.IsNullOrEmpty(label2.Text))
            {
                button8.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                button8.Enabled = true;
                checkBox6.Enabled = true;
            }

            if (string.IsNullOrEmpty(label12.Text))
            {
                button7.Enabled = false;
                checkBox7.Enabled = false;
            }
            else
            {
                button7.Enabled = true;
                checkBox7.Enabled = true;
            }

            if (string.IsNullOrEmpty(label11.Text))
            {
                button6.Enabled = false;
                checkBox8.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                checkBox8.Enabled = true;
            }

            if (string.IsNullOrEmpty(label19.Text))
            {
                button5.Enabled = false;
                checkBox9.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
                checkBox9.Enabled = true;
            }

            if (string.IsNullOrEmpty(label20.Text))
            {
                button4.Enabled = false;
                checkBox10.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
                checkBox10.Enabled = true;
            }


            #endregion

        }
            #endregion

        #region Sell Cats Button
        private void button23_Click(object sender, EventArgs e)
        {

            if (CatsC > 1)
            {
                if (checkBox1.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label18.Text))
                        {
                            MessageBox.Show("Can't sell what you don't have!");
                            checkBox1.Checked = false;
                            CatCount = 0;
                        }
                        else
                        {
                            MessageBox.Show("You are a terrible person!");
                            MoneyM = MoneyM + 500;
                            checkBox1.Checked = false;
                            label18.Text = "";
                            pictureBox1.Image = Wood;
                            CatsC = CatsC - 1;
                            textBox1.Visible = false;
                            button13.Visible = false;
                            CatCount = 0;
                        }
                    } else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

             

                if (checkBox2.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label16.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox2.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox2.Checked = false;
                        label16.Text = "";
                        pictureBox2.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox7.Visible = false;
                        button14.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox3.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label3.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox3.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox3.Checked = false;
                        label3.Text = "";
                        pictureBox3.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox6.Visible = false;
                        button15.Visible = false;
                        CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox4.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label8.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox4.Checked = false;
                        CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox4.Checked = false;
                        label8.Text = "";
                        pictureBox4.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox5.Visible = false;
                        button16.Visible = false;
                        CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox5.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label10.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox5.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox5.Checked = false;
                        label10.Text = "";
                        pictureBox5.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox4.Visible = false;
                        button17.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox6.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label2.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox6.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox6.Checked = false;
                        label2.Text = "";
                        pictureBox10.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox3.Visible = false;
                        button18.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox7.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label12.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox7.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox7.Checked = false;
                        label12.Text = "";
                        pictureBox9.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox2.Visible = false;
                        button19.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox8.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label11.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox8.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox8.Checked = false;
                        label11.Text = "";
                        pictureBox8.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox10.Visible = false;
                        button20.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox9.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label19.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox9.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox9.Checked = false;
                        label19.Text = "";
                        pictureBox7.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox9.Visible = false;
                        button21.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }

                if (checkBox10.Checked)
                {
                    CatCount = CatCount + 1;
                    if (CatCount < CatsC)
                    {
                        if (string.IsNullOrEmpty(label20.Text))
                    {
                        MessageBox.Show("Can't sell what you don't have!");
                        checkBox10.Checked = false;
                            CatCount = 0;
                        }
                    else
                    {
                        MoneyM = MoneyM + 500;
                        checkBox10.Checked = false;
                        label20.Text = "";
                        pictureBox6.Image = Wood;
                        CatsC = CatsC - 1;
                        textBox8.Visible = false;
                        button22.Visible = false;
                            CatCount = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must have at least 1 cat!");
                    }

                }
            } else
            {
                MessageBox.Show("Cannot Sell your last cat!");
            }
        }
        #endregion

        #region Feed Button
        private void button24_Click(object sender, EventArgs e)
        {
            if (FoodInBowl == true)
            {
                if (LQon == true)
                {
                    switch (CatsC)
                    {
                        case 1:
                            if (LQC >= 5)
                            {
                                LQC = LQC - 5;
                              Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 2:
                            if (LQC >= 10)
                            {
                                LQC = LQC - 10;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 3:
                            if (LQC >= 15)
                            {
                                LQC = LQC - 15;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 4:
                            if (LQC >= 20)
                            {
                                LQC = LQC - 20;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 5:
                            if (LQC >= 25)
                            {
                                LQC = LQC - 25;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 6:
                            if (LQC >= 30)
                            {
                                LQC = LQC - 30;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 7:
                            if (LQC >= 35)
                            {
                                LQC = LQC - 35;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 8:
                            if (LQC >= 40)
                            {
                                LQC = LQC - 40;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 9:
                            if (LQC >= 45)
                            {
                                LQC = LQC - 45;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 10:
                            if (LQC >= 50)
                            {
                                LQC = LQC - 50;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;                 
                    }
                    if (Working == true)
                    {
                        pictureBox17.Enabled = false;
                        pictureBox18.Enabled = false;
                        pictureBox19.Enabled = false;
                        button24.Enabled = false;
                        timer2.Start();
                        var p1 = new System.Windows.Media.MediaPlayer();
                        p1.Open(new System.Uri(result4));
                        p1.Play();
                        Working = false;
                    }


                }

                if (MQon == true)
                {
                    switch (CatsC)
                    {
                        case 1:
                            if (MQC >= 5)
                            {
                                MQC = MQC - 5;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 2:
                            if (MQC >= 10)
                            {
                                MQC = MQC - 10;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 3:
                            if (MQC >= 15)
                            {
                                MQC = MQC - 15;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 4:
                            if (MQC >= 20)
                            {
                                MQC = MQC - 20;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 5:
                            if (MQC >= 25)
                            {
                                MQC = MQC - 25;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 6:
                            if (MQC >= 30)
                            {
                                MQC = MQC - 30;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 7:
                            if (MQC >= 35)
                            {
                                MQC = MQC - 35;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 8:
                            if (MQC >= 40)
                            {
                                MQC = MQC - 40;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 9:
                            if (MQC >= 45)
                            {
                                MQC = MQC - 45;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 10:
                            if (MQC >= 50)
                            {
                                MQC = MQC - 50;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                    }
                    if (Working == true)
                    {
                        pictureBox17.Enabled = false;
                        pictureBox18.Enabled = false;
                        pictureBox19.Enabled = false;
                        button24.Enabled = false;
                        timer3.Start();
                        SoundPlayer player = new SoundPlayer(Properties.Resources.CatsEating);
                        player.Play();
                        Working = false;
                    }


                }

                if (HQon == true)
                {
                    switch (CatsC)
                    {
                        case 1:
                            if (HQC >= 5)
                            {
                                HQC = HQC - 5;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 2:
                            if (HQC >= 10)
                            {
                                HQC = HQC - 10;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 3:
                            if (HQC >= 15)
                            {
                                HQC = HQC - 15;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 4:
                            if (HQC >= 20)
                            {
                                HQC = HQC - 20;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 5:
                            if (HQC >= 25)
                            {
                                HQC = HQC - 25;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 6:
                            if (HQC >= 30)
                            {
                                HQC = HQC - 30;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 7:
                            if (HQC >= 35)
                            {
                                HQC = HQC - 35;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 8:
                            if (HQC >= 40)
                            {
                                HQC = HQC - 40;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 9:
                            if (HQC >= 45)
                            {
                                HQC = HQC - 45;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                        case 10:
                            if (HQC >= 50)
                            {
                                HQC = HQC - 50;
                                Working = true;
                            }
                            else
                            {
                                MessageBox.Show("You need more coffee beans you fool!");
                            }
                            break;
                    }
                    if (Working == true)
                    {
                        pictureBox17.Enabled = false;
                        pictureBox18.Enabled = false;
                        pictureBox19.Enabled = false;
                        button24.Enabled = false;
                        timer4.Start();
                        SoundPlayer player = new SoundPlayer(Properties.Resources.CatsEating);
                        player.Play();
                        Working = false;
                    }


                }

            }
        }
        #endregion

        #region Coffee PictureBox
        private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox17.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                LQon = true;
                MQon = false;
                HQon = false;
            }
        }

        private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox18.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                MQon = true;
                LQon = false;
                HQon = false;
            }
        }

        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox19.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                HQon = true;
                MQon = false;
                LQon = false;
            }
        }
        #endregion

        #region Food Bowl PictureBox
        private void pictureBox20_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pictureBox20_DragDrop(object sender, DragEventArgs e)
        {
            if (LQon == true)
            {
                if (LQC >= 5)
                {
                    var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                    pictureBox20.Image = FullBowl;
                  //  var p1 = new System.Windows.Media.MediaPlayer();
                  //  p1.Open(new System.Uri(result5));
                   // p1.Play()
                    SoundPlayer player = new SoundPlayer(Properties.Resources.SoundBowlFilling);
                    player.Play();
                    FoodInBowl = true;
                }
                else
                {
                
                }
            }

            if (MQon == true)
            {
                if (MQC >= 5)
                {
                    var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                    pictureBox20.Image = FullBowl;
                  //  var p1 = new System.Windows.Media.MediaPlayer();
                  //  p1.Open(new System.Uri(result5));
                  //  p1.Play();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.SoundBowlFilling);
                    player.Play();
                    FoodInBowl = true;
                }
                else
                {
                
                }
            }

            if (HQon == true)
            {
                if (HQC >= 5)
                {
                    var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                    pictureBox20.Image = FullBowl;
                  //  var p1 = new System.Windows.Media.MediaPlayer();
                  //  p1.Open(new System.Uri(result5));
                  //  p1.Play();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.SoundBowlFilling);
                    player.Play();
                    FoodInBowl = true;
                }
                else
                {
                
                }
            }
        }

        #endregion

        #region Save & Quit Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Information info = new Information();
                info.catName = label18.Text;
                info.catName2 = label16.Text;
                info.catName3 = label3.Text;
                info.catName4 = label8.Text;
                info.catName5 = label10.Text;
                info.catName6 = label2.Text;
                info.catName7 = label12.Text;
                info.catName8 = label11.Text;
                info.catName9 = label19.Text;
                info.catName10 = label20.Text;
                info.money = MoneyM;
                info.cats = CatsC;
                info.lQCoffee = LQC;
                info.mQCoffee = MQC;
                info.hQCoffee = HQC;

                #region Pic
                if (pictureBox1.Image == CatOne)
                {
                    info.pic = "1";
                }
                else if (pictureBox1.Image == CatOne2)
                {
                    info.pic = "2";
                }
                else if (pictureBox1.Image == CatOne3)
                {
                    info.pic = "3";
                }
                else if (pictureBox1.Image == CatOne4)
                {
                    info.pic = "4";
                }
                else if (pictureBox1.Image == CatOne5)
                {
                    info.pic = "5";
                }
                else if (pictureBox1.Image == CatOne6)
                {
                    info.pic = "6";
                }
                else if (pictureBox1.Image == CatOne7)
                {
                    info.pic = "7";
                }
                else if (pictureBox1.Image == CatOne8)
                {
                    info.pic = "8";
                }
                else if (pictureBox1.Image == CatOne9)
                {
                    info.pic = "9";
                }
                else if (pictureBox1.Image == CatOne10)
                {
                    info.pic = "10";
                }
                #endregion

                #region Pic Two
                if (pictureBox2.Image == CatOne)
                {
                    info.pic2 = "1";
                }
                else if (pictureBox2.Image == CatOne2)
                {
                    info.pic2 = "2";
                }
                else if (pictureBox2.Image == CatOne3)
                {
                    info.pic2 = "3";
                }
                else if (pictureBox2.Image == CatOne4)
                {
                    info.pic2 = "4";
                }
                else if (pictureBox2.Image == CatOne5)
                {
                    info.pic2 = "5";
                }
                else if (pictureBox2.Image == CatOne6)
                {
                    info.pic2 = "6";
                }
                else if (pictureBox2.Image == CatOne7)
                {
                    info.pic2 = "7";
                }
                else if (pictureBox2.Image == CatOne8)
                {
                    info.pic2 = "8";
                }
                else if (pictureBox2.Image == CatOne9)
                {
                    info.pic2 = "9";
                }
                else if (pictureBox2.Image == CatOne10)
                {
                    info.pic2 = "10";
                }
                #endregion

                #region Pic Three
                if (pictureBox3.Image == CatOne)
                {
                    info.pic3 = "1";
                }
                else if (pictureBox3.Image == CatOne2)
                {
                    info.pic3 = "2";
                }
                else if (pictureBox3.Image == CatOne3)
                {
                    info.pic3 = "3";
                }
                else if (pictureBox3.Image == CatOne4)
                {
                    info.pic3 = "4";
                }
                else if (pictureBox3.Image == CatOne5)
                {
                    info.pic3 = "5";
                }
                else if (pictureBox3.Image == CatOne6)
                {
                    info.pic3 = "6";
                }
                else if (pictureBox3.Image == CatOne7)
                {
                    info.pic3 = "7";
                }
                else if (pictureBox3.Image == CatOne8)
                {
                    info.pic3 = "8";
                }
                else if (pictureBox3.Image == CatOne9)
                {
                    info.pic3 = "9";
                }
                else if (pictureBox3.Image == CatOne10)
                {
                    info.pic3 = "10";
                }
                #endregion

                #region Pic Four
                if (pictureBox4.Image == CatOne)
                {
                    info.pic4 = "1";
                }
                else if (pictureBox4.Image == CatOne2)
                {
                    info.pic4 = "2";
                }
                else if (pictureBox4.Image == CatOne3)
                {
                    info.pic4 = "3";
                }
                else if (pictureBox4.Image == CatOne4)
                {
                    info.pic4 = "4";
                }
                else if (pictureBox4.Image == CatOne5)
                {
                    info.pic4 = "5";
                }
                else if (pictureBox4.Image == CatOne6)
                {
                    info.pic4 = "6";
                }
                else if (pictureBox4.Image == CatOne7)
                {
                    info.pic4 = "7";
                }
                else if (pictureBox4.Image == CatOne8)
                {
                    info.pic4 = "8";
                }
                else if (pictureBox4.Image == CatOne9)
                {
                    info.pic4 = "9";
                }
                else if (pictureBox4.Image == CatOne10)
                {
                    info.pic4 = "10";
                }
                #endregion

                #region Pic Five
                if (pictureBox5.Image == CatOne)
                {
                    info.pic5 = "1";
                }
                else if (pictureBox5.Image == CatOne2)
                {
                    info.pic5 = "2";
                }
                else if (pictureBox5.Image == CatOne3)
                {
                    info.pic5 = "3";
                }
                else if (pictureBox5.Image == CatOne4)
                {
                    info.pic5 = "4";
                }
                else if (pictureBox5.Image == CatOne5)
                {
                    info.pic5 = "5";
                }
                else if (pictureBox5.Image == CatOne6)
                {
                    info.pic5 = "6";
                }
                else if (pictureBox5.Image == CatOne7)
                {
                    info.pic5 = "7";
                }
                else if (pictureBox5.Image == CatOne8)
                {
                    info.pic5 = "8";
                }
                else if (pictureBox5.Image == CatOne9)
                {
                    info.pic5 = "9";
                }
                else if (pictureBox5.Image == CatOne10)
                {
                    info.pic5 = "10";
                }
                #endregion

                #region Pic Six
                if (pictureBox6.Image == CatOne)
                {
                    info.pic6 = "1";
                }
                else if (pictureBox6.Image == CatOne2)
                {
                    info.pic6 = "2";
                }
                else if (pictureBox6.Image == CatOne3)
                {
                    info.pic6 = "3";
                }
                else if (pictureBox6.Image == CatOne4)
                {
                    info.pic6 = "4";
                }
                else if (pictureBox6.Image == CatOne5)
                {
                    info.pic6 = "5";
                }
                else if (pictureBox6.Image == CatOne6)
                {
                    info.pic6 = "6";
                }
                else if (pictureBox6.Image == CatOne7)
                {
                    info.pic6 = "7";
                }
                else if (pictureBox6.Image == CatOne8)
                {
                    info.pic6 = "8";
                }
                else if (pictureBox6.Image == CatOne9)
                {
                    info.pic6 = "9";
                }
                else if (pictureBox6.Image == CatOne10)
                {
                    info.pic6 = "10";
                }
                #endregion

                #region Pic Seven
                if (pictureBox7.Image == CatOne)
                {
                    info.pic7 = "1";
                }
                else if (pictureBox7.Image == CatOne2)
                {
                    info.pic7 = "2";
                }
                else if (pictureBox7.Image == CatOne3)
                {
                    info.pic7 = "3";
                }
                else if (pictureBox7.Image == CatOne4)
                {
                    info.pic7 = "4";
                }
                else if (pictureBox7.Image == CatOne5)
                {
                    info.pic7 = "5";
                }
                else if (pictureBox7.Image == CatOne6)
                {
                    info.pic7 = "6";
                }
                else if (pictureBox7.Image == CatOne7)
                {
                    info.pic7 = "7";
                }
                else if (pictureBox7.Image == CatOne8)
                {
                    info.pic7 = "8";
                }
                else if (pictureBox7.Image == CatOne9)
                {
                    info.pic7 = "9";
                }
                else if (pictureBox7.Image == CatOne10)
                {
                    info.pic7 = "10";
                }
                #endregion

                #region Pic Eight
                if (pictureBox8.Image == CatOne)
                {
                    info.pic8 = "1";
                }
                else if (pictureBox8.Image == CatOne2)
                {
                    info.pic8 = "2";
                }
                else if (pictureBox8.Image == CatOne3)
                {
                    info.pic8 = "3";
                }
                else if (pictureBox8.Image == CatOne4)
                {
                    info.pic8 = "4";
                }
                else if (pictureBox8.Image == CatOne5)
                {
                    info.pic8 = "5";
                }
                else if (pictureBox8.Image == CatOne6)
                {
                    info.pic8 = "6";
                }
                else if (pictureBox8.Image == CatOne7)
                {
                    info.pic8 = "7";
                }
                else if (pictureBox8.Image == CatOne8)
                {
                    info.pic8 = "8";
                }
                else if (pictureBox8.Image == CatOne9)
                {
                    info.pic8 = "9";
                }
                else if (pictureBox8.Image == CatOne10)
                {
                    info.pic8 = "10";
                }
                #endregion

                #region Pic Nine
                if (pictureBox9.Image == CatOne)
                {
                    info.pic9 = "1";
                }
                else if (pictureBox9.Image == CatOne2)
                {
                    info.pic9 = "2";
                }
                else if (pictureBox9.Image == CatOne3)
                {
                    info.pic9 = "3";
                }
                else if (pictureBox9.Image == CatOne4)
                {
                    info.pic9 = "4";
                }
                else if (pictureBox9.Image == CatOne5)
                {
                    info.pic9 = "5";
                }
                else if (pictureBox9.Image == CatOne6)
                {
                    info.pic9 = "6";
                }
                else if (pictureBox9.Image == CatOne7)
                {
                    info.pic9 = "7";
                }
                else if (pictureBox9.Image == CatOne8)
                {
                    info.pic9 = "8";
                }
                else if (pictureBox9.Image == CatOne9)
                {
                    info.pic9 = "9";
                }
                else if (pictureBox9.Image == CatOne10)
                {
                    info.pic9 = "10";
                }
                #endregion

                #region Pic Ten
                if (pictureBox10.Image == CatOne)
                {
                    info.pic10 = "1";
                }
                else if (pictureBox10.Image == CatOne2)
                {
                    info.pic10 = "2";
                }
                else if (pictureBox10.Image == CatOne3)
                {
                    info.pic10 = "3";
                }
                else if (pictureBox10.Image == CatOne4)
                {
                    info.pic10 = "4";
                }
                else if (pictureBox10.Image == CatOne5)
                {
                    info.pic10 = "5";
                }
                else if (pictureBox10.Image == CatOne6)
                {
                    info.pic10 = "6";
                }
                else if (pictureBox10.Image == CatOne7)
                {
                    info.pic10 = "7";
                }
                else if (pictureBox10.Image == CatOne8)
                {
                    info.pic10 = "8";
                }
                else if (pictureBox10.Image == CatOne9)
                {
                    info.pic10 = "9";
                }
                else if (pictureBox10.Image == CatOne10)
                {
                    info.pic = "10";
                }
                #endregion

                SaveData.SaveXml(info, "data.xml");

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
    }
        #endregion

        #region Sell Poo Button
        private void button25_Click(object sender, EventArgs e)
        {
            if (LQPoo <= 0)
            {
                if (MQPoo <= 0)
                {
                    if (HQPoo <= 0)
                    {
                        MessageBox.Show("Out of Poo my friend");
                    }
                    else
                    {
                      
                        HQPoo = HQPoo - 1;
                        MoneyM = MoneyM + 32;
                        var p1 = new System.Windows.Media.MediaPlayer();
                        p1.Open(new System.Uri(result3));
                        p1.Play();
                    }
                }
                else
                {
                    MQPoo = MQPoo - 1;
                    MoneyM = MoneyM + 16;
                    var p1 = new System.Windows.Media.MediaPlayer();
                    p1.Open(new System.Uri(result3));
                    p1.Play();
                }

            }
            else
            {
                LQPoo = LQPoo - 1;
                MoneyM = MoneyM + 8;
                var p1 = new System.Windows.Media.MediaPlayer();
                p1.Open(new System.Uri(result3));
                p1.Play();
            }
        }
        #endregion

        #region Eating Timer One
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter = counter + 10;
            if (counter == 800)
            {
                counter = counter - 800;
                switch (CatsC)
                {
                    case 1:
                        LQPoo = LQPoo + 1;

                        break;
                    case 2:
                        LQPoo = LQPoo + 2;
                        break;
                    case 3:
                        LQPoo = LQPoo + 3;
                        break;
                    case 4:
                        LQPoo = LQPoo + 4;
                        break;
                    case 5:
                        LQPoo = LQPoo + 5;
                        break;
                    case 6:
                        LQPoo = LQPoo + 6;
                        break;
                    case 7:
                        LQPoo = LQPoo + 7;
                        break;
                    case 8:
                        LQPoo = LQPoo + 8;
                        break;
                    case 9:
                        LQPoo = LQPoo + 9;
                        break;
                    case 10:
                        LQPoo = LQPoo + 10;
                        break;
                }
                pictureBox17.Enabled = true;
                pictureBox18.Enabled = true;
                pictureBox19.Enabled = true;
                pictureBox20.Image = EmptyBowl;
                button24.Enabled = true;
                FoodInBowl = false;
                LQon = false;
                timer2.Stop();
            }
        }
        #endregion

        #region Eating Timer Two
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter = counter + 10;
            if (counter == 800)
            {
                counter = counter - 800;
                switch (CatsC)
                {
                    case 1:
                        MQPoo = MQPoo + 1;
                        break;
                    case 2:
                        MQPoo = MQPoo + 2;
                        break;
                    case 3:
                        MQPoo = MQPoo + 3;
                        break;
                    case 4:
                        MQPoo = MQPoo + 4;
                        break;
                    case 5:
                        MQPoo = MQPoo + 5;
                        break;
                    case 6:
                        MQPoo = MQPoo + 6;
                        break;
                    case 7:
                        MQPoo = MQPoo + 7;
                        break;
                    case 8:
                        MQPoo = MQPoo + 8;
                        break;
                    case 9:
                        MQPoo = MQPoo + 9;
                        break;
                    case 10:
                        MQPoo = MQPoo + 10;
                        break;
                }
                pictureBox17.Enabled = true;
                pictureBox18.Enabled = true;
                pictureBox19.Enabled = true;
                pictureBox20.Image = EmptyBowl;
                button24.Enabled = true;
                FoodInBowl = false;
                MQon = false;
                timer3.Stop();
            }
        }
        #endregion

        #region Eating Timer Three
        private void timer4_Tick(object sender, EventArgs e)
        {
            counter = counter + 10;
            if (counter == 800)
            {
                counter = counter - 800;
                switch (CatsC)
                {
                    case 1:
                        HQPoo = HQPoo + 1;
                        break;
                    case 2:
                        HQPoo = HQPoo + 2;
                        break;
                    case 3:
                        HQPoo = HQPoo + 3;
                        break;
                    case 4:
                        HQPoo = HQPoo + 4;
                        break;
                    case 5:
                        HQPoo = HQPoo + 5;
                        break;
                    case 6:
                        HQPoo = HQPoo + 6;
                        break;
                    case 7:
                        HQPoo = HQPoo + 7;
                        break;
                    case 8:
                        HQPoo = HQPoo + 8;
                        break;
                    case 9:
                        HQPoo = HQPoo + 9;
                        break;
                    case 10:
                        HQPoo = HQPoo + 10;
                        break;
                }
                pictureBox17.Enabled = true;
                pictureBox18.Enabled = true;
                pictureBox19.Enabled = true;
                pictureBox20.Image = EmptyBowl;
                button24.Enabled = true;
                FoodInBowl = false;
                HQon = false;
                timer4.Stop();
            }
        }
        #endregion

        #region Upgrade Apartment Button
        private void button26_Click(object sender, EventArgs e)
        {
            if (ApartmentLevel == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Cost 1500 CC", "Upgrade Apartment", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (MoneyM >= 1500)
                    {
                        ApartmentLevel = ApartmentLevel + 1;
                        MoneyM = MoneyM - 1500;
                    }
                    else
                    {
                        MessageBox.Show("Poor people don't deserve level 2 apartments");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Come back anytime!");
                }

            } else
            {
                MessageBox.Show("You are at the maximum Level!");
            }
        }
        #endregion

        #region Interact Cat Sounds
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label18.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            } else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label16.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label3.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label8.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label10.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label2.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label12.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label11.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label19.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label20.Text))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.door_knock_1);
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.animals022);
                player.Play();
            }
        }

        #endregion

        #region Tester Only  //Deleted on release 
        private void button27_Click(object sender, EventArgs e)
        {
            MoneyM = MoneyM + 1000;
        }
        #endregion 
       
    }
}
