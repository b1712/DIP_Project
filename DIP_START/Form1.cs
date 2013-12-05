using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
//using System.Drawing.Drawing2D;

namespace DIP_START
{
    //http://stackoverflow.com/questions/4187524/draw-lines-on-a-picturebox-in-c-sharp

    public partial class FormGUI : Form
    {
        public Bitmap original_image, proc_image;
        public int currentTrack = 127;
        InverseVideo inverse;
        DarkenImage darken;
        BrightImage brighten;
        BinarizeImage binary;
        MedianFilter median;
        RobertsDirectSubstitution robertsDirect;
        NeighbourAverage neighbourAverage;
        RobertsThreshold robertsThreshold;
        RobertsPseudo robertsPseudo;
        SobelGx sobelGx;
        SobelGy sobelGy;
        SobelGxGy sobelGxGy;
        HistogramOriginal hist = new HistogramOriginal();
        HistogramEqualized histEq;
        public String userProcess = "";
        MaskArray mask;
        ContrastStretching contrastStreting = new ContrastStretching();
        ZoomIn zoomIn;

        public FormGUI()
        {
            InitializeComponent();
            original_image = null;
            proc_image = null;
            setWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (original_image != null)
            {
                this.picBoxOriginal.Image = original_image;
                this.Controls.Add(picBoxOriginal);
                hist.processOriginalHistogram(this, original_image);
                
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            setWindow();

            if (original_image != null)
            {
                this.Invalidate();
            }

            // show the openFile dialog box            
            Graphics g = this.CreateGraphics();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original_image = new Bitmap(openFileDialog1.FileName);
            }

            this.lblProcessTitle.Visible = true;
            this.picBoxOriginal.Visible = true;
            this.lblOrigHist.Visible = true;
            this.picBoxOrigHist.Visible = true;
            this.picBoxOriginal.Image = original_image;
            this.Controls.Add(picBoxOriginal);
            hist.processOriginalHistogram(this, original_image);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        public void trackBarControl_Scroll(object sender, System.EventArgs e)
        {

            if (trackBarControl.Value != currentTrack)
            {
                
                currentTrack = trackBarControl.Value;
                textBoxControlValue.Text = currentTrack.ToString();

                switch (userProcess)
                {
                    case "Binarize Image":
                        {
                            binary.subProcessBinarize();
                            break;
                        }
                    case "Neighbourhood Average - Threshold":
                        {
                            neighbourAverage.subProcessNeighbourAverage();
                            break;
                        }
                    case "Roberts Gradient - With Threshold":
                        {
                            robertsThreshold.subProcessRobertsThreshold();
                            break;
                        }
                    case "Roberts Gradient - Pseudo Colour":
                        {
                            robertsPseudo.subProcessRobertsPseudo();
                            break;
                        }
                    case "Sobel - Gx":
                        {
                            sobelGx.subProcessSobelGX();
                            break;
                        }
                    case "Sobel - Gy":
                        {
                            sobelGy.subProcessSobelGY();
                            break;
                        }
                    case "Sobel - Gx + Gy":
                        {
                            sobelGxGy.subProcessSobelGXGY();
                            break;
                        }
                    case "Laplacian Mask":
                        {
                            mask.subProcessMaskArray();
                            break;
                        }
                    case "Point Mask":
                        {
                            mask.subProcessMaskArray();
                            break;
                        }
                    case "Vertical Line Mask":
                        {
                            mask.subProcessMaskArray();
                            break;
                        }
                    case "Horizontal Line Mask":
                        {
                            mask.subProcessMaskArray();
                            break;
                        }
                    case "Plus 45 Line Mask":
                        {
                            mask.subProcessMaskArray();
                            break;
                        }
                    case "Minus 45 Line Mask":
                        {
                            mask.subProcessMaskArray();
                            break;
                        } 
                }
            }
        }

        private void brightenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //g.DrawImage(original_image, r);
            this.panelTrackBar.Visible = false;
            
            userProcess = "Brighten Image";

            lblProcess.Text = userProcess;
            lblProcess.Visible = true;

            brighten = new BrightImage();

            brighten.processBrighten(this, original_image);
        }

        private void darkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelTrackBar.Visible = false;
            
            userProcess = "Darken Image";

            lblProcess.Text = userProcess;
            lblProcess.Visible = true;

            darken = new DarkenImage();

            darken.processDarken(this, original_image);
        }

        private void inverseVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelTrackBar.Visible = false;
            
            userProcess = "Inverse Video";

            lblProcess.Text = userProcess;
            
            inverse = new InverseVideo();

