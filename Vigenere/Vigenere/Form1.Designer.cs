namespace Vigenere
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.DecryptionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.txtKeyToEncrypt = new System.Windows.Forms.TextBox();
            this.txtAfterEncrypt = new System.Windows.Forms.TextBox();
            this.txtToDecrypt = new System.Windows.Forms.TextBox();
            this.txtKeyToDecrypt = new System.Windows.Forms.TextBox();
            this.txtAfterDecrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Location = new System.Drawing.Point(196, 228);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(94, 29);
            this.EncryptionButton.TabIndex = 0;
            this.EncryptionButton.Text = "Encrypt";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // DecryptionButton
            // 
            this.DecryptionButton.Location = new System.Drawing.Point(668, 228);
            this.DecryptionButton.Name = "DecryptionButton";
            this.DecryptionButton.Size = new System.Drawing.Size(94, 29);
            this.DecryptionButton.TabIndex = 1;
            this.DecryptionButton.Text = "Decrypt";
            this.DecryptionButton.UseVisualStyleBackColor = true;
            this.DecryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(569, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text to encrypt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Encrypter text:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Text to decrypt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Key:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Decrypter text:";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Location = new System.Drawing.Point(133, 64);
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(157, 27);
            this.txtToEncrypt.TabIndex = 10;
            // 
            // txtKeyToEncrypt
            // 
            this.txtKeyToEncrypt.Location = new System.Drawing.Point(133, 97);
            this.txtKeyToEncrypt.Name = "txtKeyToEncrypt";
            this.txtKeyToEncrypt.Size = new System.Drawing.Size(157, 27);
            this.txtKeyToEncrypt.TabIndex = 11;
            // 
            // txtAfterEncrypt
            // 
            this.txtAfterEncrypt.Location = new System.Drawing.Point(133, 168);
            this.txtAfterEncrypt.Name = "txtAfterEncrypt";
            this.txtAfterEncrypt.Size = new System.Drawing.Size(157, 27);
            this.txtAfterEncrypt.TabIndex = 12;
            // 
            // txtToDecrypt
            // 
            this.txtToDecrypt.Location = new System.Drawing.Point(605, 54);
            this.txtToDecrypt.Name = "txtToDecrypt";
            this.txtToDecrypt.Size = new System.Drawing.Size(157, 27);
            this.txtToDecrypt.TabIndex = 13;
            // 
            // txtKeyToDecrypt
            // 
            this.txtKeyToDecrypt.Location = new System.Drawing.Point(605, 87);
            this.txtKeyToDecrypt.Name = "txtKeyToDecrypt";
            this.txtKeyToDecrypt.Size = new System.Drawing.Size(157, 27);
            this.txtKeyToDecrypt.TabIndex = 14;
            // 
            // txtAfterDecrypt
            // 
            this.txtAfterDecrypt.Location = new System.Drawing.Point(605, 175);
            this.txtAfterDecrypt.Name = "txtAfterDecrypt";
            this.txtAfterDecrypt.Size = new System.Drawing.Size(157, 27);
            this.txtAfterDecrypt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.txtAfterDecrypt);
            this.Controls.Add(this.txtKeyToDecrypt);
            this.Controls.Add(this.txtToDecrypt);
            this.Controls.Add(this.txtAfterEncrypt);
            this.Controls.Add(this.txtKeyToEncrypt);
            this.Controls.Add(this.txtToEncrypt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecryptionButton);
            this.Controls.Add(this.EncryptionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EncryptionButton;
        private Button DecryptionButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtToEncrypt;
        private TextBox txtKeyToEncrypt;
        private TextBox txtAfterEncrypt;
        private TextBox txtToDecrypt;
        private TextBox txtKeyToDecrypt;
        private TextBox txtAfterDecrypt;
    }
}