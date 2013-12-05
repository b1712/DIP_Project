using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
//using System.IO;
//using System.Text;
//using System.Windows.Forms;

namespace DIP_START
{
    public class Bins
    {
        //List<int> bins = new List<int>(256);

        public static int[] populateBins(Bitmap img)
        {
            int[] bins = new int[256];
            int width;
            int height;
            int binIndex;
            
            //bins.Clear();
            binIndex = 0;
            width = img.Width;
            height = img.Height;

            BitmapData bmData = img.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        binIndex = p[y * stride + x];

                        bins[binIndex]++;

                    }

                }
            }

            img.UnlockBits(bmData);

            return bins;
        }
    }
}
