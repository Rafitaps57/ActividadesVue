namespace EV1
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fORM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORM5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORM3ToolStripMenuItem,
            this.fORM4ToolStripMenuItem,
            this.fORM5ToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fORM3ToolStripMenuItem
            // 
            this.fORM3ToolStripMenuItem.Name = "fORM3ToolStripMenuItem";
            this.fORM3ToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.fORM3ToolStripMenuItem.Text = "FORM3";
            this.fORM3ToolStripMenuItem.Click += new System.EventHandler(this.fORM3ToolStripMenuItem_Click);
            // 
            // fORM4ToolStripMenuItem
            // 
            this.fORM4ToolStripMenuItem.Name = "fORM4ToolStripMenuItem";
            this.fORM4ToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.fORM4ToolStripMenuItem.Text = "FORM4";
            this.fORM4ToolStripMenuItem.Click += new System.EventHandler(this.fORM4ToolStripMenuItem_Click);
            // 
            // fORM5ToolStripMenuItem
            // 
            this.fORM5ToolStripMenuItem.Name = "fORM5ToolStripMenuItem";
            this.fORM5ToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.fORM5ToolStripMenuItem.Text = "FORM5";
            this.fORM5ToolStripMenuItem.Click += new System.EventHandler(this.fORM5ToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fORM3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORM4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORM5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}