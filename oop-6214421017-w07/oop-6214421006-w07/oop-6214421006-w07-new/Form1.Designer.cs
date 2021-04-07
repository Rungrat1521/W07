
namespace oop_6214421017_w07_new
{
    partial class Name
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.incomeText = new System.Windows.Forms.TextBox();
            this.dispenseText = new System.Windows.Forms.TextBox();
            this.OuputName = new System.Windows.Forms.Label();
            this.OutputTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายได้";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายจ่าย";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(140, 47);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(108, 20);
            this.nameText.TabIndex = 3;
            // 
            // incomeText
            // 
            this.incomeText.Location = new System.Drawing.Point(140, 86);
            this.incomeText.Name = "incomeText";
            this.incomeText.Size = new System.Drawing.Size(108, 20);
            this.incomeText.TabIndex = 4;
            // 
            // dispenseText
            // 
            this.dispenseText.Location = new System.Drawing.Point(140, 125);
            this.dispenseText.Name = "dispenseText";
            this.dispenseText.Size = new System.Drawing.Size(108, 20);
            this.dispenseText.TabIndex = 5;
            // 
            // OuputName
            // 
            this.OuputName.AutoSize = true;
            this.OuputName.Location = new System.Drawing.Point(56, 212);
            this.OuputName.Name = "OuputName";
            this.OuputName.Size = new System.Drawing.Size(20, 13);
            this.OuputName.TabIndex = 6;
            this.OuputName.Text = "ชื่อ";
            // 
            // OutputTotal
            // 
            this.OutputTotal.AutoSize = true;
            this.OutputTotal.Location = new System.Drawing.Point(56, 247);
            this.OutputTotal.Name = "OutputTotal";
            this.OutputTotal.Size = new System.Drawing.Size(70, 13);
            this.OutputTotal.TabIndex = 7;
            this.OutputTotal.Text = "ภาษีที่ต้องจ่าย";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputTotal);
            this.Controls.Add(this.OuputName);
            this.Controls.Add(this.dispenseText);
            this.Controls.Add(this.incomeText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Name";
            this.Text = "รายได้-รายจ่าย";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox incomeText;
        private System.Windows.Forms.TextBox dispenseText;
        private System.Windows.Forms.Label OuputName;
        private System.Windows.Forms.Label OutputTotal;
        private System.Windows.Forms.Button button1;
    }
}

