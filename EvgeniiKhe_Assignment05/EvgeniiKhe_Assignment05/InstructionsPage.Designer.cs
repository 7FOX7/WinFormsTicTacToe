namespace EvgeniiKhe_Assignment05
{
    partial class InstructionsPage
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
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.lblUnderInstructionsTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnGotIt = new System.Windows.Forms.Button();
            this.pnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInstructions.Controls.Add(this.lblUnderInstructionsTitle);
            this.pnlInstructions.Controls.Add(this.lblInstructions);
            this.pnlInstructions.Location = new System.Drawing.Point(21, 31);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(323, 141);
            this.pnlInstructions.TabIndex = 0;
            // 
            // lblUnderInstructionsTitle
            // 
            this.lblUnderInstructionsTitle.AutoSize = true;
            this.lblUnderInstructionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderInstructionsTitle.Location = new System.Drawing.Point(17, 81);
            this.lblUnderInstructionsTitle.Name = "lblUnderInstructionsTitle";
            this.lblUnderInstructionsTitle.Size = new System.Drawing.Size(303, 24);
            this.lblUnderInstructionsTitle.TabIndex = 6;
            this.lblUnderInstructionsTitle.Text = "Try to connect 3 X\'s or O\'s in a row";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(29, 19);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(277, 37);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Instructions:";
            // 
            // btnGotIt
            // 
            this.btnGotIt.BackColor = System.Drawing.Color.DarkGray;
            this.btnGotIt.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotIt.Location = new System.Drawing.Point(57, 405);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(188, 71);
            this.btnGotIt.TabIndex = 0;
            this.btnGotIt.Text = "Got it!";
            this.btnGotIt.UseVisualStyleBackColor = false;
            this.btnGotIt.Click += new System.EventHandler(this.btnGotIt_Click);
            // 
            // InstructionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::EvgeniiKhe_Assignment05.Properties.Resources.InstructionsBackground1;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.btnGotIt);
            this.Controls.Add(this.pnlInstructions);
            this.Name = "InstructionsPage";
            this.Text = "Instructions";
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Label lblUnderInstructionsTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnGotIt;
    }
}