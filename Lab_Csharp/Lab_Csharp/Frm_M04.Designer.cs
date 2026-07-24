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
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(573, 39);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(177, 35);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open HelloForm";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(573, 99);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(177, 35);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "呼叫不同類別的方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "有回傳值Method";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "封裝練習";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Partial Class";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "new Member";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(98, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "註冊事件";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRegisterEvent01
            // 
            this.btnRegisterEvent01.Location = new System.Drawing.Point(101, 179);
            this.btnRegisterEvent01.Name = "btnRegisterEvent01";
            this.btnRegisterEvent01.Size = new System.Drawing.Size(174, 35);
            this.btnRegisterEvent01.TabIndex = 8;
            this.btnRegisterEvent01.Text = "RegisterEvent01";
            this.btnRegisterEvent01.UseVisualStyleBackColor = true;
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}