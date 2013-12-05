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
    class NeighbourAverage
    {
        public Bitmap original_image, proc_image;
        public BitmapData bmDataOriginal;
        public int width;
        public int height;
        public int greyTotal;
        bool isThreshold;
        Graphics g;
        FormGUI form1;
        BitmapData bmDataProc;
        int currentTrack;
        double trackbarFactor = 2.55;

        public void processNeighbourAverageInit(FormGUI form1, Bitmap image, bool isThreshold)
        {
            original_image = image;
            form1.picboxContrast.Visible = false;
            form1.picBoxProcHist.Visible = false;

            this.isThreshold = isThreshold;
            g = form1.CreateGraphics();
            this.form1 = form1;

            width = original_image.Width - 2;
            height = original_image.Height - 2;
            greyTotal = 0;

            if (isThreshold)
            {
                form1.panelTrackBar.Visible = true;
                form1.trackBarControl.Value = 50;
                currentTrack = form1.trackBarControl.Value;
                form1.textBoxControlValue.Text = currentTrack.ToString();
            }
            else
            {
                form1.panelTrackBar.Visible = false;
            }
 
            subProcessNeighbourAverage();
        }

        public void subProcessNeighbourAverage()
        {
            proc_image = (Bitmap)original_image.Clone();

            currentTrack = form1.trackBarControl.Value;

            bmDataOriginal = original_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            bmDataProc = proc_image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = bmDataOriginal.Stride;
            System.IntPtr Scan0 = bmDataOriginal.Scan0;

            System.IntPtr Scan1 = bmDataProc.Scan0;
            
            if (isThreshold)
            {
                unsafe
                {
                    byte* o = (byte*)(void*)Scan0;
                    byte* p = (byte*)(void*)Scan1;

                    for (int y = 0; y < height; ++y)
                    {
                        for (int x = 0; x < width; ++x)
                        {
                            if (o[(y + 1) * stride + x + 1] <= (currentTrack * trackbarFactor))
                            {
                                greyTotal = 0;
                                
                                greyTotal += o[y * stride + x];
                                greyTotal += o[y * stride + x + 1];
                                greyTotal += o[y * stride + x + 2];
                                greyTotal += o[(y + 1) * stride + x];
                                greyTotal += o[(y + 1) * stride + x + 2];
                                greyTotal += o[(y + 2) * stride + x];
                                greyTotal += o[(y + 2) * stride + x + 1];
                                greyTotal += o[(y + 2) * stride + x + 2];

                                greyTotal = greyTotal / 8;

                                p[(y + 1) * stride + x + 1] = (byte)greyTotal;  
                            } 
                        }
                    }
                }
            }
            else
            {                             
                unsafe
                {
                    byte* o = (byte*)(void*)Scan0;
                    byte* p = (byte*)(void*)Scan1;

                    for (int y = 0; y < height; ++y)
                    {
                        for (int x = 0; x < width; ++x)
                        {
                            greyTotal = 0;
                            
                            greyTotal += o[y * stride + x];
                            greyTotal += o[y * stride + x + 1];
                            greyTotal += o[y * stride + x + 2];
                            greyTotal += o[(y + 1) * stride + x];
                            //greyTotal += o[(y + 1) * strideOriginal + x + 1];
                            greyTotal += o[(y + 1) * stride + x + 2];
                            greyTotal += o[(y + 2) * stride + x];
                            greyTotal += o[(y + 2) * stride + x + 1];
                            greyTotal += o[(y + 2) * stride + x + 2];

                            greyTotal = greyTotal / 8;

                            p[(y + 1) * stride + x + 1] = (byte)greyTotal;          
                        }
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
