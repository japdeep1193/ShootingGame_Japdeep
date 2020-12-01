namespace ShootingGame_Japdeep
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
            this.components = new System.ComponentModel.Container();
            this.loadBtn = new System.Windows.Forms.Button();
            this.spinBtn = new System.Windows.Forms.Button();
            this.shootBtn = new System.Windows.Forms.Button();
            this.shootAwayBtn = new System.Windows.Forms.Button();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.pb_Gun = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadBtn.Location = new System.Drawing.Point(93, 377);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(154, 53);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // spinBtn
            // 
            this.spinBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.spinBtn.Location = new System.Drawing.Point(293, 377);
            this.spinBtn.Name = "spinBtn";
            this.spinBtn.Size = new System.Drawing.Size(154, 53);
            this.spinBtn.TabIndex = 1;
            this.spinBtn.Text = "Spin";
            this.spinBtn.UseVisualStyleBackColor = false;
            this.spinBtn.Click += new System.EventHandler(this.spinBtn_Click);
            // 
            // shootBtn
            // 
            this.shootBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.shootBtn.Location = new System.Drawing.Point(471, 377);
            this.shootBtn.Name = "shootBtn";
            this.shootBtn.Size = new System.Drawing.Size(154, 53);
            this.shootBtn.TabIndex = 2;
            this.shootBtn.Text = "Shoot";
            this.shootBtn.UseVisualStyleBackColor = false;
            this.shootBtn.Click += new System.EventHandler(this.shootBtn_Click);
            // 
            // shootAwayBtn
            // 
            this.shootAwayBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.shootAwayBtn.Location = new System.Drawing.Point(641, 377);
            this.shootAwayBtn.Name = "shootAwayBtn";
            this.shootAwayBtn.Size = new System.Drawing.Size(154, 53);
            this.shootAwayBtn.TabIndex = 3;
            this.shootAwayBtn.Text = "Shoot Away";
            this.shootAwayBtn.UseVisualStyleBackColor = false;
            this.shootAwayBtn.Click += new System.EventHandler(this.shootAwayBtn_Click);
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tryAgainBtn.Location = new System.Drawing.Point(819, 377);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(154, 53);
            this.tryAgainBtn.TabIndex = 4;
            this.tryAgainBtn.Text = "try Again";
            this.tryAgainBtn.UseVisualStyleBackColor = false;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // pb_Gun
            // 
            this.pb_Gun.Image = global::ShootingGame_Japdeep.Properties.Resources._1st;
            this.pb_Gun.Location = new System.Drawing.Point(93, 50);
            this.pb_Gun.Name = "pb_Gun";
            this.pb_Gun.Size = new System.Drawing.Size(216, 168);
            this.pb_Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Gun.TabIndex = 5;
            this.pb_Gun.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1019, 571);
            this.Controls.Add(this.pb_Gun);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.shootAwayBtn);
            this.Controls.Add(this.shootBtn);
            this.Controls.Add(this.spinBtn);
            this.Controls.Add(this.loadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button spinBtn;
        private System.Windows.Forms.Button shootBtn;
        private System.Windows.Forms.Button shootAwayBtn;
        private System.Windows.Forms.Button tryAgainBtn;
        private System.Windows.Forms.PictureBox pb_Gun;
        private System.Windows.Forms.Timer timer1;
    }
}

