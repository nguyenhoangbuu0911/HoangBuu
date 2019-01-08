using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace NguyenHoangBuu_1706020005_LapTrinhHDT
{
    class clsHinh
    {
        public List<clsDiem> save = new List<clsDiem>();
        public virtual void Draw(Graphics g, Pen pen)
        { 
}

        public clsHinh()
        {

        }

        public void LoadData(Dictionary<string, List<clsDiem>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<clsDiem> SaveData()
        {
            List<clsDiem> temp = new List<clsDiem>();
            temp = save;
            return temp;
        }
    }
    class Line : clsHinh
    {
        public clsDiem begin = new clsDiem();
        public clsDiem end = new clsDiem();
        public Line()
        {
            begin = new clsDiem(0, 0);
            end = new clsDiem(0, 0);
        }
        public Line(clsDiem A, clsDiem B)
        {
            begin = A;
            end = B;
        }

        public void Draw(Graphics g, Pen pen)
        {
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }

        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }

    class triangular : clsHinh
    {
        public clsDiem begin = new clsDiem();
        public clsDiem end = new clsDiem();
        public clsDiem fe = new clsDiem();
        public triangular()
        {
            begin = new clsDiem(0, 0);
            end = new clsDiem(0, 0);
            fe = new clsDiem(0, 0);
        }
        public triangular(clsDiem A, clsDiem B, clsDiem C)
        {
            begin = A;
            end = B;
            fe = C;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            base.Draw(g, pen);
            Rectangle rect = new Rectangle();
            rect.Size = new Size(end.x - begin.x, end.y - end.y);
            rect.X = begin.x;
            rect.Y = begin.y;
            g.DrawLine(pen, rect.X, rect.Y + rect.Height, end.x, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.y, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.x - rect.Width, end.y);
        }

        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }

        public void Add()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {

            }
        }
    }
}
