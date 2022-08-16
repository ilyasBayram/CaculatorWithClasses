
namespace CaculatorWithClasses
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
            this.LblNumber1 = new System.Windows.Forms.Label();
            this.LblNumber2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxBoxNumber1 = new System.Windows.Forms.TextBox();
            this.TxBoxNumber2 = new System.Windows.Forms.TextBox();
            this.BtnAddition = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMultply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNumber1
            // 
            this.LblNumber1.AutoSize = true;
            this.LblNumber1.Location = new System.Drawing.Point(23, 36);
            this.LblNumber1.Name = "LblNumber1";
            this.LblNumber1.Size = new System.Drawing.Size(86, 20);
            this.LblNumber1.TabIndex = 0;
            this.LblNumber1.Text = "Number 1 :";
            // 
            // LblNumber2
            // 
            this.LblNumber2.AutoSize = true;
            this.LblNumber2.Location = new System.Drawing.Point(23, 93);
            this.LblNumber2.Name = "LblNumber2";
            this.LblNumber2.Size = new System.Drawing.Size(86, 20);
            this.LblNumber2.TabIndex = 1;
            this.LblNumber2.Text = "Number 2 :";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(419, 64);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(55, 20);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "Result";
            // 
            // TxBoxNumber1
            // 
            this.TxBoxNumber1.Location = new System.Drawing.Point(132, 36);
            this.TxBoxNumber1.Name = "TxBoxNumber1";
            this.TxBoxNumber1.Size = new System.Drawing.Size(182, 26);
            this.TxBoxNumber1.TabIndex = 3;
            // 
            // TxBoxNumber2
            // 
            this.TxBoxNumber2.Location = new System.Drawing.Point(132, 90);
            this.TxBoxNumber2.Name = "TxBoxNumber2";
            this.TxBoxNumber2.Size = new System.Drawing.Size(182, 26);
            this.TxBoxNumber2.TabIndex = 4;
            // 
            // BtnAddition
            // 
            this.BtnAddition.Location = new System.Drawing.Point(38, 192);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(98, 52);
            this.BtnAddition.TabIndex = 5;
            this.BtnAddition.Text = "Add";
            this.BtnAddition.UseVisualStyleBackColor = true;
            this.BtnAddition.Click += new System.EventHandler(this.BtnAddition_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(203, 192);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(98, 52);
            this.BtnMinus.TabIndex = 6;
            this.BtnMinus.Text = "Subtract";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMultply
            // 
            this.BtnMultply.Location = new System.Drawing.Point(38, 290);
            this.BtnMultply.Name = "BtnMultply";
            this.BtnMultply.Size = new System.Drawing.Size(98, 52);
            this.BtnMultply.TabIndex = 7;
            this.BtnMultply.Text = "Multiplication";
            this.BtnMultply.UseVisualStyleBackColor = true;
            this.BtnMultply.Click += new System.EventHandler(this.BtnMultply_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(203, 290);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(98, 52);
            this.BtnDivide.TabIndex = 8;
            this.BtnDivide.Text = "Division";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 408);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultply);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnAddition);
            this.Controls.Add(this.TxBoxNumber2);
            this.Controls.Add(this.TxBoxNumber1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblNumber2);
            this.Controls.Add(this.LblNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumber1;
        private System.Windows.Forms.Label LblNumber2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxBoxNumber1;
        private System.Windows.Forms.TextBox TxBoxNumber2;
        private System.Windows.Forms.Button BtnAddition;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMultply;
        private System.Windows.Forms.Button BtnDivide;
    }
}

