using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace DIP_START
{
    public class ContrastStretching
    {
        FormGUI form1;
        Point point1;
        Point point2;
        Point newPoint;
        Bitmap original_image;
        int[] contrastValues;
        Bitmap proc_image;
        
        public void processContrastStretching(FormGUI form1, Bitmap image)
        {
            this.form1 = form1;
            original_image = image;
            point1 = new Point(60, 100);
            point2 = new Point(180, 150);
            newPoint.X = point1.X;
            newPoint.Y = point1.Y;
            processContrastBox(newPoint);
            form1.panel1.Visible = false;
        }

        public void processContrastBox(Point newPoint)
        {
            this.newPoint = newPoint;

            var b = new Bitmap(1, 1);
            b.SetPixel(0, 0, Color.White);

            var map = new Bitmap(b, 256, 256);

            Graphics gb = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Blue, 1.5f);

            Matrix mm = new Matrix();
            mm = new Matrix(1, 0, 0, -1, 0, 256);
            gb.Transform = mm;

            if (point1 != newPoint)
            {
                newPoint.Y = map.Height - newPoint.Y;
                
                if ((Math.Abs(point1.X - newPoint.X) + Math.Abs(point1.Y - newPoint.Y)) <
                (Math.Abs(point2.X - newPoint.X) + Math.Abs(point2.Y - newPoint.Y)))
                {
                    if ((newPoint.X > point2.X) || (newPoint.Y > point2.Y))
                    {
                        MessageBox.Show("Sorry out of range.");
                    }
                    else
                    {
                        point1 = newPoint;
                    }
                }
                else
                {
                    if ((newPoint.X < point1.X) || (newPoint.Y < point1.Y))
                    {
                        MessageBox.Show("Sorry out of range.");
                    }
                    else
                    {
                        point2 = newPoint;
                    }
                }
            }
            
            gb.DrawLine(pen, 0, 0, point1.X, point1.Y);
            gb.DrawLine(pen, point1.X, point1.Y, point2.X, point2.Y);
            gb.DrawLine(pen, point2.X, point2.Y, map.Width, map.Height);

            form1.picboxContrast.Image = map;
            pen.Dispose();
            gb.Dispose();

            form1.Controls.Add(form1.picboxContrast);
            form1.picboxContrast.Visible = true;

            calculateContrastValues();
        }

        private void calculateContrastValues()
        {
            float slope1, slope2, slope3;
            contrastValues = new int[256];

            slope1 = (float)point1.Y / (float)point1.X;
            slope2 = (float)(point2.Y - point1.Y) / (float)(point2.X - point1.X);
            slope3 = (float)(255 - point2.Y) / (float)(255 - point2.X);


            //int maxIndex1 = (int)(255 / form1.picboxContrast.Height) * point1.X;
            //for (int i = 0; i < maxIndex1; i++)
            //{
            //    contrastValues[i] = (int)(slope1 * i);
            //}

            //int maxIndex2 = (int)(255 / form1.picboxContrast.Height) * point2.X;
            //for (int i = maxIndex1; i < maxIndex2; i++)
            //{
            //    contrastValues[i] = (int)(slope2 * i);
            //}

            //int maxIndex3 = form1.picboxContrast.Height;
            //for (int i = maxIndex2; i < maxIndex3; i++)
            //{
            //    contrastValues[i] = (int)(slope3 * i);
            //}

            for (int i = 0; i < 256; i++)
            {
                contrastValues[i] = (int)(slope1 * i);
            }

            for (int i = point1.X; i < point2.X; i++)
            {
                contrastValues[i] = (int)(slope2 * i);
            }

            for (int i = point2.X; i < 256; i++)
            {
                contrastValues[i] = (int)(slope3 * i);
            }

            drawProcImage();
        }

        private void drawProcImage()
        {
            int width = original_image.Width;
            int height = original_image.Height;

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
                        p[0] = (byte)contrastValues[p[0]];

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
