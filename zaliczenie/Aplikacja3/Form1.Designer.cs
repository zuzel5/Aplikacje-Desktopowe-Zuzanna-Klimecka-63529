
namespace Aplikacja3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataUrodzin = new System.Windows.Forms.Label();
            this.fullNameTexBox = new System.Windows.Forms.TextBox();
            this.lblLiczbaWiek = new System.Windows.Forms.Label();
            this.buttomWiek = new System.Windows.Forms.Button();
            this.fullNameButton = new System.Windows.Forms.Button();
            this.txtimieNazwisko = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie i Nazwisko";
            // 
            // lblDataUrodzin
            // 
            this.lblDataUrodzin.AutoSize = true;
            this.lblDataUrodzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataUrodzin.Location = new System.Drawing.Point(56, 229);
            this.lblDataUrodzin.Name = "lblDataUrodzin";
            this.lblDataUrodzin.Size = new System.Drawing.Size(378, 69);
            this.lblDataUrodzin.TabIndex = 1;
            this.lblDataUrodzin.Text = "Data Urodzin";
            // 
            // fullNameTexBox
            // 
            this.fullNameTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullNameTexBox.Location = new System.Drawing.Point(533, 87);
            this.fullNameTexBox.Name = "fullNameTexBox";
            this.fullNameTexBox.Size = new System.Drawing.Size(731, 75);
            this.fullNameTexBox.TabIndex = 0;
            // 
            // lblLiczbaWiek
            // 
            this.lblLiczbaWiek.AutoSize = true;
            this.lblLiczbaWiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczbaWiek.Location = new System.Drawing.Point(452, 586);
            this.lblLiczbaWiek.Name = "lblLiczbaWiek";
            this.lblLiczbaWiek.Size = new System.Drawing.Size(0, 69);
            this.lblLiczbaWiek.TabIndex = 4;
            // 
            // buttomWiek
            // 
            this.buttomWiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttomWiek.Location = new System.Drawing.Point(54, 449);
            this.buttomWiek.Name = "buttomWiek";
            this.buttomWiek.Size = new System.Drawing.Size(274, 87);
            this.buttomWiek.TabIndex = 8;
            this.buttomWiek.Text = "Liczba Lat";
            this.buttomWiek.UseVisualStyleBackColor = true;
            this.buttomWiek.Click += new System.EventHandler(this.cmdWiek_Click);
            // 
            // fullNameButton
            // 
            this.fullNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullNameButton.Location = new System.Drawing.Point(404, 449);
            this.fullNameButton.Name = "fullNameButton";
            this.fullNameButton.Size = new System.Drawing.Size(443, 87);
            this.fullNameButton.TabIndex = 1;
            this.fullNameButton.Text = "Imie i Nazwisko";
            this.fullNameButton.UseVisualStyleBackColor = true;
            this.fullNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtimieNazwisko
            // 
            this.txtimieNazwisko.AutoSize = true;
            this.txtimieNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtimieNazwisko.Location = new System.Drawing.Point(404, 638);
            this.txtimieNazwisko.Name = "txtimieNazwisko";
            this.txtimieNazwisko.Size = new System.Drawing.Size(42, 63);
            this.txtimieNazwisko.TabIndex = 2;
            this.txtimieNazwisko.Text = ":";
            // 
            // ageTextBox
            // 
            this.ageTextBox.AutoSize = true;
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageTextBox.Location = new System.Drawing.Point(56, 638);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(42, 63);
            this.ageTextBox.TabIndex = 13;
            this.ageTextBox.Text = ":";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(533, 243);
            this.dateTimePicker.MaxDate = new System.DateTime(2023, 2, 5, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(763, 55);
            this.dateTimePicker.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 883);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.txtimieNazwisko);
            this.Controls.Add(this.fullNameButton);
            this.Controls.Add(this.buttomWiek);
            this.Controls.Add(this.lblLiczbaWiek);
            this.Controls.Add(this.fullNameTexBox);
            this.Controls.Add(this.lblDataUrodzin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataUrodzin;
        private System.Windows.Forms.TextBox fullNameTexBox;
        private System.Windows.Forms.Label lblLiczbaWiek;
        private System.Windows.Forms.Button buttomWiek;
        private System.Windows.Forms.Button fullNameButton;
        private System.Windows.Forms.Label txtimieNazwisko;
        private System.Windows.Forms.Label ageTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

