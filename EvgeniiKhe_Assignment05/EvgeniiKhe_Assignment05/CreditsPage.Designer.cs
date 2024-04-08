namespace EvgeniiKhe_Assignment05
{
    partial class CreditsPage
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
            this.pnlCredits = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblProgramming = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.lblDesigner = new System.Windows.Forms.Label();
            this.btnGotIt = new System.Windows.Forms.Button();
            this.pnlCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCredits
            // 
            this.pnlCredits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCredits.Controls.Add(this.lblDesigner);
            this.pnlCredits.Controls.Add(this.lblProgrammer);
            this.pnlCredits.Controls.Add(this.lblDesign);
            this.pnlCredits.Controls.Add(this.lblProgramming);
            this.pnlCredits.Controls.Add(this.lblCredits);
            this.pnlCredits.Location = new System.Drawing.Point(86, 35);
            this.pnlCredits.Name = "pnlCredits";
            this.pnlCredits.Size = new System.Drawing.Size(450, 259);
            this.pnlCredits.TabIndex = 0;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblCredits.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCredits.Location = new System.Drawing.Point(141, 33);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(177, 37);
            this.lblCredits.TabIndex = 6;
            this.lblCredits.Text = "Credits:";
            // 
            // lblProgramming
            // 
            this.lblProgramming.AutoSize = true;
            this.lblProgramming.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramming.Location = new System.Drawing.Point(20, 112);
            this.lblProgramming.Name = "lblProgramming";
            this.lblProgramming.Size = new System.Drawing.Size(165, 29);
            this.lblProgramming.TabIndex = 7;
            this.lblProgramming.Text = "Programming:";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.Location = new System.Drawing.Point(20, 183);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(95, 29);
            this.lblDesign.TabIndex = 8;
            this.lblDesign.Text = "Design:";
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammer.Location = new System.Drawing.Point(206, 115);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(127, 25);
            this.lblProgrammer.TabIndex = 9;
            this.lblProgrammer.Text = "Evgenii Khe";
            // 
            // lblDesigner
            // 
            this.lblDesigner.AutoSize = true;
            this.lblDesigner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigner.Location = new System.Drawing.Point(206, 187);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(127, 25);
            this.lblDesigner.TabIndex = 10;
            this.lblDesigner.Text = "Evgenii Khe";
            // 
            // btnGotIt
            // 
            this.btnGotIt.BackColor = System.Drawing.Color.Khaki;
            this.btnGotIt.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotIt.Location = new System.Drawing.Point(216, 386);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(188, 71);
            this.btnGotIt.TabIndex = 0;
            this.btnGotIt.Text = "Got it!";
            this.btnGotIt.UseVisualStyleBackColor = false;
            this.btnGotIt.Click += new System.EventHandler(this.btnGotIt_Click);
            // 
            // CreditsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvgeniiKhe_Assignment05.Properties.Resources.CreditsBackground;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.btnGotIt);
            this.Controls.Add(this.pnlCredits);
            this.Name = "CreditsPage";
            this.Text = "Credits";
            this.pnlCredits.ResumeLayout(false);
            this.pnlCredits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCredits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblProgramming;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblDesigner;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Button btnGotIt;
    }
}