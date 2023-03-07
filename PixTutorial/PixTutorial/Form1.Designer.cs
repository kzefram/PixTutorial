namespace PixTutorial
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnPicture1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Image = global::PixTutorial.Properties.Resources.Saying;
            this.picIcon.Location = new System.Drawing.Point(227, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(582, 325);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // btnPicture1
            // 
            this.btnPicture1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPicture1.Location = new System.Drawing.Point(227, 411);
            this.btnPicture1.Name = "btnPicture1";
            this.btnPicture1.Size = new System.Drawing.Size(251, 46);
            this.btnPicture1.TabIndex = 2;
            this.btnPicture1.Text = "Picture 1";
            this.btnPicture1.UseVisualStyleBackColor = true;
            this.btnPicture1.Click += new System.EventHandler(this.btnPicture1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(558, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Picture 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(364, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click a button to change the photo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPicture1);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pictures by Karen Bourgeois";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnPicture1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

