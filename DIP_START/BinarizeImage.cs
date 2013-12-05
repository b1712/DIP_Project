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
    class BinarizeImage
    {
        public Bitmap original_image, proc_image;
        FormGUI form1;
        Graphics g;
        int width;
        int height;
        int currentTrack;

        public void processBinarizeInit(FormGUI form1, Bitmap image)
        {
            this.form1 = form1;
            
            form1.trackBarControl.Maximum = 255;
            form1.panelTrackBar.Visible = true;
            form1.trackBarControl.Value = 127;
            currentTrack = form1.trackBarControl.Value;
            form1.textBoxControlValue.Text = currentTrack.ToString();
            form1.picboxContrast.Visible = false;
            form1.picBoxProcHist.Visible = false;
            
            original_image = image;

            g = form1.CreateGraphics();

            width = original_image.Width;
            height = original_image.Height;

            subProcessBinarize();
        }

        public void subProcessBinarize()
        {
            proc_image = (Bitmap)original_image.Clone();

            currentTrack = form1.trackBarControl.Value;
            form1.textBoxControlValue.Text = currentTrack.ToString();

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
                        if (p[0] < currentTrack || currentTrack == 255)
                        {
                            p[0] = 0;
                        }
                        else
                        {
                            p[0] = 255;
                        }

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