            inverse.processInverse(this, original_image);
        }

        private void binarizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Binarize Image";

            lblProcess.Text = userProcess;
            lblProcess.Visible = true;

            binary = new BinarizeImage();

            binary.processBinarizeInit(this, original_image);
        }

        private void medianFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelTrackBar.Visible = false;
            
            userProcess = "Smooth Image - Median Filter";

            lblProcess.Text = userProcess;
            lblProcess.Visible = true;
            
            median = new MedianFilter();

            median.processMedian(this, original_image); 
        }

        //Neighbourhood Averaging with Threshold
        private void withThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Neighbourhood Average - Threshold";

            lblProcess.Text = userProcess;
            lblProcess.Visible = true;

            neighbourAverage = new NeighbourAverage();

            neighbourAverage.processNeighbourAverageInit(this, original_image, true);
        }

        //Neighbourhood Averaging without Threshold
        private void withoutThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userProcess = "Neighbourhood Average";

            lblProcess.Text = userProcess;
            lblProcess.Visible = true;
            
            neighbourAverage = new NeighbourAverage();

            neighbourAverage.processNeighbourAverageInit(this, original_image, false);
        }

        private void directSubstitutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userProcess = "Roberts Gradient - Direct Substitution";

            lblProcess.Text = userProcess;
            
            robertsDirect = new RobertsDirectSubstitution();

            robertsDirect.processRobertsDirect(this, original_image);
        }

        private void withThresholdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);
            
            userProcess = "Roberts Gradient - With Threshold";

            lblProcess.Text = userProcess;

            robertsThreshold = new RobertsThreshold();

            robertsThreshold.processRobertsThresholdInit(this, original_image);
        }

        private void pseudoColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Roberts Gradient - Pseudo Colour";

            lblProcess.Text = userProcess;

            robertsPseudo = new RobertsPseudo();

            robertsPseudo.processRobertsPseudoInit(this, original_image);
        }

        private void gxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Sobel - Gx";

            lblProcess.Text = userProcess;

            sobelGx = new SobelGx();

            sobelGx.processSobelGXInit(this, original_image);
        }

        private void gyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Sobel - Gy";

            lblProcess.Text = userProcess;

            sobelGy = new SobelGy();

            sobelGy.processSobelGYInit(this, original_image);
        }

        private void gxGyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Sobel - Gx + Gy";

            lblProcess.Text = userProcess;

            sobelGxGy = new SobelGxGy();

            sobelGxGy.processSobelGXGYInit(this, original_image);
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Laplacian Mask";

            lblProcess.Text = userProcess;

            mask = new MaskArray();

            int [] laplacianArray = new int[]{0, 1, 0, 1, -4, 1, 0, 1, 0};
            mask.processMaskArray(this, original_image, laplacianArray);
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Point Mask";

            lblProcess.Text = userProcess;

            mask = new MaskArray();

            int[] pointArray = new int[] { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
            mask.processMaskArray(this, original_image, pointArray);
        }

        private void lineVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Vertical Line Mask";

            lblProcess.Text = userProcess;

            mask = new MaskArray();

            int[] verticalLineArray = new int[] { -1, 2, -1, -1, 2, -1, -1, 2, -1 };
            mask.processMaskArray(this, original_image, verticalLineArray);
        }

        private void lineHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Horizontal Line Mask";

            lblProcess.Text = userProcess;

            mask = new MaskArray();

            int[] horizontalLineArray = new int[] { -1, -1, -1, 2, 2, 2, -1, -1, -1 };
            mask.processMaskArray(this, original_image, horizontalLineArray);
        }

        private void line45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Plus 45 Line Mask";

            lblProcess.Text = userProcess;

            mask = new MaskArray();

            int[] plus45LineArray = new int[] { -1, -1, 2, -1, 2, -1, 2, -1, -1 };
            mask.processMaskArray(this, original_image, plus45LineArray);
        }
        
        private void line45ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.trackBarControl.Scroll -= new System.EventHandler(this.trackBarControl_Scroll);
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);

            userProcess = "Minus 45 Line Mask";

            lblProcess.Text = userProcess;

            mask = new MaskArray();

            int[] minus45LineArray = new int[] { 2, -1, -1, -1, 2, -1, -1, -1, 2 };
            mask.processMaskArray(this, original_image, minus45LineArray);
        }

        private void originalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hist = new HistogramOriginal();
            hist.processOriginalHistogram(this, original_image);
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userProcess = "Histogram Equalisation";

            lblProcess.Text = userProcess;
            
            histEq = new HistogramEqualized();
            histEq.processEqualisedHistogram(this, original_image);
        }

        private void contrastStretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userProcess = "Contrast Stretching";

            lblProcess.Text = userProcess;
            
            contrastStreting.processContrastStretching(this, original_image);
        }

        private void picboxContrast_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = new Point();
            
            if (me.Button == MouseButtons.Left)
            {
                coordinates = me.Location;
            }
            
            contrastStreting.processContrastBox(coordinates);
            Console.WriteLine(coordinates);            
        }

        public void setWindow()
        {
            this.picBoxOriginal.Visible = false;
            this.picBoxProcImage.Visible = false;
            this.picBoxOrigHist.Visible = false;
            this.picBoxProcHist.Visible = false;
            this.panelTrackBar.Visible = false;
            this.lblOrigHist.Visible = false;
            this.lblProcHist.Visible = false;
            this.lblProcessTitle.Visible = false;
            this.lblProcess.Text = "";
            this.picboxContrast.Visible = false;
            this.picboxContrast.Visible = false;
            this.zoomScrollBar.Visible = false;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoomScrollBar.Visible = true;

            zoomIn = new ZoomIn();
            zoomIn.doZoomIn(this, original_image);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoomScrollBar.Visible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.zoomScrollBar.Visible = true;
        }

        private void zoomScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int value = this.zoomScrollBar.Value;
            zoomIn.doZoomInSub(value);
        }

        /*****************************************************************************************/  
        
    }

}

