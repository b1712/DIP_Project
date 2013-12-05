using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DIP_START
{
    class RobertsDirectSubstitution
    {
        public Bitmap original_image, proc_image;
        public BitmapData bmDataOriginal;
        public int width;
        public int height;
        public int greyTotal;
        Graphics g;
        FormGUI form1;
        BitmapData bmDataProc;

        public void processRobertsDirect(FormGUI form1, Bitmap image)
        {
            original_image = image;
            form1.picboxContrast.Visible = false;
            form1.picBoxProcHist.Visible = false;

            g = form1.CreateGraphics();
            this.form1 = form1;

            width = original_image.Width - 1;
            height = original_image.Height - 1;
            greyTotal = 0;
           
            form1.panelTrackBar.Visible = false;

            proc_image = (Bitmap)original_image.Clone();

            int trackValue = form1.trackBarControl.Value;

            bmDataOriginal = original_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            bmDataProc = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmDataOriginal.Stride;
            System.IntPtr Scan0 = bmDataOriginal.Scan0;

            System.IntPtr Scan1 = bmDataProc.Scan0;

            unsafe
            {
                byte* o = (byte*)(void*)Scan0;
                byte* p = (byte*)(void*)Scan1;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        greyTotal = Math.Abs(o[y * stride + x] - o[(y + 1) * stride + x + 1]) +
                                    Math.Abs(o[(y + 1) * stride + x] - o[y * stride + x + 1]);

                        if (greyTotal > 255)
                        {
                            greyTotal = 255;
                        }

                        p[y * stride + x] = (byte)greyTotal;
                        
                    }
                }
            }

            original_image.UnlockBits(bmDataOriginal);
            proc_image.UnlockBits(bmDataProc);

            form1.picBoxProcImage.Image = proc_image;
            form1.Controls.Add(form1.picBoxProcImage);
            form1.picBoxProcImage.Visible = true;
        }
    }
}
