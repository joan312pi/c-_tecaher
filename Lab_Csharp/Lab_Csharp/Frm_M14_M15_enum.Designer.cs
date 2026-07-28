namespace Lab_Csharp
{
    partial class Frm_M14_M15_enum
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "參數為實質型別";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "參數為參考型別";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "ref";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 50);
            this.button4.TabIndex = 2;
            this.button4.Text = "out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "Params";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Enabled = false;
            this.btnProduct.Location = new System.Drawing.Point(471, 50);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(117, 67);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(299, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "驗證一";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(299, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "驗證二";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(299, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 34);
            this.button8.TabIndex = 7;
            this.button8.Text = "驗證 enum列舉";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Frm_M14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_M14";
            this.Text = "Frm_M14";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}