using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace DIP_START
{
    class HistogramOriginal
    {
        public Bitmap original_image;
        int[] bins = new int[256];
        double scaleFactor;
        
        public void processOriginalHistogram(FormGUI form1, Bitmap image)
        {
            
            original_image = image;

            form1.panelTrackBar.Visible = false;

            //form1.picBoxOriginal.Refresh();

            var b = new Bitmap(1, 1);
            b.SetPixel(0, 0, Color.White);

            var map = new Bitmap(b, 256, 160);
            Graphics gb = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Blue);
         
            bins = Bins.populateBins(original_image);

            int max = bins.Max();

            scaleFactor = 150.0f / max;

            Matrix mm = new Matrix();
            mm = new Matrix(1, 0, 0, -1, 0, 160);
            gb.Transform = mm;

            for (int i = 0; i < 256; i++)
            {
                gb.DrawLine(pen, i, 0, i, Convert.ToInt32(bins[i] * scaleFactor));
            }

            form1.picBoxOrigHist.Image = map;
            pen.Dispose();
            gb.Dispose();
            
        }
    }
}

