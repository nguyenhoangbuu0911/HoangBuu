using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NguyenHoangBuu_1706020005_LapTrinhHDT
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<clsDiem>> data = new Dictionary<string, List<clsDiem>>();
        Graphics g;
        Pen pen = new Pen(Color.Black, 1);
        bool canDraw = false;
        clsDiem begin = new clsDiem();
        clsDiem end = new clsDiem();
        triangular triangular = new triangular();
        Line line = new Line();

        Rectangle rect = new Rectangle();
        bool pointer, isLine, istriangular;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pointer = true;
            istriangular = true;
            isLine = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                canDraw = true;
                begin = new clsDiem(e.X, e.Y);
                rect.X = begin.x;
                rect.Y = begin.y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw == true)
            {
                end = new clsDiem(e.X, e.Y);
                g.Clear(pictureBox1.BackColor);
                if (pointer)
                {
                    return;
                }
                else if (isLine == true)
                {
                    g.DrawLine(pen, begin.x, begin.y, e.X, e.Y);
                }

                Update();
            }
        }



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                end.x = e.X;
                end.y = e.Y;
                canDraw = false;
                if (isLine)
                {
                    line.begin = begin;
                    line.end = end;
                    line.AddPoint();
                }
                else if (istriangular)
                {
                    triangular.begin = begin;
                    triangular.end = end;
                    triangular.AddPoint();
                }

            }
        }

        private void tsbDuongThang_Click_1(object sender, EventArgs e)
        {
            pointer = false;
            isLine = true;
            istriangular = false;
        }

        private void tsbTamGiac_Click_1(object sender, EventArgs e)
        {
            pointer = false;
            isLine = false;
            istriangular = true;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            pointer = true;
            istriangular = false;
            isLine = false;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line", line.SaveData());
            data.Add("TamGiac", triangular.SaveData());
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(data);
            writer.Write(json);
            writer.Close();
        }

        private void tsbLoad_Click_1(object sender, EventArgs e)
        {
            pointer = true;
            istriangular = false;
            isLine = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "json| *.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<Dictionary<string, List<clsDiem>>>(json);
            line.LoadData(data, "line");
            triangular.LoadData(data, "TamGiac");
            reader.Close();
            Update();
        }

        
        void Update()
        {
            for (int i = 0; i < line.save.Count - 1; i += 2)
            {
                line.Draw(g, pen);
            }
            for (int i = 0; i < triangular.save.Count - 1; i += 2)
            {
                triangular.Draw(g, pen);
            }

        }
    }
}
