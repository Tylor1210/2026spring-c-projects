namespace CardIdentifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pbCard1 = new System.Windows.Forms.PictureBox();
            this.pbCard2 = new System.Windows.Forms.PictureBox();
            this.pbCard3 = new System.Windows.Forms.PictureBox();
            this.pbCard4 = new System.Windows.Forms.PictureBox();
            this.pbCard5 = new System.Windows.Forms.PictureBox();
            this.lbCardName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Card to see it\'s name..";
            // 
            // pbCard1
            // 
            this.pbCard1.Image = ((System.Drawing.Image)(resources.GetObject("pbCard1.Image")));
            this.pbCard1.Location = new System.Drawing.Point(71, 96);
            this.pbCard1.Name = "pbCard1";
            this.pbCard1.Size = new System.Drawing.Size(96, 134);
            this.pbCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard1.TabIndex = 1;
            this.pbCard1.TabStop = false;
            this.pbCard1.Click += new System.EventHandler(this.pbCard1_Click);
            // 
            // pbCard2
            // 
            this.pbCard2.Image = ((System.Drawing.Image)(resources.GetObject("pbCard2.Image")));
            this.pbCard2.Location = new System.Drawing.Point(205, 96);
            this.pbCard2.Name = "pbCard2";
            this.pbCard2.Size = new System.Drawing.Size(96, 134);
            this.pbCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard2.TabIndex = 2;
            this.pbCard2.TabStop = false;
            this.pbCard2.Click += new System.EventHandler(this.pbCard2_Click);
            // 
            // pbCard3
            // 
            this.pbCard3.Image = ((System.Drawing.Image)(resources.GetObject("pbCard3.Image")));
            this.pbCard3.Location = new System.Drawing.Point(341, 96);
            this.pbCard3.Name = "pbCard3";
            this.pbCard3.Size = new System.Drawing.Size(96, 134);
            this.pbCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard3.TabIndex = 3;
            this.pbCard3.TabStop = false;
            this.pbCard3.Click += new System.EventHandler(this.pbCard3_Click);
            // 
            // pbCard4
            // 
            this.pbCard4.Image = ((System.Drawing.Image)(resources.GetObject("pbCard4.Image")));
            this.pbCard4.Location = new System.Drawing.Point(473, 96);
            this.pbCard4.Name = "pbCard4";
            this.pbCard4.Size = new System.Drawing.Size(96, 134);
            this.pbCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard4.TabIndex = 4;
            this.pbCard4.TabStop = false;
            this.pbCard4.Click += new System.EventHandler(this.pbCard4_Click);
            // 
            // pbCard5
            // 
            this.pbCard5.Image = ((System.Drawing.Image)(resources.GetObject("pbCard5.Image")));
            this.pbCard5.Location = new System.Drawing.Point(607, 96);
            this.pbCard5.Name = "pbCard5";
            this.pbCard5.Size = new System.Drawing.Size(96, 134);
            this.pbCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard5.TabIndex = 5;
            this.pbCard5.TabStop = false;
            this.pbCard5.Click += new System.EventHandler(this.pbCard5_Click);
            // 
            // lbCardName
            // 
            this.lbCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardName.Location = new System.Drawing.Point(71, 291);
            this.lbCardName.Name = "lbCardName";
            this.lbCardName.Size = new System.Drawing.Size(632, 41);
            this.lbCardName.TabIndex = 6;
            this.lbCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbCardName);
            this.Controls.Add(this.pbCard5);
            this.Controls.Add(this.pbCard4);
            this.Controls.Add(this.pbCard3);
            this.Controls.Add(this.pbCard2);
            this.Controls.Add(this.pbCard1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCard1;
        private System.Windows.Forms.PictureBox pbCard2;
        private System.Windows.Forms.PictureBox pbCard3;
        private System.Windows.Forms.PictureBox pbCard4;
        private System.Windows.Forms.PictureBox pbCard5;
        private System.Windows.Forms.Label lbCardName;
        private System.Windows.Forms.Button btnExit;
    }
}

