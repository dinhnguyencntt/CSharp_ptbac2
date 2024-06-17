namespace CSharp_ptbac2
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
            this.btngpt = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lsbkq = new System.Windows.Forms.ListBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // btngpt
            // 
            this.btngpt.Location = new System.Drawing.Point(299, 314);
            this.btngpt.Name = "btngpt";
            this.btngpt.Size = new System.Drawing.Size(272, 48);
            this.btngpt.TabIndex = 0;
            this.btngpt.Text = "GIẢI PHƯƠNG TRÌNH";
            this.btngpt.UseVisualStyleBackColor = true;
            this.btngpt.Click += new System.EventHandler(this.btngpt_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(65, 151);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(42, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Nhập a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(143, 144);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // lsbkq
            // 
            this.lsbkq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsbkq.FormattingEnabled = true;
            this.lsbkq.Location = new System.Drawing.Point(40, 382);
            this.lsbkq.Name = "lsbkq";
            this.lsbkq.Size = new System.Drawing.Size(965, 186);
            this.lsbkq.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(64, 202);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(43, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Nhập B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(64, 248);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(43, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Nhập C";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(143, 199);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(143, 241);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẶC 2\r\n";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(263, 139);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(742, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(263, 190);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(742, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(263, 241);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(742, 45);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(487, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "ax²+bx+c=0";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(53, 396);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(54, 13);
            this.lblkq.TabIndex = 13;
            this.lblkq.Text = "KẾT QUẢ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1053, 599);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lsbkq);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btngpt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngpt;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.ListBox lsbkq;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkq;
    }
}

