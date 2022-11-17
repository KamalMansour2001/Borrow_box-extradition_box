namespace Lånabox
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
            this.btnLämnaTbks = new System.Windows.Forms.Button();
            this.txtAnvänderNamn = new System.Windows.Forms.TextBox();
            this.txtLössenord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnJagvillLåna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLämnaTbks
            // 
            this.btnLämnaTbks.Location = new System.Drawing.Point(304, 261);
            this.btnLämnaTbks.Name = "btnLämnaTbks";
            this.btnLämnaTbks.Size = new System.Drawing.Size(216, 79);
            this.btnLämnaTbks.TabIndex = 1;
            this.btnLämnaTbks.Text = "Vill lämna Till baka";
            this.btnLämnaTbks.UseVisualStyleBackColor = true;
            this.btnLämnaTbks.Click += new System.EventHandler(this.btnLämnaTbks_Click);
            // 
            // txtAnvänderNamn
            // 
            this.txtAnvänderNamn.Location = new System.Drawing.Point(49, 107);
            this.txtAnvänderNamn.Multiline = true;
            this.txtAnvänderNamn.Name = "txtAnvänderNamn";
            this.txtAnvänderNamn.Size = new System.Drawing.Size(154, 21);
            this.txtAnvänderNamn.TabIndex = 2;
            // 
            // txtLössenord
            // 
            this.txtLössenord.Location = new System.Drawing.Point(304, 107);
            this.txtLössenord.Multiline = true;
            this.txtLössenord.Name = "txtLössenord";
            this.txtLössenord.Size = new System.Drawing.Size(160, 21);
            this.txtLössenord.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lössenord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Använder Namn:";
            // 
            // bttnJagvillLåna
            // 
            this.bttnJagvillLåna.Location = new System.Drawing.Point(49, 261);
            this.bttnJagvillLåna.Name = "bttnJagvillLåna";
            this.bttnJagvillLåna.Size = new System.Drawing.Size(213, 79);
            this.bttnJagvillLåna.TabIndex = 6;
            this.bttnJagvillLåna.Text = "Jag vill Låna";
            this.bttnJagvillLåna.UseVisualStyleBackColor = true;
            this.bttnJagvillLåna.Click += new System.EventHandler(this.bttnJagvillLåna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 409);
            this.Controls.Add(this.bttnJagvillLåna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLössenord);
            this.Controls.Add(this.txtAnvänderNamn);
            this.Controls.Add(this.btnLämnaTbks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLämnaTbks;
        private System.Windows.Forms.TextBox txtAnvänderNamn;
        private System.Windows.Forms.TextBox txtLössenord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnJagvillLåna;
    }
}

