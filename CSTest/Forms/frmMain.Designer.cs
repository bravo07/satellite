namespace CSTest
{
    partial class frmMain
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
            this.btnWriteLine = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnReadLine = new System.Windows.Forms.Button();
            this.txtInput = new CSTest.Controls.TextBoxCue();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.txtTitle = new CSTest.Controls.TextBoxCue();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.txtOutput = new CSTest.Controls.TextBoxCue();
            this.gbIO = new System.Windows.Forms.GroupBox();
            this.gbControl.SuspendLayout();
            this.gbIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWriteLine
            // 
            this.btnWriteLine.Location = new System.Drawing.Point(101, 45);
            this.btnWriteLine.Name = "btnWriteLine";
            this.btnWriteLine.Size = new System.Drawing.Size(89, 23);
            this.btnWriteLine.TabIndex = 2;
            this.btnWriteLine.Text = "Write Line";
            this.btnWriteLine.UseVisualStyleBackColor = true;
            this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(6, 45);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(89, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnReadLine
            // 
            this.btnReadLine.Location = new System.Drawing.Point(101, 100);
            this.btnReadLine.Name = "btnReadLine";
            this.btnReadLine.Size = new System.Drawing.Size(89, 23);
            this.btnReadLine.TabIndex = 6;
            this.btnReadLine.Text = "Read Line";
            this.btnReadLine.UseVisualStyleBackColor = true;
            this.btnReadLine.Click += new System.EventHandler(this.btnReadLine_Click);
            // 
            // txtInput
            // 
            this.txtInput.Cue = "Input";
            this.txtInput.Location = new System.Drawing.Point(6, 74);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(184, 20);
            this.txtInput.TabIndex = 4;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(8, 19);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(89, 23);
            this.btnDestroy.TabIndex = 10;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(103, 19);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(89, 23);
            this.btnToggle.TabIndex = 9;
            this.btnToggle.Text = "Attach";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(103, 74);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(89, 23);
            this.btnTitle.TabIndex = 14;
            this.btnTitle.Text = "Set";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Cue = "Title";
            this.txtTitle.Location = new System.Drawing.Point(8, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(184, 20);
            this.txtTitle.TabIndex = 12;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnDestroy);
            this.gbControl.Controls.Add(this.btnToggle);
            this.gbControl.Controls.Add(this.btnTitle);
            this.gbControl.Controls.Add(this.txtTitle);
            this.gbControl.Location = new System.Drawing.Point(12, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(200, 107);
            this.gbControl.TabIndex = 15;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // txtOutput
            // 
            this.txtOutput.Cue = "Output";
            this.txtOutput.Location = new System.Drawing.Point(8, 19);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(184, 20);
            this.txtOutput.TabIndex = 11;
            // 
            // gbIO
            // 
            this.gbIO.Controls.Add(this.txtOutput);
            this.gbIO.Controls.Add(this.btnWriteLine);
            this.gbIO.Controls.Add(this.btnReadLine);
            this.gbIO.Controls.Add(this.btnWrite);
            this.gbIO.Controls.Add(this.txtInput);
            this.gbIO.Location = new System.Drawing.Point(12, 125);
            this.gbIO.Name = "gbIO";
            this.gbIO.Size = new System.Drawing.Size(200, 133);
            this.gbIO.TabIndex = 16;
            this.gbIO.TabStop = false;
            this.gbIO.Text = "I/O";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 271);
            this.Controls.Add(this.gbIO);
            this.Controls.Add(this.gbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satellite Console Test";
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbIO.ResumeLayout(false);
            this.gbIO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWriteLine;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnReadLine;
        private Controls.TextBoxCue txtInput;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnTitle;
        private Controls.TextBoxCue txtTitle;
        private System.Windows.Forms.GroupBox gbControl;
        private Controls.TextBoxCue txtOutput;
        private System.Windows.Forms.GroupBox gbIO;
    }
}

