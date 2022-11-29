namespace WindowsFormsAppSample01
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
            this.button1 = new System.Windows.Forms.Button();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ultraButton2
            // 
            this.ultraButton2.Location = new System.Drawing.Point(159, 191);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.ShapeImage = global::WindowsFormsAppSample01.Properties.Resources.ShapeImage02;
            this.ultraButton2.Size = new System.Drawing.Size(90, 51);
            this.ultraButton2.TabIndex = 2;
            this.ultraButton2.Text = "ultraButton2";
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(12, 198);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.ShapeImage = global::WindowsFormsAppSample01.Properties.Resources.ShapeImage01;
            this.ultraButton1.Size = new System.Drawing.Size(78, 37);
            this.ultraButton1.TabIndex = 1;
            this.ultraButton1.Text = "ultraButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 247);
            this.Controls.Add(this.ultraButton2);
            this.Controls.Add(this.ultraButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
    }
}

