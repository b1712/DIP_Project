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
    class MedianFilter
    {
        public Bitmap original_image, proc_image;
        //public int[] bins = new int[256];

        public void processMedian(FormGUI form1, Bitmap image)
        {
            original_image = image;
            form1.picboxContrast.Visible = false;
            form1.picBoxProcHist.Visible = false;

            Graphics g = form1.CreateGraphics();

            int width = original_image.Width - 2;
            int height = original_image.Height - 2;
            byte[] medianList = new byte[9];

            proc_image = (Bitmap)original_image.Clone();

            //Rectangle r = new Rectangle(535, 50, original_image.Width, original_image.Height);
            //Rectangle r2 = new Rectangle(0, 0, original_image.Width, original_image.Height);

            //Rectangle r3 = new Rectangle(10, 50, original_image.Width, original_image.Height);
            //g.DrawImage(original_image, r3);

            //proc_image = original_image.Clone(r2, PixelFormat.Format8bppIndexed);

            BitmapData bmDataOriginal = original_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            BitmapData bmDataProc = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

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
                        medianList[0] = o[y * stride + x];
                        medianList[1] = o[y * stride + x + 1];
                        medianList[2] = o[y * stride + x + 2];
                        medianList[3] = o[(y + 1) * stride + x];
                        medianList[4] = o[(y + 1) * stride + x + 1];
                        medianList[5] = o[(y + 1) * stride + x + 2];
                        medianList[6] = o[(y + 2) * stride + x];
                        medianList[7] = o[(y + 2) * stride + x + 1];
                        medianList[8] = o[(y + 2) * stride + x + 2];

                        Array.Sort(medianList);

                        p[(y + 1) * stride + x + 1] = medianList[4];

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
