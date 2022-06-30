namespace FlaffyCat.Example
{
    partial class FlaffyAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlaffyAbout));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.SeeAboutPageButtom = new System.Windows.Forms.Button();
            this.SeeDocumentationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SeeDocumentationButton);
            this.splitContainer1.Panel1.Controls.Add(this.SeeAboutPageButtom);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Navy;
            this.splitContainer1.Size = new System.Drawing.Size(457, 272);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Flaffy Cat Game Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeeAboutPageButtom
            // 
            this.SeeAboutPageButtom.Location = new System.Drawing.Point(12, 25);
            this.SeeAboutPageButtom.Name = "SeeAboutPageButtom";
            this.SeeAboutPageButtom.Size = new System.Drawing.Size(112, 23);
            this.SeeAboutPageButtom.TabIndex = 1;
            this.SeeAboutPageButtom.Text = "See About Page";
            this.SeeAboutPageButtom.UseVisualStyleBackColor = true;
            // 
            // SeeDocumentationButton
            // 
            this.SeeDocumentationButton.Location = new System.Drawing.Point(12, 54);
            this.SeeDocumentationButton.Name = "SeeDocumentationButton";
            this.SeeDocumentationButton.Size = new System.Drawing.Size(112, 23);
            this.SeeDocumentationButton.TabIndex = 0;
            this.SeeDocumentationButton.Text = "See Documentetion";
            this.SeeDocumentationButton.UseVisualStyleBackColor = true;
            // 
            // FlaffyAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 272);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlaffyAbout";
            this.Text = "About FlaffyCat";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SeeDocumentationButton;
        private System.Windows.Forms.Button SeeAboutPageButtom;
    }
}