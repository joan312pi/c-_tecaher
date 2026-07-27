namespace Lab_Form
{
    partial class Frm_M04
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRegisterEvent01 = new System.Windows.Forms.Button();
            this.btnRegisterEvent02 = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(290, 28);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(177, 35);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open HelloForm";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(290, 88);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(177, 35);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "呼叫不同類別的方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "有回傳值Method";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "封裝練習";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Partial Class";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "new Member";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "註冊事件";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRegisterEvent01
            // 
            this.btnRegisterEvent01.Location = new System.Drawing.Point(26, 168);
            this.btnRegisterEvent01.Name = "btnRegisterEvent01";
            this.btnRegisterEvent01.Size = new System.Drawing.Size(174, 35);
            this.btnRegisterEvent01.TabIndex = 8;
            this.btnRegisterEvent01.Text = "RegisterEvent01";
            this.btnRegisterEvent01.UseVisualStyleBackColor = true;
            // 
            // btnRegisterEvent02
            // 
            this.btnRegisterEvent02.Location = new System.Drawing.Point(26, 220);
            this.btnRegisterEvent02.Name = "btnRegisterEvent02";
            this.btnRegisterEvent02.Size = new System.Drawing.Size(174, 35);
            this.btnRegisterEvent02.TabIndex = 9;
            this.btnRegisterEvent02.Text = "RegisterEvent02";
            this.btnRegisterEvent02.UseVisualStyleBackColor = true;
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(26, 334);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(174, 35);
            this.btnDelegate.TabIndex = 10;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(26, 271);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '+';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrice.Size = new System.Drawing.Size(174, 57);
            this.txtPrice.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(293, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 35);
            this.button7.TabIndex = 12;
            this.button7.Text = "MessageBox";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnRegisterEvent02);
            this.Controls.Add(this.btnRegisterEvent01);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRegisterEvent01;
        private System.Windows.Forms.Button btnRegisterEvent02;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}