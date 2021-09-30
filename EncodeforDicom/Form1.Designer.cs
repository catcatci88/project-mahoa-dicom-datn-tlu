
namespace EncodeforDicom
{
    partial class EncodeDicom
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewImageDicomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSystaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explicitVRLittleEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.implicitVRLittleEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explicitVRBigEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGLosslessP14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGLosslessP14SV1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGLossyP1P4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quality100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quality100ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quality100ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quality100ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quality100ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.quality100ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEG2000LosslessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEG2000LossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rate5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rate10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rate20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rate40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rate80ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGLSLosslessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGLSNearLosslessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rLELosslessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dICOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maHoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaiMaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDicom = new System.Windows.Forms.ListView();
            this.columnHeaderTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.dICOMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Tep";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.openToolStripMenuItem.Text = "Mo tep";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveToolStripMenuItem.Text = "Luu tep";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.closeToolStripMenuItem.Text = "Thoat";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewImageDicomToolStripMenuItem,
            this.exportToJPGToolStripMenuItem,
            this.changeSystaxToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.toolsToolStripMenuItem.Text = "Cong cu";
            // 
            // viewImageDicomToolStripMenuItem
            // 
            this.viewImageDicomToolStripMenuItem.Enabled = false;
            this.viewImageDicomToolStripMenuItem.Name = "viewImageDicomToolStripMenuItem";
            this.viewImageDicomToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.viewImageDicomToolStripMenuItem.Text = "Xem anh";
            this.viewImageDicomToolStripMenuItem.Click += new System.EventHandler(this.viewImageDicomToolStripMenuItem_Click);
            // 
            // exportToJPGToolStripMenuItem
            // 
            this.exportToJPGToolStripMenuItem.Enabled = false;
            this.exportToJPGToolStripMenuItem.Name = "exportToJPGToolStripMenuItem";
            this.exportToJPGToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.exportToJPGToolStripMenuItem.Text = "Xuat anh dinh dang JPG";
            this.exportToJPGToolStripMenuItem.Click += new System.EventHandler(this.exportToJPGToolStripMenuItem_Click);
            // 
            // changeSystaxToolStripMenuItem
            // 
            this.changeSystaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explicitVRLittleEndianToolStripMenuItem,
            this.implicitVRLittleEndianToolStripMenuItem,
            this.explicitVRBigEndianToolStripMenuItem,
            this.jPEGLosslessP14ToolStripMenuItem,
            this.jPEGLosslessP14SV1ToolStripMenuItem,
            this.jPEGLossyP1P4ToolStripMenuItem,
            this.jPEG2000LosslessToolStripMenuItem,
            this.jPEG2000LossyToolStripMenuItem,
            this.jPEGLSLosslessToolStripMenuItem,
            this.jPEGLSNearLosslessToolStripMenuItem,
            this.rLELosslessToolStripMenuItem});
            this.changeSystaxToolStripMenuItem.Enabled = false;
            this.changeSystaxToolStripMenuItem.Name = "changeSystaxToolStripMenuItem";
            this.changeSystaxToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.changeSystaxToolStripMenuItem.Text = "Change Systax";
            // 
            // explicitVRLittleEndianToolStripMenuItem
            // 
            this.explicitVRLittleEndianToolStripMenuItem.Name = "explicitVRLittleEndianToolStripMenuItem";
            this.explicitVRLittleEndianToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.explicitVRLittleEndianToolStripMenuItem.Text = "Explicit VR Little Endian";
            this.explicitVRLittleEndianToolStripMenuItem.Click += new System.EventHandler(this.explicitVRLittleEndianToolStripMenuItem_Click);
            // 
            // implicitVRLittleEndianToolStripMenuItem
            // 
            this.implicitVRLittleEndianToolStripMenuItem.Name = "implicitVRLittleEndianToolStripMenuItem";
            this.implicitVRLittleEndianToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.implicitVRLittleEndianToolStripMenuItem.Text = "Implicit VR Little Endian";
            this.implicitVRLittleEndianToolStripMenuItem.Click += new System.EventHandler(this.implicitVRLittleEndianToolStripMenuItem_Click);
            // 
            // explicitVRBigEndianToolStripMenuItem
            // 
            this.explicitVRBigEndianToolStripMenuItem.Name = "explicitVRBigEndianToolStripMenuItem";
            this.explicitVRBigEndianToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.explicitVRBigEndianToolStripMenuItem.Text = "Explicit VR Big Endian";
            this.explicitVRBigEndianToolStripMenuItem.Click += new System.EventHandler(this.explicitVRBigEndianToolStripMenuItem_Click);
            // 
            // jPEGLosslessP14ToolStripMenuItem
            // 
            this.jPEGLosslessP14ToolStripMenuItem.Name = "jPEGLosslessP14ToolStripMenuItem";
            this.jPEGLosslessP14ToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEGLosslessP14ToolStripMenuItem.Text = "JPEG Lossless P14";
            this.jPEGLosslessP14ToolStripMenuItem.Click += new System.EventHandler(this.jPEGLosslessP14ToolStripMenuItem_Click);
            // 
            // jPEGLosslessP14SV1ToolStripMenuItem
            // 
            this.jPEGLosslessP14SV1ToolStripMenuItem.Name = "jPEGLosslessP14SV1ToolStripMenuItem";
            this.jPEGLosslessP14SV1ToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEGLosslessP14SV1ToolStripMenuItem.Text = "JPEG Lossless P14 SV1";
            this.jPEGLosslessP14SV1ToolStripMenuItem.Click += new System.EventHandler(this.jPEGLosslessP14SV1ToolStripMenuItem_Click);
            // 
            // jPEGLossyP1P4ToolStripMenuItem
            // 
            this.jPEGLossyP1P4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quality100ToolStripMenuItem,
            this.quality100ToolStripMenuItem1,
            this.quality100ToolStripMenuItem2,
            this.quality100ToolStripMenuItem3,
            this.quality100ToolStripMenuItem4,
            this.quality100ToolStripMenuItem5});
            this.jPEGLossyP1P4ToolStripMenuItem.Name = "jPEGLossyP1P4ToolStripMenuItem";
            this.jPEGLossyP1P4ToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEGLossyP1P4ToolStripMenuItem.Text = "JPEG Lossy P1 && P4";
            // 
            // quality100ToolStripMenuItem
            // 
            this.quality100ToolStripMenuItem.Name = "quality100ToolStripMenuItem";
            this.quality100ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.quality100ToolStripMenuItem.Text = "Quality: 100";
            this.quality100ToolStripMenuItem.Click += new System.EventHandler(this.quality100ToolStripMenuItem_Click);
            // 
            // quality100ToolStripMenuItem1
            // 
            this.quality100ToolStripMenuItem1.Name = "quality100ToolStripMenuItem1";
            this.quality100ToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.quality100ToolStripMenuItem1.Text = "Quality: 90";
            this.quality100ToolStripMenuItem1.Click += new System.EventHandler(this.quality100ToolStripMenuItem1_Click);
            // 
            // quality100ToolStripMenuItem2
            // 
            this.quality100ToolStripMenuItem2.Name = "quality100ToolStripMenuItem2";
            this.quality100ToolStripMenuItem2.Size = new System.Drawing.Size(170, 26);
            this.quality100ToolStripMenuItem2.Text = "Quality: 80";
            // 
            // quality100ToolStripMenuItem3
            // 
            this.quality100ToolStripMenuItem3.Name = "quality100ToolStripMenuItem3";
            this.quality100ToolStripMenuItem3.Size = new System.Drawing.Size(170, 26);
            this.quality100ToolStripMenuItem3.Text = "Quality: 70";
            // 
            // quality100ToolStripMenuItem4
            // 
            this.quality100ToolStripMenuItem4.Name = "quality100ToolStripMenuItem4";
            this.quality100ToolStripMenuItem4.Size = new System.Drawing.Size(170, 26);
            this.quality100ToolStripMenuItem4.Text = "Quality: 60";
            // 
            // quality100ToolStripMenuItem5
            // 
            this.quality100ToolStripMenuItem5.Name = "quality100ToolStripMenuItem5";
            this.quality100ToolStripMenuItem5.Size = new System.Drawing.Size(170, 26);
            this.quality100ToolStripMenuItem5.Text = "Quality: 50";
            // 
            // jPEG2000LosslessToolStripMenuItem
            // 
            this.jPEG2000LosslessToolStripMenuItem.Name = "jPEG2000LosslessToolStripMenuItem";
            this.jPEG2000LosslessToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEG2000LosslessToolStripMenuItem.Text = "JPEG 2000 Lossless";
            this.jPEG2000LosslessToolStripMenuItem.Click += new System.EventHandler(this.jPEG2000LosslessToolStripMenuItem_Click);
            // 
            // jPEG2000LossyToolStripMenuItem
            // 
            this.jPEG2000LossyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rate5ToolStripMenuItem,
            this.rate10ToolStripMenuItem,
            this.rate20ToolStripMenuItem,
            this.rate40ToolStripMenuItem,
            this.rate80ToolStripMenuItem});
            this.jPEG2000LossyToolStripMenuItem.Name = "jPEG2000LossyToolStripMenuItem";
            this.jPEG2000LossyToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEG2000LossyToolStripMenuItem.Text = "JPEG 2000 Lossy";
            // 
            // rate5ToolStripMenuItem
            // 
            this.rate5ToolStripMenuItem.Name = "rate5ToolStripMenuItem";
            this.rate5ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.rate5ToolStripMenuItem.Text = "Rate: 5";
            this.rate5ToolStripMenuItem.Click += new System.EventHandler(this.rate5ToolStripMenuItem_Click);
            // 
            // rate10ToolStripMenuItem
            // 
            this.rate10ToolStripMenuItem.Name = "rate10ToolStripMenuItem";
            this.rate10ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.rate10ToolStripMenuItem.Text = "Rate: 10";
            this.rate10ToolStripMenuItem.Click += new System.EventHandler(this.rate10ToolStripMenuItem_Click);
            // 
            // rate20ToolStripMenuItem
            // 
            this.rate20ToolStripMenuItem.Name = "rate20ToolStripMenuItem";
            this.rate20ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.rate20ToolStripMenuItem.Text = "Rate: 20";
            this.rate20ToolStripMenuItem.Click += new System.EventHandler(this.rate20ToolStripMenuItem_Click);
            // 
            // rate40ToolStripMenuItem
            // 
            this.rate40ToolStripMenuItem.Name = "rate40ToolStripMenuItem";
            this.rate40ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.rate40ToolStripMenuItem.Text = "Rate: 40";
            this.rate40ToolStripMenuItem.Click += new System.EventHandler(this.rate40ToolStripMenuItem_Click);
            // 
            // rate80ToolStripMenuItem
            // 
            this.rate80ToolStripMenuItem.Name = "rate80ToolStripMenuItem";
            this.rate80ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.rate80ToolStripMenuItem.Text = "Rate: 80";
            this.rate80ToolStripMenuItem.Click += new System.EventHandler(this.rate80ToolStripMenuItem_Click);
            // 
            // jPEGLSLosslessToolStripMenuItem
            // 
            this.jPEGLSLosslessToolStripMenuItem.Name = "jPEGLSLosslessToolStripMenuItem";
            this.jPEGLSLosslessToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEGLSLosslessToolStripMenuItem.Text = "JPEG-LS Lossless";
            this.jPEGLSLosslessToolStripMenuItem.Click += new System.EventHandler(this.jPEGLSLosslessToolStripMenuItem_Click);
            // 
            // jPEGLSNearLosslessToolStripMenuItem
            // 
            this.jPEGLSNearLosslessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.error2ToolStripMenuItem,
            this.error3ToolStripMenuItem,
            this.error4ToolStripMenuItem,
            this.error5ToolStripMenuItem,
            this.error10ToolStripMenuItem});
            this.jPEGLSNearLosslessToolStripMenuItem.Name = "jPEGLSNearLosslessToolStripMenuItem";
            this.jPEGLSNearLosslessToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.jPEGLSNearLosslessToolStripMenuItem.Text = "JPEG-LS Near Lossless";
            // 
            // error2ToolStripMenuItem
            // 
            this.error2ToolStripMenuItem.Name = "error2ToolStripMenuItem";
            this.error2ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.error2ToolStripMenuItem.Text = "Error: 2";
            // 
            // error3ToolStripMenuItem
            // 
            this.error3ToolStripMenuItem.Name = "error3ToolStripMenuItem";
            this.error3ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.error3ToolStripMenuItem.Text = "Error: 3";
            // 
            // error4ToolStripMenuItem
            // 
            this.error4ToolStripMenuItem.Name = "error4ToolStripMenuItem";
            this.error4ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.error4ToolStripMenuItem.Text = "Error: 4";
            // 
            // error5ToolStripMenuItem
            // 
            this.error5ToolStripMenuItem.Name = "error5ToolStripMenuItem";
            this.error5ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.error5ToolStripMenuItem.Text = "Error: 5";
            // 
            // error10ToolStripMenuItem
            // 
            this.error10ToolStripMenuItem.Name = "error10ToolStripMenuItem";
            this.error10ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.error10ToolStripMenuItem.Text = "Error: 10";
            // 
            // rLELosslessToolStripMenuItem
            // 
            this.rLELosslessToolStripMenuItem.Name = "rLELosslessToolStripMenuItem";
            this.rLELosslessToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.rLELosslessToolStripMenuItem.Text = "RLE Lossless";
            this.rLELosslessToolStripMenuItem.Click += new System.EventHandler(this.rLELosslessToolStripMenuItem_Click);
            // 
            // dICOMToolStripMenuItem
            // 
            this.dICOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maHoaToolStripMenuItem,
            this.giaiMaToolStripMenuItem});
            this.dICOMToolStripMenuItem.Name = "dICOMToolStripMenuItem";
            this.dICOMToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dICOMToolStripMenuItem.Text = "DICOM";
            // 
            // maHoaToolStripMenuItem
            // 
            this.maHoaToolStripMenuItem.Enabled = false;
            this.maHoaToolStripMenuItem.Name = "maHoaToolStripMenuItem";
            this.maHoaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.maHoaToolStripMenuItem.Text = "Ma hoa du lieu anh";
            this.maHoaToolStripMenuItem.Click += new System.EventHandler(this.maHoaToolStripMenuItem_Click);
            // 
            // giaiMaToolStripMenuItem
            // 
            this.giaiMaToolStripMenuItem.Enabled = false;
            this.giaiMaToolStripMenuItem.Name = "giaiMaToolStripMenuItem";
            this.giaiMaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.giaiMaToolStripMenuItem.Text = "Giai ma du lieu anh";
            this.giaiMaToolStripMenuItem.Click += new System.EventHandler(this.giaiMaToolStripMenuItem_Click);
            // 
            // lvDicom
            // 
            this.lvDicom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvDicom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTag,
            this.columnHeaderVR,
            this.columnHeaderLength,
            this.columnHeaderValue});
            this.lvDicom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDicom.Font = new System.Drawing.Font("Lato Black", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDicom.HideSelection = false;
            this.lvDicom.Location = new System.Drawing.Point(0, 28);
            this.lvDicom.Name = "lvDicom";
            this.lvDicom.Size = new System.Drawing.Size(1006, 517);
            this.lvDicom.TabIndex = 1;
            this.lvDicom.UseCompatibleStateImageBehavior = false;
            this.lvDicom.View = System.Windows.Forms.View.Details;
            this.lvDicom.SelectedIndexChanged += new System.EventHandler(this.lvDicom_SelectedIndexChanged);
            // 
            // columnHeaderTag
            // 
            this.columnHeaderTag.Text = "Tag";
            this.columnHeaderTag.Width = 250;
            // 
            // columnHeaderVR
            // 
            this.columnHeaderVR.Text = "VR";
            // 
            // columnHeaderLength
            // 
            this.columnHeaderLength.Text = "Length";
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 440;
            // 
            // boxSearch
            // 
            this.boxSearch.Location = new System.Drawing.Point(642, 5);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(199, 23);
            this.boxSearch.TabIndex = 2;
            this.boxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tim kiem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EncodeDicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxSearch);
            this.Controls.Add(this.lvDicom);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EncodeDicom";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewImageDicomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dICOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maHoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaiMaToolStripMenuItem;
        private System.Windows.Forms.ListView lvDicom;
        private System.Windows.Forms.ColumnHeader columnHeaderTag;
        private System.Windows.Forms.ColumnHeader columnHeaderVR;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.ToolStripMenuItem changeSystaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explicitVRLittleEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem implicitVRLittleEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explicitVRBigEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGLosslessP14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGLosslessP14SV1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGLossyP1P4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quality100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quality100ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quality100ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quality100ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quality100ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem quality100ToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem jPEG2000LosslessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEG2000LossyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rate5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rate10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rate20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rate40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rate80ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGLSLosslessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGLSNearLosslessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem error2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem error3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem error4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem error5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem error10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rLELosslessToolStripMenuItem;
        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Button button1;
    }
}

