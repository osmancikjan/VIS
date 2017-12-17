namespace OdjezdyAutobusuWF
{
    partial class Zpozdeni
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Zastavka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zpozdeniMinut = new System.Windows.Forms.NumericUpDown();
            this.cisloBus = new System.Windows.Forms.ComboBox();
            this.potvrditZpozdeniButton = new System.Windows.Forms.Button();
            this.nextStop = new System.Windows.Forms.ComboBox();
            this.lastKnown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zpozdeniMinut)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(76, 34);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // Zastavka
            // 
            this.Zastavka.FormattingEnabled = true;
            this.Zastavka.Location = new System.Drawing.Point(76, 7);
            this.Zastavka.Name = "Zastavka";
            this.Zastavka.Size = new System.Drawing.Size(196, 21);
            this.Zastavka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zastavka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "bus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "zpozdeni";
            // 
            // zpozdeniMinut
            // 
            this.zpozdeniMinut.Location = new System.Drawing.Point(152, 92);
            this.zpozdeniMinut.Name = "zpozdeniMinut";
            this.zpozdeniMinut.Size = new System.Drawing.Size(120, 20);
            this.zpozdeniMinut.TabIndex = 9;
            // 
            // cisloBus
            // 
            this.cisloBus.FormattingEnabled = true;
            this.cisloBus.Location = new System.Drawing.Point(152, 60);
            this.cisloBus.Name = "cisloBus";
            this.cisloBus.Size = new System.Drawing.Size(120, 21);
            this.cisloBus.TabIndex = 10;
            // 
            // potvrditZpozdeniButton
            // 
            this.potvrditZpozdeniButton.Location = new System.Drawing.Point(196, 226);
            this.potvrditZpozdeniButton.Name = "potvrditZpozdeniButton";
            this.potvrditZpozdeniButton.Size = new System.Drawing.Size(75, 23);
            this.potvrditZpozdeniButton.TabIndex = 11;
            this.potvrditZpozdeniButton.Text = "potvrdit";
            this.potvrditZpozdeniButton.UseVisualStyleBackColor = true;
            this.potvrditZpozdeniButton.Click += new System.EventHandler(this.potvrditZpozdeniButton_Click);
            // 
            // nextStop
            // 
            this.nextStop.FormattingEnabled = true;
            this.nextStop.Location = new System.Drawing.Point(76, 118);
            this.nextStop.Name = "nextStop";
            this.nextStop.Size = new System.Drawing.Size(195, 21);
            this.nextStop.TabIndex = 12;
            // 
            // lastKnown
            // 
            this.lastKnown.FormattingEnabled = true;
            this.lastKnown.Location = new System.Drawing.Point(76, 145);
            this.lastKnown.Name = "lastKnown";
            this.lastKnown.Size = new System.Drawing.Size(195, 21);
            this.lastKnown.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "next stop";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "last known";
            // 
            // Zpozdeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastKnown);
            this.Controls.Add(this.nextStop);
            this.Controls.Add(this.potvrditZpozdeniButton);
            this.Controls.Add(this.cisloBus);
            this.Controls.Add(this.zpozdeniMinut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zastavka);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Zpozdeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zpozdeni";
            ((System.ComponentModel.ISupportInitialize)(this.zpozdeniMinut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox Zastavka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown zpozdeniMinut;
        private System.Windows.Forms.ComboBox cisloBus;
        private System.Windows.Forms.Button potvrditZpozdeniButton;
        private System.Windows.Forms.ComboBox nextStop;
        private System.Windows.Forms.ComboBox lastKnown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}