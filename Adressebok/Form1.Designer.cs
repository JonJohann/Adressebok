namespace Adressebok
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
            this.navnListe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.navn = new System.Windows.Forms.TextBox();
            this.bosted = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.slett = new System.Windows.Forms.Button();
            this.lukk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.sersj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navnListe
            // 
            this.navnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navnListe.FormattingEnabled = true;
            this.navnListe.ItemHeight = 16;
            this.navnListe.Location = new System.Drawing.Point(270, 6);
            this.navnListe.Name = "navnListe";
            this.navnListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.navnListe.Size = new System.Drawing.Size(479, 292);
            this.navnListe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bosted:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon:";
            // 
            // navn
            // 
            this.navn.Location = new System.Drawing.Point(75, 40);
            this.navn.Name = "navn";
            this.navn.Size = new System.Drawing.Size(183, 20);
            this.navn.TabIndex = 5;
            // 
            // bosted
            // 
            this.bosted.Location = new System.Drawing.Point(75, 71);
            this.bosted.Name = "bosted";
            this.bosted.Size = new System.Drawing.Size(183, 20);
            this.bosted.TabIndex = 6;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(75, 102);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(183, 20);
            this.telefon.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(75, 133);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(183, 20);
            this.email.TabIndex = 8;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(12, 159);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(177, 114);
            this.add.TabIndex = 9;
            this.add.Text = "Legg til";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // slett
            // 
            this.slett.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slett.Location = new System.Drawing.Point(195, 159);
            this.slett.Name = "slett";
            this.slett.Size = new System.Drawing.Size(69, 72);
            this.slett.TabIndex = 10;
            this.slett.Text = "Slett";
            this.slett.UseVisualStyleBackColor = true;
            this.slett.Click += new System.EventHandler(this.button2_Click);
            // 
            // lukk
            // 
            this.lukk.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lukk.Location = new System.Drawing.Point(195, 237);
            this.lukk.Name = "lukk";
            this.lukk.Size = new System.Drawing.Size(69, 35);
            this.lukk.TabIndex = 11;
            this.lukk.Text = "Lukk";
            this.lukk.UseVisualStyleBackColor = true;
            this.lukk.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adressebok";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 278);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(177, 20);
            this.search.TabIndex = 13;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // sersj
            // 
            this.sersj.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sersj.Location = new System.Drawing.Point(195, 278);
            this.sersj.Name = "sersj";
            this.sersj.Size = new System.Drawing.Size(69, 27);
            this.sersj.TabIndex = 14;
            this.sersj.Text = "Søk";
            this.sersj.UseVisualStyleBackColor = true;
            this.sersj.Click += new System.EventHandler(this.sersj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(761, 308);
            this.Controls.Add(this.sersj);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lukk);
            this.Controls.Add(this.slett);
            this.Controls.Add(this.add);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.bosted);
            this.Controls.Add(this.navn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navnListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adressebok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox navnListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox navn;
        private System.Windows.Forms.TextBox bosted;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button slett;
        private System.Windows.Forms.Button lukk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button sersj;
    }
}

