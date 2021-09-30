
namespace EncodeforDicoms
{
    partial class DisplayForm
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

        private void InitializeComponent()
        {
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.patientName = new System.Windows.Forms.Label();
            this.patientID = new System.Windows.Forms.Label();
            this.StudyInstanceUID = new System.Windows.Forms.Label();
            this.StudyDescription = new System.Windows.Forms.Label();
            this.InstitutionName = new System.Windows.Forms.Label();
            this.InstitutionAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDisplay
            // 
            this.pbDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDisplay.Location = new System.Drawing.Point(0, 0);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(284, 262);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDisplay.TabIndex = 0;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDoubleClick);
            this.pbDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pbDisplay.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.pbDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pbDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // patientName
            // 
            this.patientName.AutoSize = true;
            this.patientName.BackColor = System.Drawing.SystemColors.Control;
            this.patientName.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.ForeColor = System.Drawing.Color.Tomato;
            this.patientName.Location = new System.Drawing.Point(-3, 11);
            this.patientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(100, 17);
            this.patientName.TabIndex = 2;
            this.patientName.Text = "PatientName";
            this.patientName.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientID
            // 
            this.patientID.AutoSize = true;
            this.patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID.ForeColor = System.Drawing.Color.White;
            this.patientID.Location = new System.Drawing.Point(-3, 27);
            this.patientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(65, 17);
            this.patientID.TabIndex = 3;
            this.patientID.Text = "PatientID";
            // 
            // StudyInstanceUID
            // 
            this.StudyInstanceUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudyInstanceUID.AutoSize = true;
            this.StudyInstanceUID.ForeColor = System.Drawing.Color.White;
            this.StudyInstanceUID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudyInstanceUID.Location = new System.Drawing.Point(3, 15);
            this.StudyInstanceUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudyInstanceUID.Name = "StudyInstanceUID";
            this.StudyInstanceUID.Size = new System.Drawing.Size(94, 13);
            this.StudyInstanceUID.TabIndex = 4;
            this.StudyInstanceUID.Text = "StudyInstanceUID";
            this.StudyInstanceUID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudyDescription
            // 
            this.StudyDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudyDescription.AutoSize = true;
            this.StudyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyDescription.ForeColor = System.Drawing.Color.White;
            this.StudyDescription.Location = new System.Drawing.Point(-3, 27);
            this.StudyDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudyDescription.Name = "StudyDescription";
            this.StudyDescription.Size = new System.Drawing.Size(115, 17);
            this.StudyDescription.TabIndex = 5;
            this.StudyDescription.Text = "StudyDescription";
            this.StudyDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // InstitutionName
            // 
            this.InstitutionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InstitutionName.AutoSize = true;
            this.InstitutionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstitutionName.ForeColor = System.Drawing.Color.White;
            this.InstitutionName.Location = new System.Drawing.Point(-3, 149);
            this.InstitutionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstitutionName.Name = "InstitutionName";
            this.InstitutionName.Size = new System.Drawing.Size(105, 17);
            this.InstitutionName.TabIndex = 6;
            this.InstitutionName.Text = "InstitutionName";
            // 
            // InstitutionAddress
            // 
            this.InstitutionAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InstitutionAddress.AutoSize = true;
            this.InstitutionAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstitutionAddress.ForeColor = System.Drawing.Color.White;
            this.InstitutionAddress.Location = new System.Drawing.Point(-3, 166);
            this.InstitutionAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstitutionAddress.Name = "InstitutionAddress";
            this.InstitutionAddress.Size = new System.Drawing.Size(120, 17);
            this.InstitutionAddress.TabIndex = 7;
            this.InstitutionAddress.Text = "InstitutionAddress";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.InstitutionAddress);
            this.Controls.Add(this.InstitutionName);
            this.Controls.Add(this.StudyDescription);
            this.Controls.Add(this.StudyInstanceUID);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.pbDisplay);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "DisplayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DICOM Image Display";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.OnClientSizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.StyleChanged += new System.EventHandler(this.OnClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbDisplay;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private System.Windows.Forms.Label patientName;
        private System.Windows.Forms.Label patientID;
        private System.Windows.Forms.Label StudyInstanceUID;
        private System.Windows.Forms.Label StudyDescription;
        private System.Windows.Forms.Label InstitutionName;
        private System.Windows.Forms.Label InstitutionAddress;
    }
}