namespace NQueen
{
    partial class dialog
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
            this.count = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.outlist = new System.Windows.Forms.ListBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.pascal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(13, 13);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(56, 20);
            this.count.TabIndex = 0;
            this.count.Text = "8";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(75, 11);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(52, 24);
            this.start.TabIndex = 1;
            this.start.Text = "Solve";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // outlist
            // 
            this.outlist.FormattingEnabled = true;
            this.outlist.Location = new System.Drawing.Point(13, 41);
            this.outlist.Name = "outlist";
            this.outlist.Size = new System.Drawing.Size(182, 342);
            this.outlist.TabIndex = 2;
            this.outlist.SelectedIndexChanged += new System.EventHandler(this.outlist_SelectedIndexChanged);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(201, 13);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(370, 370);
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // pascal
            // 
            this.pascal.Location = new System.Drawing.Point(133, 12);
            this.pascal.Name = "pascal";
            this.pascal.Size = new System.Drawing.Size(52, 24);
            this.pascal.TabIndex = 1;
            this.pascal.Text = "Pascal";
            this.pascal.UseVisualStyleBackColor = true;
            this.pascal.Click += new System.EventHandler(this.pascal_Click);
            // 
            // dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 394);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.outlist);
            this.Controls.Add(this.pascal);
            this.Controls.Add(this.start);
            this.Controls.Add(this.count);
            this.Name = "dialog";
            this.Text = "NQueen";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox outlist;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button pascal;
    }
}

