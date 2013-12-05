using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DIP_START
{
    public class DrawHistogram
    {
        public static Panel drawPanel(Panel panel, int[] bins, int x, int y)
        {
            Pen pen = new Pen(Color.Black);
            Graphics gHistEq = panel.CreateGraphics();

            panel.Location = new System.Drawing.Point(x, y);
            panel.Size = new System.Drawing.Size(260, 130);
            

            //gHistEq.TranslateTransform(800, 710);
            //gHistEq.RotateTransform(180);
            //panel.Size(260, 130);
            //Brush brush = new SolidBrush(Color.White);

            //rect = new Rectangle(0, 0, 255, 130);
            //gHistEq.FillRectangle(brush, rect);
            //gHistEq.DrawRectangle(pen, rect);

            //Array.Reverse(bins);

            pen.Color = Color.Blue;

            for (int i = 0; i < 256; i++)
            {
                gHistEq.DrawLine(pen, i, 0, i, Convert.ToInt32(bins[i]));
            }

            pen.Dispose();

            gHistEq.Dispose();
            
            return panel;
        }
    }
}
