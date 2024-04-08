namespace EvgeniiKhe_Assignment05
{
    partial class IntroPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroPage));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUnderWelcomeTitle = new System.Windows.Forms.Label();
            this.pnlWelcomeContext = new System.Windows.Forms.Panel();
            this.picWelcome = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlWelcomeContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Perpetua", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblWelcome.Location = new System.Drawing.Point(77, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(357, 92);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblUnderWelcomeTitle
            // 
            this.lblUnderWelcomeTitle.AutoSize = true;
            this.lblUnderWelcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderWelcomeTitle.Location = new System.Drawing.Point(145, 104);
            this.lblUnderWelcomeTitle.Name = "lblUnderWelcomeTitle";
            this.lblUnderWelcomeTitle.Size = new System.Drawing.Size(227, 16);
            this.lblUnderWelcomeTitle.TabIndex = 1;
            this.lblUnderWelcomeTitle.Text = "A little thank you for visiting our game ";
            // 
            // pnlWelcomeContext
            // 
            this.pnlWelcomeContext.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlWelcomeContext.Controls.Add(this.picWelcome);
            this.pnlWelcomeContext.Controls.Add(this.lblWelcome);
            this.pnlWelcomeContext.Controls.Add(this.lblUnderWelcomeTitle);
            this.pnlWelcomeContext.Location = new System.Drawing.Point(77, 12);
            this.pnlWelcomeContext.Name = "pnlWelcomeContext";
            this.pnlWelcomeContext.Size = new System.Drawing.Size(498, 303);
            this.pnlWelcomeContext.TabIndex = 2;
            // 
            // picWelcome
            // 
            this.picWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWelcome.BackgroundImage")));
            this.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWelcome.Location = new System.Drawing.Point(93, 145);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(321, 108);
            this.picWelcome.TabIndex = 3;
            this.picWelcome.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContinue.Font = new System.Drawing.Font("Niagara Solid", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(225, 333);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(224, 40);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Niagara Solid", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(225, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IntroPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 444);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pnlWelcomeContext);
            this.Name = "IntroPage";
            this.Text = "Welcome!";
            this.pnlWelcomeContext.ResumeLayout(false);
            this.pnlWelcomeContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUnderWelcomeTitle;
        private System.Windows.Forms.Panel pnlWelcomeContext;
        private System.Windows.Forms.PictureBox picWelcome;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnExit;
    }
}