namespace BasicSkiaGUI
{
    partial class Form1
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
            this.btn10Lines = new System.Windows.Forms.Button();
            this.btn1kLines = new System.Windows.Forms.Button();
            this.btn10kLines = new System.Windows.Forms.Button();
            this.btn100kLines = new System.Windows.Forms.Button();
            this.imageCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn10Lines
            // 
            this.btn10Lines.Location = new System.Drawing.Point(12, 12);
            this.btn10Lines.Name = "btn10Lines";
            this.btn10Lines.Size = new System.Drawing.Size(75, 23);
            this.btn10Lines.TabIndex = 0;
            this.btn10Lines.Text = "10";
            this.btn10Lines.UseVisualStyleBackColor = true;
            this.btn10Lines.Click += new System.EventHandler(this.btn10Lines_Click);
            // 
            // btn1kLines
            // 
            this.btn1kLines.Location = new System.Drawing.Point(93, 12);
            this.btn1kLines.Name = "btn1kLines";
            this.btn1kLines.Size = new System.Drawing.Size(75, 23);
            this.btn1kLines.TabIndex = 1;
            this.btn1kLines.Text = "1k";
            this.btn1kLines.UseVisualStyleBackColor = true;
            this.btn1kLines.Click += new System.EventHandler(this.btn1kLines_Click);
            // 
            // btn10kLines
            // 
            this.btn10kLines.Location = new System.Drawing.Point(175, 11);
            this.btn10kLines.Name = "btn10kLines";
            this.btn10kLines.Size = new System.Drawing.Size(75, 23);
            this.btn10kLines.TabIndex = 2;
            this.btn10kLines.Text = "10k";
            this.btn10kLines.UseVisualStyleBackColor = true;
            this.btn10kLines.Click += new System.EventHandler(this.btn10kLines_Click);
            // 
            // btn100kLines
            // 
            this.btn100kLines.Location = new System.Drawing.Point(256, 11);
            this.btn100kLines.Name = "btn100kLines";
            this.btn100kLines.Size = new System.Drawing.Size(75, 23);
            this.btn100kLines.TabIndex = 3;
            this.btn100kLines.Text = "100k";
            this.btn100kLines.UseVisualStyleBackColor = true;
            this.btn100kLines.Click += new System.EventHandler(this.btn100kLines_Click);
            // 
            // imageCanvas
            // 
            this.imageCanvas.Location = new System.Drawing.Point(12, 41);
            this.imageCanvas.Name = "imageCanvas";
            this.imageCanvas.Size = new System.Drawing.Size(812, 480);
            this.imageCanvas.TabIndex = 4;
            this.imageCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.imageCanvas);
            this.Controls.Add(this.btn100kLines);
            this.Controls.Add(this.btn10kLines);
            this.Controls.Add(this.btn1kLines);
            this.Controls.Add(this.btn10Lines);
            this.Name = "Form1";
            this.Text = "Basic Skia GUI";
            ((System.ComponentModel.ISupportInitialize)(this.imageCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn10Lines;
        private System.Windows.Forms.Button btn1kLines;
        private System.Windows.Forms.Button btn10kLines;
        private System.Windows.Forms.Button btn100kLines;
        private System.Windows.Forms.PictureBox imageCanvas;
    }
}

