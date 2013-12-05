using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DIP_START
{
    class ZoomIn
    {
        Bitmap original_image;
        FormGUI form1;
        int factor;

        public void doZoomIn(FormGUI form1, Bitmap image)
        {
            original_image = image;
            this.form1 = form1;
            form1.zoomScrollBar.Visible = true;
            form1.picBoxProcImage.Image = original_image;
            //form1.panel1.Controls.Add(form1.picBoxProcImage);
            form1.zoomScrollBar.Value = 1;
            factor = 1;
            form1.picBoxProcImage.Visible = true;
            //form1.picBoxProcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            //form1.panel1.Controls.Add(form1.picBoxProcImage);
            doZoomInSub(factor);
        }

        public void doZoomInSub(int factor)
        {
            this.factor = factor;

            //form1.picBoxProcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            //form1.picBoxProcImage.Width = Convert.ToInt32(original_image.Width * factor);
            //form1.picBoxProcImage.Height = Convert.ToInt32(original_image.Height * factor);

            form1.picBoxProcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            Bitmap bm = new Bitmap(original_image, Convert.ToInt32(original_image.Width * factor), Convert.ToInt32(original_image.Height * factor));

            //form1.picBoxProcImage.Height = height * zoomFactor;
            //form1.picBoxProcImage.Width = width * zoomFactor;
            form1.picBoxProcImage.Image = bm;
            //form1.picBoxProcImage.Dock = DockStyle.None;

            //form1.picBoxProcImage.Image =

            
            //form1.panel1.Controls.Add(form1.picBoxProcImage);
            form1.panel1.Visible = true;
            
        }
    }
}
