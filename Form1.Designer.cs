
namespace PiggyBank
{
    partial class Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            this.btnFold = new System.Windows.Forms.Button();
            this.btnPutMoney = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShake = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.lblTotalVolumeCaption = new System.Windows.Forms.Label();
            this.lblTotalVolume = new System.Windows.Forms.Label();
            this.lblAdditionalVolumesCaption = new System.Windows.Forms.Label();
            this.lblAdditionalVolume = new System.Windows.Forms.Label();
            this.lstMoney = new System.Windows.Forms.ListBox();
            this.grpMoney = new System.Windows.Forms.GroupBox();
            this.btn1TL = new System.Windows.Forms.Button();
            this.btn50Krs = new System.Windows.Forms.Button();
            this.btn25Krs = new System.Windows.Forms.Button();
            this.btn10Krs = new System.Windows.Forms.Button();
            this.btn5Krs = new System.Windows.Forms.Button();
            this.btn1Krs = new System.Windows.Forms.Button();
            this.btn200TL = new System.Windows.Forms.Button();
            this.btn100TL = new System.Windows.Forms.Button();
            this.btn50TL = new System.Windows.Forms.Button();
            this.btn20TL = new System.Windows.Forms.Button();
            this.btn10TL = new System.Windows.Forms.Button();
            this.btn5TL = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFold.Enabled = false;
            this.btnFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFold.Location = new System.Drawing.Point(42, 552);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(163, 72);
            this.btnFold.TabIndex = 30;
            this.btnFold.Text = "Katla";
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Click += new System.EventHandler(this.BtnFold_Click);
            // 
            // btnPutMoney
            // 
            this.btnPutMoney.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPutMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPutMoney.Location = new System.Drawing.Point(262, 552);
            this.btnPutMoney.Name = "btnPutMoney";
            this.btnPutMoney.Size = new System.Drawing.Size(163, 72);
            this.btnPutMoney.TabIndex = 30;
            this.btnPutMoney.Text = "Para At";
            this.btnPutMoney.UseVisualStyleBackColor = false;
            this.btnPutMoney.Click += new System.EventHandler(this.BtnPutMoney_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(918, 534);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnShake
            // 
            this.btnShake.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShake.Location = new System.Drawing.Point(469, 552);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(163, 72);
            this.btnShake.TabIndex = 30;
            this.btnShake.Text = "Salla";
            this.btnShake.UseVisualStyleBackColor = false;
            this.btnShake.Click += new System.EventHandler(this.BtnShake_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreak.Location = new System.Drawing.Point(689, 552);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(163, 72);
            this.btnBreak.TabIndex = 30;
            this.btnBreak.Text = "Kumbarayı Kır!";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.BtnBreak_Click);
            // 
            // lblTotalVolumeCaption
            // 
            this.lblTotalVolumeCaption.AutoSize = true;
            this.lblTotalVolumeCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalVolumeCaption.Location = new System.Drawing.Point(387, 659);
            this.lblTotalVolumeCaption.Name = "lblTotalVolumeCaption";
            this.lblTotalVolumeCaption.Size = new System.Drawing.Size(336, 24);
            this.lblTotalVolumeCaption.TabIndex = 32;
            this.lblTotalVolumeCaption.Text = "Paraların Kumbarada Kapladığı Hacim :";
            // 
            // lblTotalVolume
            // 
            this.lblTotalVolume.AutoSize = true;
            this.lblTotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalVolume.Location = new System.Drawing.Point(776, 659);
            this.lblTotalVolume.Name = "lblTotalVolume";
            this.lblTotalVolume.Size = new System.Drawing.Size(0, 24);
            this.lblTotalVolume.TabIndex = 32;
            // 
            // lblAdditionalVolumesCaption
            // 
            this.lblAdditionalVolumesCaption.AutoSize = true;
            this.lblAdditionalVolumesCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdditionalVolumesCaption.Location = new System.Drawing.Point(306, 702);
            this.lblAdditionalVolumesCaption.Name = "lblAdditionalVolumesCaption";
            this.lblAdditionalVolumesCaption.Size = new System.Drawing.Size(418, 24);
            this.lblAdditionalVolumesCaption.TabIndex = 32;
            this.lblAdditionalVolumesCaption.Text = "Paraların Kumbarada Kapladığı Fazladan Hacim :";
            // 
            // lblAdditionalVolume
            // 
            this.lblAdditionalVolume.AutoSize = true;
            this.lblAdditionalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdditionalVolume.Location = new System.Drawing.Point(776, 702);
            this.lblAdditionalVolume.Name = "lblAdditionalVolume";
            this.lblAdditionalVolume.Size = new System.Drawing.Size(0, 24);
            this.lblAdditionalVolume.TabIndex = 32;
            // 
            // lstMoney
            // 
            this.lstMoney.FormattingEnabled = true;
            this.lstMoney.ItemHeight = 16;
            this.lstMoney.Location = new System.Drawing.Point(1264, 3);
            this.lstMoney.Name = "lstMoney";
            this.lstMoney.Size = new System.Drawing.Size(225, 756);
            this.lstMoney.TabIndex = 33;
            // 
            // grpMoney
            // 
            this.grpMoney.Controls.Add(this.btn1TL);
            this.grpMoney.Controls.Add(this.btn50Krs);
            this.grpMoney.Controls.Add(this.btn25Krs);
            this.grpMoney.Controls.Add(this.btn10Krs);
            this.grpMoney.Controls.Add(this.btn5Krs);
            this.grpMoney.Controls.Add(this.btn1Krs);
            this.grpMoney.Controls.Add(this.btn200TL);
            this.grpMoney.Controls.Add(this.btn100TL);
            this.grpMoney.Controls.Add(this.btn50TL);
            this.grpMoney.Controls.Add(this.btn20TL);
            this.grpMoney.Controls.Add(this.btn10TL);
            this.grpMoney.Controls.Add(this.btn5TL);
            this.grpMoney.Location = new System.Drawing.Point(12, 12);
            this.grpMoney.Name = "grpMoney";
            this.grpMoney.Size = new System.Drawing.Size(1234, 515);
            this.grpMoney.TabIndex = 34;
            this.grpMoney.TabStop = false;
            // 
            // btn1TL
            // 
            this.btn1TL.BackColor = System.Drawing.Color.White;
            this.btn1TL.Image = ((System.Drawing.Image)(resources.GetObject("btn1TL.Image")));
            this.btn1TL.Location = new System.Drawing.Point(940, 372);
            this.btn1TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn1TL.Name = "btn1TL";
            this.btn1TL.Size = new System.Drawing.Size(147, 137);
            this.btn1TL.TabIndex = 41;
            this.btn1TL.UseVisualStyleBackColor = false;
            this.btn1TL.Click += new System.EventHandler(this.btn1TL_Click);
            // 
            // btn50Krs
            // 
            this.btn50Krs.BackColor = System.Drawing.Color.White;
            this.btn50Krs.Image = ((System.Drawing.Image)(resources.GetObject("btn50Krs.Image")));
            this.btn50Krs.Location = new System.Drawing.Point(754, 385);
            this.btn50Krs.Margin = new System.Windows.Forms.Padding(4);
            this.btn50Krs.Name = "btn50Krs";
            this.btn50Krs.Size = new System.Drawing.Size(132, 124);
            this.btn50Krs.TabIndex = 40;
            this.btn50Krs.UseVisualStyleBackColor = false;
            this.btn50Krs.Click += new System.EventHandler(this.btn50Krs_Click);
            // 
            // btn25Krs
            // 
            this.btn25Krs.BackColor = System.Drawing.Color.White;
            this.btn25Krs.Image = ((System.Drawing.Image)(resources.GetObject("btn25Krs.Image")));
            this.btn25Krs.Location = new System.Drawing.Point(586, 393);
            this.btn25Krs.Margin = new System.Windows.Forms.Padding(4);
            this.btn25Krs.Name = "btn25Krs";
            this.btn25Krs.Size = new System.Drawing.Size(109, 104);
            this.btn25Krs.TabIndex = 39;
            this.btn25Krs.UseVisualStyleBackColor = false;
            this.btn25Krs.Click += new System.EventHandler(this.btn25Krs_Click);
            // 
            // btn10Krs
            // 
            this.btn10Krs.BackColor = System.Drawing.Color.White;
            this.btn10Krs.Image = ((System.Drawing.Image)(resources.GetObject("btn10Krs.Image")));
            this.btn10Krs.Location = new System.Drawing.Point(298, 396);
            this.btn10Krs.Margin = new System.Windows.Forms.Padding(4);
            this.btn10Krs.Name = "btn10Krs";
            this.btn10Krs.Size = new System.Drawing.Size(102, 99);
            this.btn10Krs.TabIndex = 38;
            this.btn10Krs.UseVisualStyleBackColor = false;
            this.btn10Krs.Click += new System.EventHandler(this.btn10Krs_Click);
            // 
            // btn5Krs
            // 
            this.btn5Krs.BackColor = System.Drawing.Color.White;
            this.btn5Krs.Image = ((System.Drawing.Image)(resources.GetObject("btn5Krs.Image")));
            this.btn5Krs.Location = new System.Drawing.Point(172, 402);
            this.btn5Krs.Margin = new System.Windows.Forms.Padding(4);
            this.btn5Krs.Name = "btn5Krs";
            this.btn5Krs.Size = new System.Drawing.Size(89, 87);
            this.btn5Krs.TabIndex = 37;
            this.btn5Krs.UseVisualStyleBackColor = false;
            this.btn5Krs.Click += new System.EventHandler(this.btn5Krs_Click);
            // 
            // btn1Krs
            // 
            this.btn1Krs.BackColor = System.Drawing.Color.White;
            this.btn1Krs.Image = ((System.Drawing.Image)(resources.GetObject("btn1Krs.Image")));
            this.btn1Krs.Location = new System.Drawing.Point(43, 415);
            this.btn1Krs.Margin = new System.Windows.Forms.Padding(4);
            this.btn1Krs.Name = "btn1Krs";
            this.btn1Krs.Size = new System.Drawing.Size(68, 61);
            this.btn1Krs.TabIndex = 36;
            this.btn1Krs.UseVisualStyleBackColor = false;
            this.btn1Krs.Click += new System.EventHandler(this.btn1Krs_Click);
            // 
            // btn200TL
            // 
            this.btn200TL.BackColor = System.Drawing.Color.White;
            this.btn200TL.Image = ((System.Drawing.Image)(resources.GetObject("btn200TL.Image")));
            this.btn200TL.Location = new System.Drawing.Point(805, 167);
            this.btn200TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn200TL.Name = "btn200TL";
            this.btn200TL.Size = new System.Drawing.Size(422, 197);
            this.btn200TL.TabIndex = 35;
            this.btn200TL.UseVisualStyleBackColor = false;
            this.btn200TL.Click += new System.EventHandler(this.btn200TL_Click);
            // 
            // btn100TL
            // 
            this.btn100TL.BackColor = System.Drawing.Color.White;
            this.btn100TL.Image = ((System.Drawing.Image)(resources.GetObject("btn100TL.Image")));
            this.btn100TL.Location = new System.Drawing.Point(367, 171);
            this.btn100TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn100TL.Name = "btn100TL";
            this.btn100TL.Size = new System.Drawing.Size(409, 180);
            this.btn100TL.TabIndex = 34;
            this.btn100TL.UseVisualStyleBackColor = false;
            this.btn100TL.Click += new System.EventHandler(this.btn100TL_Click);
            // 
            // btn50TL
            // 
            this.btn50TL.BackColor = System.Drawing.Color.White;
            this.btn50TL.Image = ((System.Drawing.Image)(resources.GetObject("btn50TL.Image")));
            this.btn50TL.Location = new System.Drawing.Point(20, 184);
            this.btn50TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn50TL.Name = "btn50TL";
            this.btn50TL.Size = new System.Drawing.Size(339, 155);
            this.btn50TL.TabIndex = 33;
            this.btn50TL.UseVisualStyleBackColor = false;
            this.btn50TL.Click += new System.EventHandler(this.btn50TL_Click);
            // 
            // btn20TL
            // 
            this.btn20TL.BackColor = System.Drawing.Color.White;
            this.btn20TL.Image = ((System.Drawing.Image)(resources.GetObject("btn20TL.Image")));
            this.btn20TL.Location = new System.Drawing.Point(850, 22);
            this.btn20TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn20TL.Name = "btn20TL";
            this.btn20TL.Size = new System.Drawing.Size(290, 132);
            this.btn20TL.TabIndex = 32;
            this.btn20TL.UseVisualStyleBackColor = false;
            this.btn20TL.Click += new System.EventHandler(this.Btn20TL_Click);
            // 
            // btn10TL
            // 
            this.btn10TL.BackColor = System.Drawing.Color.White;
            this.btn10TL.Image = ((System.Drawing.Image)(resources.GetObject("btn10TL.Image")));
            this.btn10TL.Location = new System.Drawing.Point(420, 22);
            this.btn10TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn10TL.Name = "btn10TL";
            this.btn10TL.Size = new System.Drawing.Size(263, 116);
            this.btn10TL.TabIndex = 31;
            this.btn10TL.UseVisualStyleBackColor = false;
            this.btn10TL.Click += new System.EventHandler(this.Btn10TL_Click);
            // 
            // btn5TL
            // 
            this.btn5TL.BackColor = System.Drawing.Color.White;
            this.btn5TL.Image = ((System.Drawing.Image)(resources.GetObject("btn5TL.Image")));
            this.btn5TL.Location = new System.Drawing.Point(20, 22);
            this.btn5TL.Margin = new System.Windows.Forms.Padding(4);
            this.btn5TL.Name = "btn5TL";
            this.btn5TL.Size = new System.Drawing.Size(223, 107);
            this.btn5TL.TabIndex = 30;
            this.btn5TL.UseVisualStyleBackColor = false;
            this.btn5TL.Click += new System.EventHandler(this.Btn5TL_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPaste.Enabled = false;
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaste.Location = new System.Drawing.Point(42, 654);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(163, 72);
            this.btnPaste.TabIndex = 30;
            this.btnPaste.Text = "Yapıştır";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1619, 932);
            this.Controls.Add(this.grpMoney);
            this.Controls.Add(this.lstMoney);
            this.Controls.Add(this.lblAdditionalVolume);
            this.Controls.Add(this.lblTotalVolume);
            this.Controls.Add(this.lblAdditionalVolumesCaption);
            this.Controls.Add(this.lblTotalVolumeCaption);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnPutMoney);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnFold);
            this.Name = "Frm";
            this.Text = "Kumbara";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMoney.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.Button btnPutMoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Label lblTotalVolumeCaption;
        private System.Windows.Forms.Label lblTotalVolume;
        private System.Windows.Forms.Label lblAdditionalVolumesCaption;
        private System.Windows.Forms.Label lblAdditionalVolume;
        private System.Windows.Forms.ListBox lstMoney;
        private System.Windows.Forms.GroupBox grpMoney;
        private System.Windows.Forms.Button btn1TL;
        private System.Windows.Forms.Button btn50Krs;
        private System.Windows.Forms.Button btn25Krs;
        private System.Windows.Forms.Button btn10Krs;
        private System.Windows.Forms.Button btn5Krs;
        private System.Windows.Forms.Button btn1Krs;
        private System.Windows.Forms.Button btn200TL;
        private System.Windows.Forms.Button btn100TL;
        private System.Windows.Forms.Button btn50TL;
        private System.Windows.Forms.Button btn20TL;
        private System.Windows.Forms.Button btn10TL;
        private System.Windows.Forms.Button btn5TL;
        private System.Windows.Forms.Button btnPaste;
    }
}

