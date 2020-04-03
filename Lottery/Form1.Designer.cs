namespace Lottery
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
            this.grpYourNumbers = new System.Windows.Forms.GroupBox();
            this.txtYourNumbers1 = new System.Windows.Forms.TextBox();
            this.txtYourNumbers2 = new System.Windows.Forms.TextBox();
            this.txtYourNumbers3 = new System.Windows.Forms.TextBox();
            this.txtYourNumbers4 = new System.Windows.Forms.TextBox();
            this.grpHouseNumbers = new System.Windows.Forms.GroupBox();
            this.txtHouseNumbers4 = new System.Windows.Forms.TextBox();
            this.txtHouseNumbers3 = new System.Windows.Forms.TextBox();
            this.txtHouseNumbers2 = new System.Windows.Forms.TextBox();
            this.txtHouseNumbers1 = new System.Windows.Forms.TextBox();
            this.btnGenerateRnadomNumbers = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpYourNumbers.SuspendLayout();
            this.grpHouseNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYourNumbers
            // 
            this.grpYourNumbers.Controls.Add(this.txtYourNumbers4);
            this.grpYourNumbers.Controls.Add(this.txtYourNumbers3);
            this.grpYourNumbers.Controls.Add(this.txtYourNumbers2);
            this.grpYourNumbers.Controls.Add(this.txtYourNumbers1);
            this.grpYourNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYourNumbers.Location = new System.Drawing.Point(38, 45);
            this.grpYourNumbers.Name = "grpYourNumbers";
            this.grpYourNumbers.Size = new System.Drawing.Size(361, 124);
            this.grpYourNumbers.TabIndex = 0;
            this.grpYourNumbers.TabStop = false;
            this.grpYourNumbers.Text = "Your Numbers";
            // 
            // txtYourNumbers1
            // 
            this.txtYourNumbers1.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtYourNumbers1.Location = new System.Drawing.Point(35, 48);
            this.txtYourNumbers1.MaxLength = 1;
            this.txtYourNumbers1.Name = "txtYourNumbers1";
            this.txtYourNumbers1.Size = new System.Drawing.Size(65, 29);
            this.txtYourNumbers1.TabIndex = 0;
            this.txtYourNumbers1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYourNumbers2
            // 
            this.txtYourNumbers2.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtYourNumbers2.Location = new System.Drawing.Point(117, 48);
            this.txtYourNumbers2.MaxLength = 1;
            this.txtYourNumbers2.Name = "txtYourNumbers2";
            this.txtYourNumbers2.Size = new System.Drawing.Size(65, 29);
            this.txtYourNumbers2.TabIndex = 1;
            this.txtYourNumbers2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYourNumbers3
            // 
            this.txtYourNumbers3.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtYourNumbers3.Location = new System.Drawing.Point(198, 48);
            this.txtYourNumbers3.MaxLength = 1;
            this.txtYourNumbers3.Name = "txtYourNumbers3";
            this.txtYourNumbers3.Size = new System.Drawing.Size(65, 29);
            this.txtYourNumbers3.TabIndex = 2;
            this.txtYourNumbers3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYourNumbers3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtYourNumbers4
            // 
            this.txtYourNumbers4.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtYourNumbers4.Location = new System.Drawing.Point(280, 48);
            this.txtYourNumbers4.MaxLength = 1;
            this.txtYourNumbers4.Name = "txtYourNumbers4";
            this.txtYourNumbers4.Size = new System.Drawing.Size(65, 29);
            this.txtYourNumbers4.TabIndex = 3;
            this.txtYourNumbers4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpHouseNumbers
            // 
            this.grpHouseNumbers.Controls.Add(this.txtHouseNumbers4);
            this.grpHouseNumbers.Controls.Add(this.txtHouseNumbers3);
            this.grpHouseNumbers.Controls.Add(this.txtHouseNumbers2);
            this.grpHouseNumbers.Controls.Add(this.txtHouseNumbers1);
            this.grpHouseNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHouseNumbers.Location = new System.Drawing.Point(38, 229);
            this.grpHouseNumbers.Name = "grpHouseNumbers";
            this.grpHouseNumbers.Size = new System.Drawing.Size(361, 124);
            this.grpHouseNumbers.TabIndex = 1;
            this.grpHouseNumbers.TabStop = false;
            this.grpHouseNumbers.Text = "House Numbers";
            // 
            // txtHouseNumbers4
            // 
            this.txtHouseNumbers4.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtHouseNumbers4.Enabled = false;
            this.txtHouseNumbers4.Location = new System.Drawing.Point(280, 48);
            this.txtHouseNumbers4.Name = "txtHouseNumbers4";
            this.txtHouseNumbers4.Size = new System.Drawing.Size(65, 29);
            this.txtHouseNumbers4.TabIndex = 3;
            this.txtHouseNumbers4.Text = "0";
            this.txtHouseNumbers4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHouseNumbers4.TextChanged += new System.EventHandler(this.txtHouseNumbers4_TextChanged);
            // 
            // txtHouseNumbers3
            // 
            this.txtHouseNumbers3.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtHouseNumbers3.Enabled = false;
            this.txtHouseNumbers3.Location = new System.Drawing.Point(198, 48);
            this.txtHouseNumbers3.Name = "txtHouseNumbers3";
            this.txtHouseNumbers3.Size = new System.Drawing.Size(65, 29);
            this.txtHouseNumbers3.TabIndex = 2;
            this.txtHouseNumbers3.Text = "0";
            this.txtHouseNumbers3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHouseNumbers2
            // 
            this.txtHouseNumbers2.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtHouseNumbers2.Enabled = false;
            this.txtHouseNumbers2.Location = new System.Drawing.Point(117, 48);
            this.txtHouseNumbers2.Name = "txtHouseNumbers2";
            this.txtHouseNumbers2.Size = new System.Drawing.Size(65, 29);
            this.txtHouseNumbers2.TabIndex = 1;
            this.txtHouseNumbers2.Text = "0";
            this.txtHouseNumbers2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHouseNumbers1
            // 
            this.txtHouseNumbers1.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtHouseNumbers1.Enabled = false;
            this.txtHouseNumbers1.Location = new System.Drawing.Point(35, 48);
            this.txtHouseNumbers1.Name = "txtHouseNumbers1";
            this.txtHouseNumbers1.Size = new System.Drawing.Size(65, 29);
            this.txtHouseNumbers1.TabIndex = 0;
            this.txtHouseNumbers1.Text = "0";
            this.txtHouseNumbers1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerateRnadomNumbers
            // 
            this.btnGenerateRnadomNumbers.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGenerateRnadomNumbers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateRnadomNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerateRnadomNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerateRnadomNumbers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerateRnadomNumbers.Location = new System.Drawing.Point(101, 175);
            this.btnGenerateRnadomNumbers.Name = "btnGenerateRnadomNumbers";
            this.btnGenerateRnadomNumbers.Size = new System.Drawing.Size(249, 39);
            this.btnGenerateRnadomNumbers.TabIndex = 4;
            this.btnGenerateRnadomNumbers.Text = "Generate Random Numbers";
            this.btnGenerateRnadomNumbers.UseVisualStyleBackColor = false;
            this.btnGenerateRnadomNumbers.Click += new System.EventHandler(this.btnGenerateRnadomNumbers_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRoll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRoll.Location = new System.Drawing.Point(38, 373);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(86, 39);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(313, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnGenerateRnadomNumbers);
            this.Controls.Add(this.grpHouseNumbers);
            this.Controls.Add(this.grpYourNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpYourNumbers.ResumeLayout(false);
            this.grpYourNumbers.PerformLayout();
            this.grpHouseNumbers.ResumeLayout(false);
            this.grpHouseNumbers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYourNumbers;
        private System.Windows.Forms.TextBox txtYourNumbers4;
        private System.Windows.Forms.TextBox txtYourNumbers3;
        private System.Windows.Forms.TextBox txtYourNumbers2;
        private System.Windows.Forms.TextBox txtYourNumbers1;
        private System.Windows.Forms.GroupBox grpHouseNumbers;
        private System.Windows.Forms.TextBox txtHouseNumbers4;
        private System.Windows.Forms.TextBox txtHouseNumbers3;
        private System.Windows.Forms.TextBox txtHouseNumbers2;
        private System.Windows.Forms.TextBox txtHouseNumbers1;
        private System.Windows.Forms.Button btnGenerateRnadomNumbers;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnReset;
    }
}

