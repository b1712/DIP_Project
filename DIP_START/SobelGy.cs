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
    class SobelGy
    {
        public Bitmap original_image, proc_image;
        public BitmapData bmDataOriginal;
        public int width;
        public int height;
        public int greyTotal;
        Graphics g;
        FormGUI form1;
        BitmapData bmDataProc;
        int currentTrack;
        bool firstPass = false;
        int trackMax = 0;

        public void processSobelGYInit(FormGUI form1, Bitmap image)
        {
            original_image = image;
            form1.picboxContrast.Visible = false;
            form1.picBoxProcHist.Visible = false;

            g = form1.CreateGraphics();
            this.form1 = form1;

            width = original_image.Width - 2;
            height = original_image.Height - 2;
            greyTotal = 0;
            
            firstPass = true;

            subProcessSobelGY();
        }

        public void subProcessSobelGY()
        {
            if (firstPass)
            {
                trackMax = 0;
            }
            else
            {
                currentTrack = form1.trackBarControl.Value;
            }

            proc_image = (Bitmap)original_image.Clone();


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
                        //Gy = [c + 2f + i] - [a + 2d + g] 

                        greyTotal = Math.Abs((o[y * stride + x + 2] + (2 * (o[(y + 1) * stride + x + 2])) + o[(y + 2) * stride + x + 2]) -
                                            (o[y * stride + x] + (2 * (o[(y + 1) * stride + x])) + o[(y + 2) * stride + x]));

                        if (firstPass)
                        {
                            if (trackMax < greyTotal)
                            {
                                trackMax = greyTotal;
                            }

                            if (greyTotal > 100)
                            {
                                p[(y + 1) * stride + x + 1] = 255;
                            }
                            else
                            {
                                p[(y + 1) * stride + x + 1] = 0;
                            }
                        }
                        else
                        {
                            if (greyTotal > currentTrack)
                            {
                                p[(y + 1) * stride + x + 1] = 255;
                            }
                            else
                            {
                                p[(y + 1) * stride + x + 1] = 0;
                            }
                        }
                    }
                }
            }

            if (firstPass)
            {
                form1.panelTrackBar.Visible = true;
                form1.trackBarControl.Maximum = trackMax;
                form1.trackBarControl.TickFrequency = trackMax / 20;
                form1.trackBarControl.Value = 100;
                form1.labelTrackValue.Text = "100";
            }

            original_image.UnlockBits(bmDataOriginal);
            proc_image.UnlockBits(bmDataProc);

            form1.picBoxProcImage.Image = proc_image;
            form1.Controls.Add(form1.picBoxProcImage);
            form1.picBoxProcImage.Visible = true;

            firstPass = false;
        }

    }
}
