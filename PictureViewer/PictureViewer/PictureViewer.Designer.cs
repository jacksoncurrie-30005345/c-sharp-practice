namespace PictureViewer
{
    partial class PictureViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkStretch = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBackColour = new System.Windows.Forms.Button();
            this.btnClearPic = new System.Windows.Forms.Button();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkStretch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 327);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chkStretch
            // 
            this.chkStretch.AutoSize = true;
            this.chkStretch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStretch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStretch.Location = new System.Drawing.Point(2, 333);
            this.chkStretch.Margin = new System.Windows.Forms.Padding(2);
            this.chkStretch.Name = "chkStretch";
            this.chkStretch.Size = new System.Drawing.Size(83, 33);
            this.chkStretch.TabIndex = 1;
            this.chkStretch.Text = "Stretch";
            this.chkStretch.UseVisualStyleBackColor = true;
            this.chkStretch.CheckedChanged += new System.EventHandler(this.chkStretch_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnBackColour);
            this.flowLayoutPanel1.Controls.Add(this.btnClearPic);
            this.flowLayoutPanel1.Controls.Add(this.btnShowPic);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 333);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(2, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBackColour
            // 
            this.btnBackColour.BackColor = System.Drawing.Color.PaleGreen;
            this.btnBackColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColour.Location = new System.Drawing.Point(71, 2);
            this.btnBackColour.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackColour.Name = "btnBackColour";
            this.btnBackColour.Size = new System.Drawing.Size(124, 30);
            this.btnBackColour.TabIndex = 4;
            this.btnBackColour.Text = "Background";
            this.btnBackColour.UseVisualStyleBackColor = false;
            this.btnBackColour.Click += new System.EventHandler(this.btnBackColour_Click);
            // 
            // btnClearPic
            // 
            this.btnClearPic.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClearPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPic.Location = new System.Drawing.Point(199, 2);
            this.btnClearPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearPic.Name = "btnClearPic";
            this.btnClearPic.Size = new System.Drawing.Size(143, 30);
            this.btnClearPic.TabIndex = 2;
            this.btnClearPic.Text = "Clear Picture";
            this.btnClearPic.UseVisualStyleBackColor = false;
            this.btnClearPic.Click += new System.EventHandler(this.btnClearPic_Click);
            // 
            // btnShowPic
            // 
            this.btnShowPic.BackColor = System.Drawing.Color.PaleGreen;
            this.btnShowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPic.Location = new System.Drawing.Point(346, 2);
            this.btnShowPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(143, 30);
            this.btnShowPic.TabIndex = 3;
            this.btnShowPic.Text = "Show Picture";
            this.btnShowPic.UseVisualStyleBackColor = false;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PictureViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkStretch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBackColour;
        private System.Windows.Forms.Button btnClearPic;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

