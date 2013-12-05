using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DIP_START
{
    public class HistogramProcessed
    {
        //public Bitmap proc_image;
        int[] bins = new int[256];
        double scaleFactor;

        public void processProcHistogram(FormGUI form1, Bitmap image)
        {
            form1.picboxContrast.Visible = false;
            
            if (bins.Count() > 0)
            {
                reset();
            }
            //proc_image = image;

            var b = new Bitmap(1, 1);
            b.SetPixel(0, 0, Color.White);

            var map = new Bitmap(b, 256, 160);
            Graphics gb = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Blue);

            bins = Bins.populateBins(image);

            int max = bins.Max();

            scaleFactor = 150.0f / max;

            Matrix mm = new Matrix();
            mm = new Matrix(1, 0, 0, -1, 0, 160);
            gb.Transform = mm;

            for (int i = 0; i < 256; i++)
            {
                gb.DrawLine(pen, i, 0, i, Convert.ToInt32(bins[i] * scaleFactor));
            }

            //gb.DrawLine(pen, 50, 50, 100, 100);

            form1.picBoxProcHist.Image = map;
            pen.Dispose();
            gb.Dispose();

        }

        private void reset()
        {
            bins = null;
            scaleFactor = 0.0;
        }

    }
}
