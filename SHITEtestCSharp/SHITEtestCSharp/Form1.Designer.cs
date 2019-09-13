namespace SHITEtestCSharp
{
    partial class SHITEmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SHITEmenu));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLScored = new System.Windows.Forms.Label();
            this.CmdCan = new System.Windows.Forms.Button();
            this.cmdTakeIt = new System.Windows.Forms.Button();
            this.cmdWaht = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(239, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(54, 50);
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // LBLScored
            // 
            this.LBLScored.AutoSize = true;
            this.LBLScored.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLScored.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLScored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(85)))), ((int)(((byte)(38)))));
            this.LBLScored.Location = new System.Drawing.Point(209, 53);
            this.LBLScored.Name = "LBLScored";
            this.LBLScored.Size = new System.Drawing.Size(84, 57);
            this.LBLScored.TabIndex = 8;
            this.LBLScored.Text = "You have not \r\nyet taken the \r\nshite test";
            // 
            // CmdCan
            // 
            this.CmdCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCan.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(85)))), ((int)(((byte)(38)))));
            this.CmdCan.Location = new System.Drawing.Point(12, 140);
            this.CmdCan.Name = "CmdCan";
            this.CmdCan.Size = new System.Drawing.Size(191, 58);
            this.CmdCan.TabIndex = 7;
            this.CmdCan.Text = "I don\'t want to take the SHITE test";
            this.CmdCan.UseVisualStyleBackColor = false;
            // 
            // cmdTakeIt
            // 
            this.cmdTakeIt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTakeIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTakeIt.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTakeIt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(85)))), ((int)(((byte)(38)))));
            this.cmdTakeIt.Location = new System.Drawing.Point(12, 76);
            this.cmdTakeIt.Name = "cmdTakeIt";
            this.cmdTakeIt.Size = new System.Drawing.Size(191, 58);
            this.cmdTakeIt.TabIndex = 6;
            this.cmdTakeIt.Text = "Take the SHITE test";
            this.cmdTakeIt.UseVisualStyleBackColor = true;
            // 
            // cmdWaht
            // 
            this.cmdWaht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdWaht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdWaht.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWaht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(85)))), ((int)(((byte)(38)))));
            this.cmdWaht.Location = new System.Drawing.Point(12, 12);
            this.cmdWaht.Name = "cmdWaht";
            this.cmdWaht.Size = new System.Drawing.Size(191, 58);
            this.cmdWaht.TabIndex = 5;
            this.cmdWaht.Text = "What is the SHITE test?";
            this.cmdWaht.UseVisualStyleBackColor = true;
            // 
            // SHITEmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(303, 208);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LBLScored);
            this.Controls.Add(this.CmdCan);
            this.Controls.Add(this.cmdTakeIt);
            this.Controls.Add(this.cmdWaht);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SHITEmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SHITEmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label LBLScored;
        internal System.Windows.Forms.Button CmdCan;
        internal System.Windows.Forms.Button cmdTakeIt;
        internal System.Windows.Forms.Button cmdWaht;
    }
}

