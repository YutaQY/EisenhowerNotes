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
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.dateTimeMain = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainFormName
            // 
            this.mainFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFormName.BackColor = System.Drawing.Color.Transparent;
            this.mainFormName.Font = new System.Drawing.Font("Arial", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainFormName.ForeColor = System.Drawing.SystemColors.Window;
            this.mainFormName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainFormName.Location = new System.Drawing.Point(744, 423);
            this.mainFormName.MinimumSize = new System.Drawing.Size(114, 20);
            this.mainFormName.Name = "mainFormName";
            this.mainFormName.Size = new System.Drawing.Size(114, 20);
            this.mainFormName.TabIndex = 0;
            this.mainFormName.Text = "Eisenhower Notes v0.0";
            this.mainFormName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mainFormName.UseMnemonic = false;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 19;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 12);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(150, 99);
            this.listBoxTasks.TabIndex = 1;
            // 
            // dateTimeMain
            // 
            this.dateTimeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeMain.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeMain.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimeMain.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimeMain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeMain.Location = new System.Drawing.Point(676, 12);
            this.dateTimeMain.Name = "dateTimeMain";
            this.dateTimeMain.Size = new System.Drawing.Size(182, 25);
            this.dateTimeMain.TabIndex = 2;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddNote.BackColor = System.Drawing.Color.Black;
            this.buttonAddNote.BackgroundImage = global::EisenhowerNotes.Properties.Resources.buttonSprite;
            this.buttonAddNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddNote.ForeColor = System.Drawing.Color.Black;
            this.buttonAddNote.Location = new System.Drawing.Point(12, 411);
            this.buttonAddNote.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(94, 29);
            this.buttonAddNote.TabIndex = 3;
            this.buttonAddNote.Text = "AddNote";
            this.buttonAddNote.UseVisualStyleBackColor = false;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // EisenhowerNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 452);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.dateTimeMain);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.mainFormName);
            this.Name = "EisenhowerNotes";
            this.Text = "Eisenhower Notes";
            this.ResumeLayout(false);

        }

        #endregion

        private Label mainFormName;
        private ListBox listBoxTasks;
        private DateTimePicker dateTimeMain;
        private Button buttonAddNote;
    }
}