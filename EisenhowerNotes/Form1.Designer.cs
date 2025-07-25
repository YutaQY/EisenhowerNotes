namespace EisenhowerNotes
{
    partial class EisenhowerNotes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EisenhowerNotes));
            this.mainFormName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainFormName
            // 
            this.mainFormName.AutoSize = true;
            this.mainFormName.BackColor = System.Drawing.Color.Transparent;
            this.mainFormName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainFormName.ForeColor = System.Drawing.SystemColors.Window;
            this.mainFormName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainFormName.Location = new System.Drawing.Point(204, 19);
            this.mainFormName.MinimumSize = new System.Drawing.Size(500, 50);
            this.mainFormName.Name = "mainFormName";
            this.mainFormName.Size = new System.Drawing.Size(500, 50);
            this.mainFormName.TabIndex = 0;
            this.mainFormName.Text = "Eisenhower Notes v0.0";
            this.mainFormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EisenhowerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 452);
            this.Controls.Add(this.mainFormName);
            this.Name = "EisenhowerNotes";
            this.Text = "Eisenhower Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainFormName;
    }
}