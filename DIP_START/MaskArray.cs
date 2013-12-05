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
    class MaskArray
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
        int[] maskArray;
        bool firstPass = false;
        int trackMax = 0;

        public void processMaskArray(FormGUI form1, Bitmap image, int[] maskArray)
        {
            original_image = image;
            g = form1.CreateGraphics();
            this.form1 = form1;
            this.maskArray = maskArray;

            width = original_image.Width - 2;
            height = original_image.Height - 2;
            greyTotal = 0;

            firstPass = true;

            subProcessMaskArray();
        }

        public void subProcessMaskArray()
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
                        greyTotal = 0;  
                        
                        greyTotal += maskArray[0] * o[y * stride + x];
                        greyTotal += maskArray[1] * o[y * stride + x + 1];
                        greyTotal += maskArray[2] * o[y * stride + x + 2];
                        greyTotal += maskArray[3] * o[(y + 1) * stride + x];
                        greyTotal += maskArray[4] * o[(y + 1) * stride + x + 1];
                        greyTotal += maskArray[5] * o[(y + 1) * stride + x + 2];
                        greyTotal += maskArray[6] * o[(y + 2) * stride + x];
                        greyTotal += maskArray[7] * o[(y + 2) * stride + x + 1];
                        greyTotal += maskArray[8] * o[(y + 2) * stride + x + 2];

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
                form1.trackBarControl.Value = trackMax/2;
                form1.labelTrackValue.Text = (trackMax / 2).ToString();
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