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
    class InverseVideo
    {
        public Bitmap original_image, proc_image;
        //public int[] bins = new int[256];

        public void processInverse(FormGUI form1, Bitmap image)
        {
            original_image = image;
            form1.picboxContrast.Visible = false;
            form1.picBoxProcHist.Visible = false;
            
            Graphics g = form1.CreateGraphics();

            int width = original_image.Width;
            int height = original_image.Height;

            //Rectangle r = new Rectangle(535, 50, original_image.Width, original_image.Height);
            //Rectangle r2 = new Rectangle(0, 0, original_image.Width, original_image.Height);

            //Rectangle r3 = new Rectangle(10, 50, original_image.Width, original_image.Height);
            //g.DrawImage(original_image, r3);

            proc_image = (Bitmap)original_image.Clone();


            BitmapData bmData = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }

                }
            }

            proc_image.UnlockBits(bmData);

            form1.picBoxProcImage.Image = proc_image;
            form1.Controls.Add(form1.picBoxProcImage);
            form1.picBoxProcImage.Visible = true;
        }

    }
}
