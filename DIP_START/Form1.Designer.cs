namespace DIP_START
{
    partial class FormGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSmoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighbourhoodAveragingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directSubstitutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withThresholdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pseudoColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gxGyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherMasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line45ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line45ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastStretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblProcessTitle = new System.Windows.Forms.Label();
            this.panelTrackBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarControl = new System.Windows.Forms.TrackBar();
            this.labelTrackValue = new System.Windows.Forms.Label();
            this.textBoxControlValue = new System.Windows.Forms.TextBox();
            this.labelTrack = new System.Windows.Forms.Label();
            this.picBoxOriginal = new System.Windows.Forms.PictureBox();
            this.lblOrigHist = new System.Windows.Forms.Label();
            this.lblProcHist = new System.Windows.Forms.Label();
            this.picBoxOrigHist = new System.Windows.Forms.PictureBox();
            this.picBoxProcHist = new System.Windows.Forms.PictureBox();
            this.picboxContrast = new System.Windows.Forms.PictureBox();
            this.zoomScrollBar = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxProcImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelTrackBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrigHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProcHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxContrast)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.levelsToolStripMenuItem,
            this.imageSmoothingToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.contrastStretchingToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // levelsToolStripMenuItem
            // 
            this.levelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightenToolStripMenuItem,
            this.darkenToolStripMenuItem,
            this.inverseVideoToolStripMenuItem,
            this.binarizeToolStripMenuItem});
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.levelsToolStripMenuItem.Text = "Levels";
            // 
            // brightenToolStripMenuItem
            // 
            this.brightenToolStripMenuItem.Name = "brightenToolStripMenuItem";
            this.brightenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.brightenToolStripMenuItem.Text = "Brighten";
            this.brightenToolStripMenuItem.Click += new System.EventHandler(this.brightenToolStripMenuItem_Click);
            // 
            // darkenToolStripMenuItem
            // 
            this.darkenToolStripMenuItem.Name = "darkenToolStripMenuItem";
            this.darkenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.darkenToolStripMenuItem.Text = "Darken";
            this.darkenToolStripMenuItem.Click += new System.EventHandler(this.darkenToolStripMenuItem_Click);
            // 
            // inverseVideoToolStripMenuItem
            // 
            this.inverseVideoToolStripMenuItem.Name = "inverseVideoToolStripMenuItem";
            this.inverseVideoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.inverseVideoToolStripMenuItem.Text = "Inverse Video";
            this.inverseVideoToolStripMenuItem.Click += new System.EventHandler(this.inverseVideoToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            this.binarizeToolStripMenuItem.Click += new System.EventHandler(this.binarizeToolStripMenuItem_Click);
            // 
            // imageSmoothingToolStripMenuItem
            // 
            this.imageSmoothingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianFilteringToolStripMenuItem,
            this.neighbourhoodAveragingToolStripMenuItem});
            this.imageSmoothingToolStripMenuItem.Name = "imageSmoothingToolStripMenuItem";
            this.imageSmoothingToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.imageSmoothingToolStripMenuItem.Text = "Smoothen";
            // 
            // medianFilteringToolStripMenuItem
            // 
            this.medianFilteringToolStripMenuItem.Name = "medianFilteringToolStripMenuItem";
            this.medianFilteringToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.medianFilteringToolStripMenuItem.Text = "Median Filtering";
            this.medianFilteringToolStripMenuItem.Click += new System.EventHandler(this.medianFilteringToolStripMenuItem_Click);
            // 
            // neighbourhoodAveragingToolStripMenuItem
            // 
            this.neighbourhoodAveragingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withThresholdToolStripMenuItem,
            this.withoutThresholdToolStripMenuItem});
            this.neighbourhoodAveragingToolStripMenuItem.Name = "neighbourhoodAveragingToolStripMenuItem";
            this.neighbourhoodAveragingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.neighbourhoodAveragingToolStripMenuItem.Text = "Neighbourhood Averaging";
            // 
            // withThresholdToolStripMenuItem
            // 
            this.withThresholdToolStripMenuItem.Name = "withThresholdToolStripMenuItem";
            this.withThresholdToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.withThresholdToolStripMenuItem.Text = "With Threshold";
            this.withThresholdToolStripMenuItem.Click += new System.EventHandler(this.withThresholdToolStripMenuItem_Click);
            // 
            // withoutThresholdToolStripMenuItem
            // 
            this.withoutThresholdToolStripMenuItem.Name = "withoutThresholdToolStripMenuItem";
            this.withoutThresholdToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.withoutThresholdToolStripMenuItem.Text = "Without Threshold";
            this.withoutThresholdToolStripMenuItem.Click += new System.EventHandler(this.withoutThresholdToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robertsGradientToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.otherMasksToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // robertsGradientToolStripMenuItem
            // 
            this.robertsGradientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directSubstitutionToolStripMenuItem,
            this.withThresholdToolStripMenuItem1,
            this.pseudoColourToolStripMenuItem});
            this.robertsGradientToolStripMenuItem.Name = "robertsGradientToolStripMenuItem";
            this.robertsGradientToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.robertsGradientToolStripMenuItem.Text = "Robert\'s Gradient";
            // 
            // directSubstitutionToolStripMenuItem
            // 
            this.directSubstitutionToolStripMenuItem.Name = "directSubstitutionToolStripMenuItem";
            this.directSubstitutionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.directSubstitutionToolStripMenuItem.Text = "Direct Substitution";
            this.directSubstitutionToolStripMenuItem.Click += new System.EventHandler(this.directSubstitutionToolStripMenuItem_Click);
            // 
            // withThresholdToolStripMenuItem1
            // 
            this.withThresholdToolStripMenuItem1.Name = "withThresholdToolStripMenuItem1";
            this.withThresholdToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.withThresholdToolStripMenuItem1.Text = "With Threshold";
            this.withThresholdToolStripMenuItem1.Click += new System.EventHandler(this.withThresholdToolStripMenuItem1_Click);
            // 
            // pseudoColourToolStripMenuItem
            // 
            this.pseudoColourToolStripMenuItem.Name = "pseudoColourToolStripMenuItem";
            this.pseudoColourToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pseudoColourToolStripMenuItem.Text = "Pseudo Colour";
            this.pseudoColourToolStripMenuItem.Click += new System.EventHandler(this.pseudoColourToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gxToolStripMenuItem,
            this.gyToolStripMenuItem,
            this.gxGyToolStripMenuItem});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            // 
            // gxToolStripMenuItem
            // 
            this.gxToolStripMenuItem.Name = "gxToolStripMenuItem";
            this.gxToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gxToolStripMenuItem.Text = "Gx";
            this.gxToolStripMenuItem.Click += new System.EventHandler(this.gxToolStripMenuItem_Click);
            // 
            // gyToolStripMenuItem
            // 
            this.gyToolStripMenuItem.Name = "gyToolStripMenuItem";
            this.gyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gyToolStripMenuItem.Text = "Gy";
            this.gyToolStripMenuItem.Click += new System.EventHandler(this.gyToolStripMenuItem_Click);
            // 
            // gxGyToolStripMenuItem
            // 
            this.gxGyToolStripMenuItem.Name = "gxGyToolStripMenuItem";
            this.gxGyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gxGyToolStripMenuItem.Text = "Gx + Gy";
            this.gxGyToolStripMenuItem.Click += new System.EventHandler(this.gxGyToolStripMenuItem_Click);
            // 
            // otherMasksToolStripMenuItem
            // 
            this.otherMasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplacianToolStripMenuItem,
            this.pointToolStripMenuItem,
            this.lineVerticalToolStripMenuItem,
            this.lineHorizontalToolStripMenuItem,
            this.line45ToolStripMenuItem,
            this.line45ToolStripMenuItem1});
            this.otherMasksToolStripMenuItem.Name = "otherMasksToolStripMenuItem";
            this.otherMasksToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.otherMasksToolStripMenuItem.Text = "Other Masks";
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pointToolStripMenuItem.Text = "Point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // lineVerticalToolStripMenuItem
            // 
            this.lineVerticalToolStripMenuItem.Name = "lineVerticalToolStripMenuItem";
            this.lineVerticalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lineVerticalToolStripMenuItem.Text = "Line Vertical";
            this.lineVerticalToolStripMenuItem.Click += new System.EventHandler(this.lineVerticalToolStripMenuItem_Click);
            // 
            // lineHorizontalToolStripMenuItem
            // 
            this.lineHorizontalToolStripMenuItem.Name = "lineHorizontalToolStripMenuItem";
            this.lineHorizontalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lineHorizontalToolStripMenuItem.Text = "Line Horizontal";
            this.lineHorizontalToolStripMenuItem.Click += new System.EventHandler(this.lineHorizontalToolStripMenuItem_Click);
            // 
            // line45ToolStripMenuItem
            // 
            this.line45ToolStripMenuItem.Name = "line45ToolStripMenuItem";
            this.line45ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.line45ToolStripMenuItem.Text = "Line +45";
            this.line45ToolStripMenuItem.Click += new System.EventHandler(this.line45ToolStripMenuItem_Click);
            // 
            // line45ToolStripMenuItem1
            // 
            this.line45ToolStripMenuItem1.Name = "line45ToolStripMenuItem1";
            this.line45ToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.line45ToolStripMenuItem1.Text = "Line -45";
            this.line45ToolStripMenuItem1.Click += new System.EventHandler(this.line45ToolStripMenuItem1_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equalizationToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // contrastStretchingToolStripMenuItem
            // 
            this.contrastStretchingToolStripMenuItem.Name = "contrastStretchingToolStripMenuItem";
            this.contrastStretchingToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.contrastStretchingToolStripMenuItem.Text = "Contrast Stretching";
            this.contrastStretchingToolStripMenuItem.Click += new System.EventHandler(this.contrastStretchingToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.toolStripMenuItem2});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem2.Text = "100%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(187, 791);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(81, 16);
            this.lblProcess.TabIndex = 6;
            this.lblProcess.Text = "Placeholder";
            // 
            // lblProcessTitle
            // 
            this.lblProcessTitle.AutoSize = true;
            this.lblProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessTitle.Location = new System.Drawing.Point(21, 791);
            this.lblProcessTitle.Name = "lblProcessTitle";
            this.lblProcessTitle.Size = new System.Drawing.Size(135, 16);
            this.lblProcessTitle.TabIndex = 5;
            this.lblProcessTitle.Text = "Selected Process:";
            // 
            // panelTrackBar
            // 
            this.panelTrackBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrackBar.Controls.Add(this.label1);
            this.panelTrackBar.Controls.Add(this.trackBarControl);
            this.panelTrackBar.Controls.Add(this.labelTrackValue);
            this.panelTrackBar.Controls.Add(this.textBoxControlValue);
            this.panelTrackBar.Controls.Add(this.labelTrack);
            this.panelTrackBar.Location = new System.Drawing.Point(415, 606);
            this.panelTrackBar.Name = "panelTrackBar";
            this.panelTrackBar.Size = new System.Drawing.Size(298, 134);
            this.panelTrackBar.TabIndex = 4;
            this.panelTrackBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adjust Value";
            // 
            // trackBarControl
            // 
            this.trackBarControl.LargeChange = 10;
            this.trackBarControl.Location = new System.Drawing.Point(52, 29);
            this.trackBarControl.Maximum = 255;
            this.trackBarControl.Name = "trackBarControl";
            this.trackBarControl.Size = new System.Drawing.Size(223, 45);
            this.trackBarControl.SmallChange = 5;
            this.trackBarControl.TabIndex = 2;
            this.trackBarControl.TickFrequency = 10;
            this.trackBarControl.Value = 50;
            this.trackBarControl.Scroll += new System.EventHandler(this.trackBarControl_Scroll);
            // 
            // labelTrackValue
            // 
            this.labelTrackValue.AutoSize = true;
            this.labelTrackValue.Location = new System.Drawing.Point(8, 77);
            this.labelTrackValue.Name = "labelTrackValue";
            this.labelTrackValue.Size = new System.Drawing.Size(80, 13);
            this.labelTrackValue.TabIndex = 1;
            this.labelTrackValue.Text = "Trackbar Value";
            // 
            // textBoxControlValue
            // 
            this.textBoxControlValue.Location = new System.Drawing.Point(109, 74);
            this.textBoxControlValue.Name = "textBoxControlValue";
            this.textBoxControlValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxControlValue.TabIndex = 3;
            this.textBoxControlValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Location = new System.Drawing.Point(8, 38);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(43, 13);
            this.labelTrack.TabIndex = 0;
            this.labelTrack.Text = "Amount";
            // 
            // picBoxOriginal
            // 
            this.picBoxOriginal.Location = new System.Drawing.Point(12, 47);
            this.picBoxOriginal.Name = "picBoxOriginal";
            this.picBoxOriginal.Size = new System.Drawing.Size(512, 512);
            this.picBoxOriginal.TabIndex = 9;
            this.picBoxOriginal.TabStop = false;
            // 
            // lblOrigHist
            // 
            this.lblOrigHist.AutoSize = true;
            this.lblOrigHist.Location = new System.Drawing.Point(9, 581);
            this.lblOrigHist.Name = "lblOrigHist";
            this.lblOrigHist.Size = new System.Drawing.Size(92, 13);
            this.lblOrigHist.TabIndex = 10;
            this.lblOrigHist.Text = "Original Histogram";
            // 
            // lblProcHist
            // 
            this.lblProcHist.AutoSize = true;
            this.lblProcHist.Location = new System.Drawing.Point(813, 581);
            this.lblProcHist.Name = "lblProcHist";
            this.lblProcHist.Size = new System.Drawing.Size(107, 13);
            this.lblProcHist.TabIndex = 11;
            this.lblProcHist.Text = "Processed Histogram";
            // 
            // picBoxOrigHist
            // 
            this.picBoxOrigHist.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picBoxOrigHist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxOrigHist.Location = new System.Drawing.Point(12, 597);
            this.picBoxOrigHist.Name = "picBoxOrigHist";
            this.picBoxOrigHist.Size = new System.Drawing.Size(256, 160);
            this.picBoxOrigHist.TabIndex = 12;
            this.picBoxOrigHist.TabStop = false;
            // 
            // picBoxProcHist
            // 
            this.picBoxProcHist.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picBoxProcHist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxProcHist.Location = new System.Drawing.Point(816, 597);
            this.picBoxProcHist.Name = "picBoxProcHist";
            this.picBoxProcHist.Size = new System.Drawing.Size(256, 160);
            this.picBoxProcHist.TabIndex = 13;
            this.picBoxProcHist.TabStop = false;
            // 
            // picboxContrast
            // 
            this.picboxContrast.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picboxContrast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxContrast.Location = new System.Drawing.Point(437, 582);
            this.picboxContrast.Name = "picboxContrast";
            this.picboxContrast.Size = new System.Drawing.Size(256, 256);
            this.picboxContrast.TabIndex = 15;
            this.picboxContrast.TabStop = false;
            this.picboxContrast.Click += new System.EventHandler(this.picboxContrast_Click);
            // 
            // zoomScrollBar
            // 
            this.zoomScrollBar.LargeChange = 1;
            this.zoomScrollBar.Location = new System.Drawing.Point(746, 606);
            this.zoomScrollBar.Maximum = 5;
            this.zoomScrollBar.Minimum = 1;
            this.zoomScrollBar.Name = "zoomScrollBar";
            this.zoomScrollBar.Size = new System.Drawing.Size(273, 32);
            this.zoomScrollBar.TabIndex = 16;
            this.zoomScrollBar.Value = 5;
            this.zoomScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.zoomScrollBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picBoxProcImage);
            this.panel1.Location = new System.Drawing.Point(600, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 544);
            this.panel1.TabIndex = 17;
            // 
            // picBoxProcImage
            // 
            this.picBoxProcImage.Location = new System.Drawing.Point(0, 0);
            this.picBoxProcImage.Name = "picBoxProcImage";
            this.picBoxProcImage.Size = new System.Drawing.Size(516, 516);
            this.picBoxProcImage.TabIndex = 0;
            this.picBoxProcImage.TabStop = false;
            // 
            // FormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 850);
            this.Controls.Add(this.zoomScrollBar);
            this.Controls.Add(this.picboxContrast);
            this.Controls.Add(this.picBoxProcHist);
            this.Controls.Add(this.picBoxOrigHist);
            this.Controls.Add(this.lblProcHist);
            this.Controls.Add(this.lblOrigHist);
            this.Controls.Add(this.picBoxOriginal);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.panelTrackBar);
            this.Controls.Add(this.lblProcessTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FormGUI";
            this.ShowIcon = false;
            this.Text = "DIP GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTrackBar.ResumeLayout(false);
            this.panelTrackBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrigHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProcHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxContrast)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TrackBar trackBarControl;
        private System.Windows.Forms.ToolStripMenuItem imageSmoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighbourhoodAveragingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutThresholdToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxControlValue;
        public System.Windows.Forms.Label labelTrackValue;
        public System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblProcessTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelTrackBar;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertsGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directSubstitutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withThresholdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pseudoColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gxGyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherMasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem line45ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem line45ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        public System.Windows.Forms.PictureBox picBoxOriginal;
        public System.Windows.Forms.Label lblOrigHist;
        public System.Windows.Forms.Label lblProcHist;
        public System.Windows.Forms.PictureBox picBoxOrigHist;
        public System.Windows.Forms.PictureBox picBoxProcHist;
        public System.Windows.Forms.PictureBox picboxContrast;
        private System.Windows.Forms.ToolStripMenuItem contrastStretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.HScrollBar zoomScrollBar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox picBoxProcImage;
    }
}

