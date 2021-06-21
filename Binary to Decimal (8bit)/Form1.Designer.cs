
namespace Binary_to_Decimal__8bit_
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDezInput = new System.Windows.Forms.TextBox();
            this.btnDez2Bin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binärzahlen :-";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(42, 68);
            this.txt1.MaxLength = 1;
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(27, 35);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(75, 68);
            this.txt2.MaxLength = 1;
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(26, 35);
            this.txt2.TabIndex = 2;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(106, 68);
            this.txt3.MaxLength = 1;
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(27, 35);
            this.txt3.TabIndex = 3;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(139, 68);
            this.txt4.MaxLength = 1;
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(28, 35);
            this.txt4.TabIndex = 4;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(273, 68);
            this.txt8.MaxLength = 1;
            this.txt8.Multiline = true;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(28, 35);
            this.txt8.TabIndex = 8;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(238, 68);
            this.txt7.MaxLength = 1;
            this.txt7.Multiline = true;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(27, 35);
            this.txt7.TabIndex = 7;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(206, 68);
            this.txt6.MaxLength = 1;
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(26, 35);
            this.txt6.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(173, 68);
            this.txt5.MaxLength = 1;
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(27, 35);
            this.txt5.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(95, 124);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(137, 45);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Bin > Dez";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Ausgang";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Konvertierungssystem";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(42, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Löschen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResOutput
            // 
            this.txtResOutput.Location = new System.Drawing.Point(190, 244);
            this.txtResOutput.Multiline = true;
            this.txtResOutput.Name = "txtResOutput";
            this.txtResOutput.Size = new System.Drawing.Size(258, 42);
            this.txtResOutput.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ergebnis :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dezimal Zahl:-";
            // 
            // txtDezInput
            // 
            this.txtDezInput.Location = new System.Drawing.Point(374, 68);
            this.txtDezInput.Multiline = true;
            this.txtDezInput.Name = "txtDezInput";
            this.txtDezInput.Size = new System.Drawing.Size(260, 35);
            this.txtDezInput.TabIndex = 16;
            // 
            // btnDez2Bin
            // 
            this.btnDez2Bin.Location = new System.Drawing.Point(417, 124);
            this.btnDez2Bin.Name = "btnDez2Bin";
            this.btnDez2Bin.Size = new System.Drawing.Size(161, 45);
            this.btnDez2Bin.TabIndex = 17;
            this.btnDez2Bin.Text = "Dez > Bin";
            this.btnDez2Bin.UseVisualStyleBackColor = true;
            this.btnDez2Bin.Click += new System.EventHandler(this.btnDez2Bin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 416);
            this.Controls.Add(this.btnDez2Bin);
            this.Controls.Add(this.txtDezInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bin2Dez Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDezInput;
        private System.Windows.Forms.Button btnDez2Bin;
    }
}

