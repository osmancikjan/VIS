namespace OdjezdyAutobusuWF
{
    partial class AddUser
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
            this.id = new System.Windows.Forms.TextBox();
            this.jmeno = new System.Windows.Forms.TextBox();
            this.prijmeni = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.heslo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pridat = new System.Windows.Forms.Button();
            this.perm = new System.Windows.Forms.Label();
            this.permision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "jmeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "prijmeni";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(63, 5);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(53, 20);
            this.id.TabIndex = 3;
            // 
            // jmeno
            // 
            this.jmeno.Location = new System.Drawing.Point(63, 31);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(118, 20);
            this.jmeno.TabIndex = 4;
            // 
            // prijmeni
            // 
            this.prijmeni.Location = new System.Drawing.Point(63, 57);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(154, 20);
            this.prijmeni.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(63, 83);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(154, 20);
            this.email.TabIndex = 6;
            // 
            // heslo
            // 
            this.heslo.Location = new System.Drawing.Point(63, 109);
            this.heslo.Name = "heslo";
            this.heslo.Size = new System.Drawing.Size(154, 20);
            this.heslo.TabIndex = 7;
            this.heslo.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "heslo";
            // 
            // pridat
            // 
            this.pridat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pridat.Location = new System.Drawing.Point(136, 167);
            this.pridat.Name = "pridat";
            this.pridat.Size = new System.Drawing.Size(75, 23);
            this.pridat.TabIndex = 11;
            this.pridat.Text = "pridat";
            this.pridat.UseVisualStyleBackColor = true;
            this.pridat.Click += new System.EventHandler(this.pridat_Click);
            // 
            // perm
            // 
            this.perm.AutoSize = true;
            this.perm.Location = new System.Drawing.Point(7, 137);
            this.perm.Name = "perm";
            this.perm.Size = new System.Drawing.Size(51, 13);
            this.perm.TabIndex = 12;
            this.perm.Text = "permision";
            // 
            // permision
            // 
            this.permision.Location = new System.Drawing.Point(64, 135);
            this.permision.Name = "permision";
            this.permision.Size = new System.Drawing.Size(154, 20);
            this.permision.TabIndex = 13;
            this.permision.UseSystemPasswordChar = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 202);
            this.Controls.Add(this.permision);
            this.Controls.Add(this.perm);
            this.Controls.Add(this.pridat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heslo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.prijmeni);
            this.Controls.Add(this.jmeno);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox jmeno;
        private System.Windows.Forms.TextBox prijmeni;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox heslo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pridat;
        private System.Windows.Forms.Label perm;
        private System.Windows.Forms.TextBox permision;
    }
}