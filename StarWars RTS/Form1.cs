using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StarWars_RTS
{
    public partial class Form1 : Form
    {
        Graphics onScreen;
        Bitmap bm;
        Graphics offScreen;
        public Form1()
        {
            InitializeComponent();
            onScreen = this.CreateGraphics();
            bm = new Bitmap(this.Width, this.Height);
            offScreen = Graphics.FromImage(bm);
        }

        int click = 0, unitID, xMouse, yMouse, unitHP1, unitHP2, unitHP3, unitHP4, unitHP5, unitHP6, unitHP7, unitHP8, unitHP9, unitHP0, unitX0, unitX1, unitX2, unitX3, unitX4, unitX5, unitX6, unitX7, unitX8, unitX9, unitY0, unitY1, unitY2, unitY3, unitY4, unitY5, unitY6, unitY7, unitY8, unitY9;

        Pen drawpen = new Pen(Color.Black);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 && unitHP0 >= 0)
            {
                unitID = 0;
            }
            if (e.KeyCode == Keys.D1 && unitHP1 >= 0)
            {
                unitID = 1;
            }
            if (e.KeyCode == Keys.D2 && unitHP2 >= 0)
            {
                unitID = 2;
            }
            if (e.KeyCode == Keys.D3 && unitHP3 >= 0)
            {
                unitID = 3;
            }
            if (e.KeyCode == Keys.D4 && unitHP4 >= 0)
            {
                unitID = 4;
            }
            if (e.KeyCode == Keys.D5 && unitHP5 >= 0)
            {
                unitID = 5;
            }
            if (e.KeyCode == Keys.D6 && unitHP6 >= 0)
            {
                unitID = 6;
            }
            if (e.KeyCode == Keys.D7 && unitHP7 >= 0)
            {
                unitID = 7;
            }
            if (e.KeyCode == Keys.D8 && unitHP8 >= 0)
            {
                unitID = 8;
            }
            if (e.KeyCode == Keys.D9 && unitHP9 >= 0)
            {
                unitID = 9;
            }
            unitPos(unitID);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point position = Cursor.Position;
            Point relativeToForm = this.PointToClient(position);
            xMouse = relativeToForm.X;
            yMouse = relativeToForm.Y;
            click = 1;
            unitPos(unitID);
        }

        public void unitPos(int UNID)
        {
            if (UNID == 0 && click == 1)
            {
                while (xMouse < unitX0 || xMouse > unitX0 || yMouse < unitY0 || yMouse > unitY0)
                {
                    if (unitY0 < yMouse)
                    {
                        unitY0++;
                    }
                    if (unitY0 > yMouse)
                    {
                        unitY0--;
                    }
                    if (unitX0 > xMouse)
                    {
                        unitX0--;
                    }
                    if (unitX0 < xMouse)
                    {
                        unitX0++;
                    }
                    offScreen.DrawEllipse(drawpen, unitX0, unitY0, 20, 20);
                    offScreen.DrawEllipse(drawpen, unitX1, unitY1, 20, 20);
                    onScreen.DrawImage(bm, 0, 0);
                    Thread.Sleep(10);
                    offScreen.Clear(Color.White);
                }
            }
            if (UNID == 1 && click == 1)
            {
                while (xMouse < unitX1 || xMouse > unitX1 && yMouse < unitY1 || yMouse > unitY1)
                {
                    while (xMouse < unitX1 || xMouse > unitX1 || yMouse < unitY1 || yMouse > unitY1)
                    {
                        if (unitY1 < yMouse)
                        {
                            unitY1++;
                        }
                        if (unitY1 > yMouse)
                        {
                            unitY1--;
                        }
                        if (unitX1 > xMouse)
                        {
                            unitX1--;
                        }
                        if (unitX1 < xMouse)
                        {
                            unitX1++;
                        }
                        offScreen.DrawEllipse(drawpen, unitX0, unitY0, 20, 20);
                        offScreen.DrawEllipse(drawpen, unitX1, unitY1, 20, 20);
                        onScreen.DrawImage(bm, 0, 0);
                        Thread.Sleep(10);
                        offScreen.Clear(Color.White);
                    }
                }
            }
            if (UNID == 2)
            {
                while (xMouse < unitX2 || xMouse > unitX2 && yMouse < unitY2 || yMouse > unitY2)
                {

                }
            }
            if (UNID == 3)
            {
                while (xMouse < unitX3 || xMouse > unitX3 && yMouse < unitY3 || yMouse > unitY3)
                {

                }
            }
            if (UNID == 4)
            {
                while (xMouse < unitX4 || xMouse > unitX4 && yMouse < unitY4 || yMouse > unitY4)
                {

                }
            }
            if (UNID == 5)
            {
                while (xMouse < unitX5 || xMouse > unitX5 && yMouse < unitY5 || yMouse > unitY5)
                {

                }
            }
            if (UNID == 6)
            {
                while (xMouse < unitX6 || xMouse > unitX6 && yMouse < unitY6 || yMouse > unitY6)
                {

                }
            }
            if (UNID == 7)
            {
                while (xMouse < unitX7 || xMouse > unitX7 && yMouse < unitY7 || yMouse > unitY7)
                {

                }
            }
            if (UNID == 8)
            {
                while (xMouse < unitX8 || xMouse > unitX8 && yMouse < unitY8 || yMouse > unitY8)
                {

                }
            }
            if (UNID == 9)
            {
                while (xMouse < unitX9 || xMouse > unitX9 && yMouse < unitY9 || yMouse > unitY9)
                {

                }
            }
            click = 0;
        }
    }
}
