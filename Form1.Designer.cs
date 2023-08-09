
namespace INKI708Proekt3AleksandarKarapanchevski
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
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.btnEnkripcija = new System.Windows.Forms.Button();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.txtDecMsg = new System.Windows.Forms.TextBox();
            this.btnDekripcija = new System.Windows.Forms.Button();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPublic
            // 
            this.txtPublic.Location = new System.Drawing.Point(34, 12);
            this.txtPublic.Multiline = true;
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(184, 90);
            this.txtPublic.TabIndex = 0;
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(43, 151);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(175, 20);
            this.txtPlain.TabIndex = 1;
            // 
            // btnEnkripcija
            // 
            this.btnEnkripcija.Location = new System.Drawing.Point(88, 211);
            this.btnEnkripcija.Name = "btnEnkripcija";
            this.btnEnkripcija.Size = new System.Drawing.Size(95, 23);
            this.btnEnkripcija.TabIndex = 2;
            this.btnEnkripcija.Text = "Enkripcija";
            this.btnEnkripcija.UseVisualStyleBackColor = true;
            this.btnEnkripcija.Click += new System.EventHandler(this.btnEnkripcija_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(43, 279);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(188, 108);
            this.txtEncrypt.TabIndex = 3;
            // 
            // txtPrivate
            // 
            this.txtPrivate.Location = new System.Drawing.Point(425, 12);
            this.txtPrivate.Multiline = true;
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.Size = new System.Drawing.Size(189, 91);
            this.txtPrivate.TabIndex = 4;
            // 
            // txtDecMsg
            // 
            this.txtDecMsg.Location = new System.Drawing.Point(425, 151);
            this.txtDecMsg.Multiline = true;
            this.txtDecMsg.Name = "txtDecMsg";
            this.txtDecMsg.Size = new System.Drawing.Size(189, 83);
            this.txtDecMsg.TabIndex = 5;
            // 
            // btnDekripcija
            // 
            this.btnDekripcija.Location = new System.Drawing.Point(471, 250);
            this.btnDekripcija.Name = "btnDekripcija";
            this.btnDekripcija.Size = new System.Drawing.Size(102, 23);
            this.btnDekripcija.TabIndex = 6;
            this.btnDekripcija.Text = "Dekripcija";
            this.btnDekripcija.UseVisualStyleBackColor = true;
            this.btnDekripcija.Click += new System.EventHandler(this.btnDekripcija_Click);
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(425, 315);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(197, 96);
            this.txtDecrypt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enkriptiran Tekst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.btnDekripcija);
            this.Controls.Add(this.txtDecMsg);
            this.Controls.Add(this.txtPrivate);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.btnEnkripcija);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.txtPublic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPublic;
        public System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Button btnEnkripcija;
        public System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.TextBox txtDecMsg;
        private System.Windows.Forms.Button btnDekripcija;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

