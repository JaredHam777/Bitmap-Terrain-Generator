using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrainGen
{
    public partial class Form1 : Form
    {
        public Bitmap BM = new Bitmap(100, 100);
        public Random RandomNumber = new Random();
        public List<Color> EColors = new List<Color>();
        public List<Point> OldPoints = new List<Point>();
        public List<Point> ColoredPoints = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = BM;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WindowState = FormWindowState.Maximized;
            EColorList(Convert.ToInt32(ELayers_TxtBox.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsRndElevation(Convert.ToInt32(NumPeaks_txtbox.Text));
        }

        public void InsRndElevation(int num_points)
        {
            for(int i=0; i<num_points; i++)
            {
                Point p = new Point(Rnd(0, BM.Width), Rnd(0, BM.Height));
                BM.SetPixel(p.X, p.Y, EColors[Rnd(Convert.ToInt32((EColors.Count) - EColors.Count*Convert.ToDecimal(ElevationPropVar_TxtBox.Text)), EColors.Count)]);
                ColoredPoints.Add(p);
            }
            pictureBox1.Image = BM;
        }

        public void ExpandTerrain()
        {
            List<Point> points = new List<Point>();
            for(int x=0; x<BM.Width; x++)
            {

                for(int y=0; y<BM.Height; y++)
                {
                    int Elevation = EColors.IndexOf(BM.GetPixel(x, y));
                    if (Elevation > 0 & OldPoints.Contains((new Point(x, y))) == false)
                    {
                        if (x > 0 & x < BM.Width - 1 & y > 0 & y < BM.Height - 1)
                        {
                            Boolean pointadded = false;
                            if (Elevation > EColors.IndexOf(BM.GetPixel(x + 1, y)) & points.Contains(new Point(x,y))==false ) { ColorPixel(new Point(x + 1, y), new Point(x,y), Elevation, points); pointadded = true; }                           
                            if (Elevation > EColors.IndexOf(BM.GetPixel(x - 1, y)) & points.Contains(new Point(x,y)) == false ) { ColorPixel(new Point(x - 1, y), new Point(x,y), Elevation, points); pointadded = true; }
                            if (Elevation > EColors.IndexOf(BM.GetPixel(x, y + 1)) & points.Contains(new Point(x,y)) == false ) { ColorPixel(new Point(x, y + 1), new Point(x,y), Elevation, points); pointadded = true; }
                            if (Elevation > EColors.IndexOf(BM.GetPixel(x, y - 1)) & points.Contains(new Point(x,y)) == false ) { ColorPixel(new Point(x, y - 1), new Point(x,y), Elevation, points); pointadded = true; }
                            if(pointadded == true & OldPoints.Contains(new Point(x,y))==false) {OldPoints.Add(new Point(x,y)); }
                        }
                    }
                }
            }
           
            pictureBox1.Image = BM;
           
        }


        public void EColorList(int num_colors)
        {
            EColors.Clear();
            for(int i=0; i<num_colors; i++)
            {
                EColors.Add(Color.FromArgb(((i*255) / num_colors), ((i*255) / num_colors), ((i*255) / num_colors)));
            }
        }

        public void ColorPixel(Point p, Point Oldpoint, int Elevation, List<Point> points)
        {
            int NewE = Elevation - RndMultRoll(Convert.ToInt32(ElevationDropIterrations_Textbox.Text), Convert.ToInt32(ProbElevationDrop_TxtBox.Text), Elevation);
            BM.SetPixel(p.X, p.Y, EColors[NewE]);
            if(NewE == 0 & RndRoll(20) == true) { BM.SetPixel(p.X, p.Y, EColors[1]); }
            if (ColoredPoints.Contains(p) == false) { ColoredPoints.Add(p); }
            points.Add(p);
            

        }


        public int Rnd(int Min, int Max)
        {
            if (Min == Max) { return Max-1; }
            return RandomNumber.Next(Min, Max);
        }
        public Boolean RndRoll(int p)
        {
            if (Rnd(0, 100) < p) { return true;} else { return false;}
        }
        public int RndMultRoll(int iterrations, int p, int Elevation)
        {
            int A = 0;
            for(int i=0; i<iterrations; i++)
            {
                if (RndRoll(p) == true) { A += 1;}
            }
            
            return Math.Min(Elevation, A);
        }
        private void ELayers_TxtBox_TextChanged(object sender, EventArgs e)
        {
            ELayers_Btn.Enabled = true;
        }

        private void ELayers_Btn_Click(object sender, EventArgs e)
        {
            EColorList(Convert.ToInt32(ELayers_TxtBox.Text));
            ELayers_Btn.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int i=0; i<Convert.ToInt32(ExpandIterrations_TxtBox.Text); i++) { ExpandTerrain();}
            
        }

        public int FindElevation(Point p)
        {
            return (Convert.ToInt32((EColors.IndexOf(BM.GetPixel(p.X+1,p.Y))+ EColors.IndexOf(BM.GetPixel(p.X - 1, p.Y)) + EColors.IndexOf(BM.GetPixel(p.X, p.Y+1)) + EColors.IndexOf(BM.GetPixel(p.X, p.Y-1)))/4)); 
        }

        public void Smooth()      

                    {
            foreach (Point p in ColoredPoints)
            {
                if (p.X > 0 & p.X < BM.Width - 1 & p.Y > 0 & p.Y < BM.Height - 1)
                {
                    BM.SetPixel(p.X, p.Y, EColors[FindElevation(new Point(p.X, p.Y))]);
                }
            }
            pictureBox1.Image = BM;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Smooth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Point p in ColoredPoints)
            {
                BM.SetPixel(p.X, p.Y, Color.Black);
            }
            ColoredPoints.Clear();
            OldPoints.Clear();
            pictureBox1.Image = BM;
        }
    }
    }

