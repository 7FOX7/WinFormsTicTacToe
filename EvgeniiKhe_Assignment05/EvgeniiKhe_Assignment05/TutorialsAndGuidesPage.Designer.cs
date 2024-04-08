namespace EvgeniiKhe_Assignment05
{
    partial class TutorialsAndGuidesPage
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
            this.pnlTutorialsAndGuides = new System.Windows.Forms.Panel();
            this.lblTutorAndGuides = new System.Windows.Forms.Label();
            this.btnGotIt = new System.Windows.Forms.Button();
            this.pnlTutorialsAndGuides.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTutorialsAndGuides
            // 
            this.pnlTutorialsAndGuides.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTutorialsAndGuides.Controls.Add(this.lblTutorAndGuides);
            this.pnlTutorialsAndGuides.Location = new System.Drawing.Point(108, 147);
            this.pnlTutorialsAndGuides.Name = "pnlTutorialsAndGuides";
            this.pnlTutorialsAndGuides.Size = new System.Drawing.Size(382, 143);
            this.pnlTutorialsAndGuides.TabIndex = 0;
            // 
            // lblTutorAndGuides
            // 
            this.lblTutorAndGuides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorAndGuides.Location = new System.Drawing.Point(18, 39);
            this.lblTutorAndGuides.Name = "lblTutorAndGuides";
            this.lblTutorAndGuides.Size = new System.Drawing.Size(348, 80);
            this.lblTutorAndGuides.TabIndex = 10;
            this.lblTutorAndGuides.Text = "No Tutrorials or Guides are needed to succeed in this game.";
            // 
            // btnGotIt
            // 
            this.btnGotIt.BackColor = System.Drawing.Color.Sienna;
            this.btnGotIt.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotIt.Location = new System.Drawing.Point(199, 374);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(188, 71);
            this.btnGotIt.TabIndex = 1;
            this.btnGotIt.Text = "Got it!";
            this.btnGotIt.UseVisualStyleBackColor = false;
            this.btnGotIt.Click += new System.EventHandler(this.btnGotIt_Click);
            // 
            // TutorialsAndGuidesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::EvgeniiKhe_Assignment05.Properties.Resources.TutorialsAndGuidesBackground;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.btnGotIt);
            this.Controls.Add(this.pnlTutorialsAndGuides);
            this.Name = "TutorialsAndGuidesPage";
            this.Text = "Tutorials and Guides";
            this.pnlTutorialsAndGuides.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTutorialsAndGuides;
        private System.Windows.Forms.Label lblTutorAndGuides;
        private System.Windows.Forms.Button btnGotIt;
    }
}