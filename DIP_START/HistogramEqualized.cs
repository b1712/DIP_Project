using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Drawing2D;

namespace DIP_START
{
    class HistogramEqualized
    {
        public Bitmap original_image, proc_image;
        public int[] bins = new int[256];
        public float[] cdf = new float[256];
        public float[] pdf = new float[256];
        public float[] nkn = new float[256];
        int maxBin = 0;
        double scaleFactor;
        int width;
        int height;
        Graphics g;
        //Rectangle r;
        //Rectangle r2;
        //Pen pen;
        BitmapData bmDataOriginal;
        BitmapData bmDataProc;


        public void processEqualisedHistogram(FormGUI form1, Bitmap image)
        {
            form1.picboxContrast.Visible = false;
            
            if (maxBin > 0)
            {
                reset();
            }

            //form1.panelProcHist.Visible = true;
            form1.lblProcHist.Visible = true;
            form1.picBoxProcHist.Visible = true;
            original_image = image;

            form1.panelTrackBar.Visible = false;

            g = form1.CreateGraphics();

            width = original_image.Width;
            height = original_image.Height;

            proc_image = (Bitmap)original_image.Clone();

            //r = new Rectangle(535, 50, original_image.Width, original_image.Height);
            //r2 = new Rectangle(0, 0, original_image.Width, original_image.Height);

            //proc_image = original_image.Clone(r2, PixelFormat.Format8bppIndexed);

            bins = Bins.populateBins(original_image);

            for (int i = 0; i < 256; i++)
            {

                if (bins[i] == 0)
                {
                    nkn[i] = 0;
                }
                else
                {
                    nkn[i] = bins[i] / (float)(width * height);
                }
            }

            float total = 0;
            for (int i = 0; i < 256; i++)
            {
                total += nkn[i];
                cdf[i] = total * 255;
            }

            bmDataOriginal = original_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            bmDataProc = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride2 = bmDataOriginal.Stride;
            System.IntPtr Scan1 = bmDataOriginal.Scan0;

            System.IntPtr Scan2 = bmDataProc.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)Scan1;
                byte* p = (byte*)(void*)Scan2;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[y * stride2 + x] = (byte)cdf[o[y * stride2 + x]];
                    }
                }
            }

            original_image.UnlockBits(bmDataOriginal);
            proc_image.UnlockBits(bmDataProc);


            form1.picBoxProcImage.Image = proc_image;
            form1.Controls.Add(form1.picBoxProcImage);
            form1.picBoxProcImage.Visible = true;


            //g.DrawImage(proc_image, r);
            g.Dispose();

            var b = new Bitmap(1, 1);
            b.SetPixel(0, 0, Color.White);

            var map = new Bitmap(b, 256, 160);
            Graphics gb = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Blue);

            bins = Bins.populateBins(proc_image);

            int max = bins.Max();

            scaleFactor = 150.0f / max;

            Matrix mm = new Matrix();
            mm = new Matrix(1, 0, 0, -1, 0, 160);
            gb.Transform = mm;

            for (int i = 0; i < 256; i++)
            {
                gb.DrawLine(pen, i, 0, i, Convert.ToInt32(bins[i] * scaleFactor));
            }

            form1.picBoxProcHist.Image = map;
            pen.Dispose();
            gb.Dispose();



            //Graphics gf = form1.panelProcHist.CreateGraphics();
            //Graphics gf = form1.picBoxProcHist.CreateGraphics();
            //gf.Clear(Color.White);
            //width = original_image.Width;
            //height = original_image.Height;

            //bins = Bins.populateBins(proc_image);

            //maxBin = bins.Max();

            //scaleFactor = 150.0f / maxBin;

            //pen = new Pen(Color.Black);

            //Matrix mm = new Matrix();
            //mm = new Matrix(1, 0, 0, -1, 0, 160);
            //gf.Transform = mm;

            //pen.Color = Color.Blue;

            //for (int i = 0; i < 256; i++)
            //{
            //    gf.DrawLine(pen, i, 0, i, Convert.ToInt32(bins[i] * scaleFactor));
            //}

            //pen.Dispose();

            /*var b = new Bitmap(1, 1);
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
            gb.Dispose();*/

        }

        private void reset()
        {
            bins = null;
            maxBin = 0;
            scaleFactor = 0.0;
        }
    }
}
