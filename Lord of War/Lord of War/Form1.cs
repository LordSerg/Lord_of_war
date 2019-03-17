using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Diagnostics;// включать/выключать ехе

namespace Lord_of_War
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double m=1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Gold;
            timer1.Enabled = true;
            //this.Cursor = new Cursor(GetType(), "8.cur");
            m = 1;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Random r = new Random();
            //this.BackColor = Color.FromArgb(r.Next(100,200), r.Next(100), r.Next(150, 250));
            //this.Cursor = new Cursor(GetType(), "7.cur");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"C:\Users\moskalenko_s\Desktop\My games\Lord of War\Sounds\cartoon008.wav");
            s.Play();
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        //48*48 - standart
        private void timer1_Tick(object sender, EventArgs e)
        {
            mouse(m);
            
            //menuStrip1.Visible = false;
            //menuStrip2.Visible = false;
            //menuStrip3.Visible = false;
            //if (state == 0)
            //{
            //    menuStrip2.Visible = true;
            //}
            //if (state == 0.1)//new game
            //{
            //    menuStrip3.Visible = true;
            //}
            //if (state == 0.2)//continue the game
            //{
                
            //}
            //if (state == 0.3)//settings
            //{
            //    this.Cursor = new Cursor(GetType(), "7.cur");
            //}
            //if (state == 0.4)//about the game
            //{

            //}
            //if (state == 0.5)//about the author
            //{

            //}
            //максимально допустимый стандартный размер курсора - 128х128
            //оптимальные размераим курсора - 32х32 и 48х48
        }
        void mouse (double m)
        {
            if (m == 1)
            {
                this.Cursor = new Cursor(GetType(), "7.cur");
            }
            if(m == 2)
            {
                this.Cursor = new Cursor(GetType(), "8.cur");
            }
        }
        private void выходToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //m = 2;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            m = 1;
        }

        private void фгерщкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открывается проводник и можно запустить любой .ехе файл

            //OpenFileDialog opf = new OpenFileDialog();
            //if(opf.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            //{
            //    string s = opf.FileName;
            //    Process.Start(s);
            //}
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
        //    //System.Drawing.Rectangle newRectangle = button1.ClientRectangle;
        //    //Random r = new Random();
        //    //int h, w;
        //    //w = r.Next(50);
        //    //h = r.Next(50);
        //    //newRectangle.Inflate(-w,-h);
        //    ////newRectangle.Inflate(20, 20);
        //    //buttonPath.AddEllipse(newRectangle);
        //    //button1.Region = new System.Drawing.Region(buttonPath);
        //}
    }
}
