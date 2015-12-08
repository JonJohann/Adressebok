using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Adressebok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            search.ForeColor = Color.Gray;
            search.Text = "Fornavn";

            foreach (string line in richTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None)
            {
                navnListe.Items.Add(line);
            }
        }

        string[] adr = new string[20];
        int clicked = 0;
        string fileName = @".\adresse.txt"; //@"C:\Temp\brukere.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            if (navn.Text == "" || bosted.Text == "" || telefon.Text == "" || email.Text == "")
            {
                MessageBox.Show("Alle feltene må fylles ut");
            }
            else
            {
                for (int r = 0; r <= clicked;)
                {
                    adr[r] = navn.Text + " ; " + bosted.Text + " ; " + telefon.Text + " ; " + email.Text;
                    navnListe.Items.Add(adr[r]);
                    break;
                }
                navn.Text = "";
                bosted.Text = "";
                telefon.Text = "";
                email.Text = "";
                save();
                clicked++;

                
            
            }

        } //legge til info knapp

        private void button3_Click(object sender, EventArgs e) //lukke knapp
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //lslett knapp
        {
            for (int i = navnListe.SelectedIndices.Count - 1; i >= 0; i--)
            {
                navnListe.Items.RemoveAt(navnListe.SelectedIndices[i]);
            }
        }

        private void sersj_Click(object sender, EventArgs e)
        {
            
            string searchWord = search.Text;
            
            int index = navnListe.FindString(searchWord, -1);
            if (index != -1)
            {
               
                navnListe.SetSelected(index, true);
               
            }
            else
                MessageBox.Show("Finner ikke person. Har du skrevet fornavn riktig?");
            search.ForeColor = Color.Gray;
            search.Text = "Fornavn";
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
            search.ForeColor = Color.Black;
        }

        public void save()
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            FileInfo fi = new FileInfo(fileName);
            StreamWriter writer = fi.AppendText();
            writer.WriteLine(navnListe.Text);
            writer.Close();
            writer.Dispose();
        }
    }
}
