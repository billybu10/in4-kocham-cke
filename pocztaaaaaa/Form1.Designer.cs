namespace pocztaaaaaa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioPackage = new System.Windows.Forms.RadioButton();
            this.radioLetter = new System.Windows.Forms.RadioButton();
            this.radioPostcard = new System.Windows.Forms.RadioButton();
            this.buttonCheckPrice = new System.Windows.Forms.Button();
            this.pictureBoxType = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioPackage);
            this.groupBoxType.Controls.Add(this.radioLetter);
            this.groupBoxType.Controls.Add(this.radioPostcard);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(200, 85);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Rodzaj przesyłki";
            // 
            // radioPackage
            // 
            this.radioPackage.AutoSize = true;
            this.radioPackage.Location = new System.Drawing.Point(7, 68);
            this.radioPackage.Name = "radioPackage";
            this.radioPackage.Size = new System.Drawing.Size(61, 17);
            this.radioPackage.TabIndex = 2;
            this.radioPackage.TabStop = true;
            this.radioPackage.Text = "Paczka";
            this.radioPackage.UseVisualStyleBackColor = true;
            // 
            // radioLetter
            // 
            this.radioLetter.AutoSize = true;
            this.radioLetter.Location = new System.Drawing.Point(7, 44);
            this.radioLetter.Name = "radioLetter";
            this.radioLetter.Size = new System.Drawing.Size(41, 17);
            this.radioLetter.TabIndex = 1;
            this.radioLetter.TabStop = true;
            this.radioLetter.Text = "List";
            this.radioLetter.UseVisualStyleBackColor = true;
            // 
            // radioPostcard
            // 
            this.radioPostcard.AutoSize = true;
            this.radioPostcard.Location = new System.Drawing.Point(7, 20);
            this.radioPostcard.Name = "radioPostcard";
            this.radioPostcard.Size = new System.Drawing.Size(78, 17);
            this.radioPostcard.TabIndex = 0;
            this.radioPostcard.TabStop = true;
            this.radioPostcard.Text = "Pocztówka";
            this.radioPostcard.UseVisualStyleBackColor = true;
            // 
            // buttonCheckPrice
            // 
            this.buttonCheckPrice.Location = new System.Drawing.Point(13, 128);
            this.buttonCheckPrice.Name = "buttonCheckPrice";
            this.buttonCheckPrice.Size = new System.Drawing.Size(200, 23);
            this.buttonCheckPrice.TabIndex = 1;
            this.buttonCheckPrice.Text = "Sprawdź cenę";
            this.buttonCheckPrice.UseVisualStyleBackColor = true;
            this.buttonCheckPrice.Click += new System.EventHandler(this.buttonCheckPrice_Click);
            // 
            // pictureBoxType
            // 
            this.pictureBoxType.Location = new System.Drawing.Point(13, 157);
            this.pictureBoxType.Name = "pictureBoxType";
            this.pictureBoxType.Size = new System.Drawing.Size(100, 67);
            this.pictureBoxType.TabIndex = 2;
            this.pictureBoxType.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(119, 157);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 25);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Cena :";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBox1);
            this.groupBoxData.Controls.Add(this.label3);
            this.groupBoxData.Controls.Add(this.textBoxPostCode);
            this.groupBoxData.Controls.Add(this.label2);
            this.groupBoxData.Controls.Add(this.textBoxStreet);
            this.groupBoxData.Controls.Add(this.label1);
            this.groupBoxData.Location = new System.Drawing.Point(301, 13);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(293, 161);
            this.groupBoxData.TabIndex = 4;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dane adresowe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miasto";
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(10, 76);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kod pocztowy";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(10, 37);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(277, 20);
            this.textBoxStreet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ulica z numerem";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(12, 230);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(582, 23);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Zatwierdź";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ilość";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBoxType);
            this.Controls.Add(this.buttonCheckPrice);
            this.Controls.Add(this.groupBoxType);
            this.Name = "Form1";
            this.Text = "Nadaj Przesyłkę PESEL";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioPackage;
        private System.Windows.Forms.RadioButton radioLetter;
        private System.Windows.Forms.RadioButton radioPostcard;
        private System.Windows.Forms.Button buttonCheckPrice;
        private System.Windows.Forms.PictureBox pictureBoxType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}


