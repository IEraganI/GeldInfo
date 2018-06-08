using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmGeldausgabe : Form
    {
        public frmGeldausgabe()
        {
            InitializeComponent();
        }


        private void cmdAusgebn_Click(object sender, EventArgs e)
        {
            double RestBetrag;
            double anzahlHunderter, anzahlFuffziger, anzahlZwanziger, anzahlZehner, anzahlFuenfer;
            double GesamtGeld;
            

            this.lstGeldscheine.Items.Clear();
            RestBetrag = Convert.ToDouble(this.txtAusgabebetrag.Text);

            anzahlHunderter = Convert.ToDouble(this.txt100er.Text);
            anzahlFuffziger = Convert.ToDouble(this.txt50er.Text);
            anzahlZwanziger = Convert.ToDouble(this.txt20er.Text);
            anzahlZehner = Convert.ToDouble(this.txt10er.Text);
            anzahlFuenfer = Convert.ToDouble(this.txt5er.Text);
            GesamtGeld = anzahlHunderter * 100 + anzahlFuffziger * 50 + anzahlZwanziger * 20 + anzahlZehner * 10 + anzahlFuenfer * 5;

            if (GesamtGeld - RestBetrag < 0)
            {
                MessageBox.Show("Kein Geld");
            }




            else
            {
                    //Hunderter ausgeben
                    while ((RestBetrag >= 100) && (anzahlHunderter > 0))
                    {
                        this.lstGeldscheine.Items.Add("100");
                        RestBetrag = RestBetrag - 100;
                        anzahlHunderter = anzahlHunderter - 1;
                    }
                    this.txt100er.Text = anzahlHunderter.ToString();

                    //Fuffziger ausgeben
                    while ((RestBetrag >= 50) && (anzahlFuffziger > 0))
                    {
                        this.lstGeldscheine.Items.Add("50");
                        RestBetrag = RestBetrag - 50;
                        anzahlFuffziger = anzahlFuffziger - 1;
                    }
                    this.txt50er.Text = anzahlFuffziger.ToString();

                    //Zwanzger ausgeben
                    while ((RestBetrag >= 20) && (anzahlZwanziger > 0))
                    {
                        this.lstGeldscheine.Items.Add("20");
                        RestBetrag = RestBetrag - 20;
                        anzahlZwanziger = anzahlZwanziger - 1;
                    }
                    this.txt20er.Text = anzahlZwanziger.ToString();

                    //Zehner ausgeben
                    while ((RestBetrag >= 10) && (anzahlZehner > 0))
                    {
                        this.lstGeldscheine.Items.Add("10");
                        RestBetrag = RestBetrag - 10;
                        anzahlZehner = anzahlZehner - 1;
                    }
                    this.txt10er.Text = anzahlZehner.ToString();

                    //Fünferer ausgeben
                    while ((RestBetrag >= 5) && (anzahlFuenfer > 0))
                    {
                        this.lstGeldscheine.Items.Add("5");
                        RestBetrag = RestBetrag - 5;
                        anzahlFuenfer = anzahlFuenfer - 1;
                    }
                    this.txt5er.Text = anzahlFuenfer.ToString();

                    this.lblRestbetrag.Text = RestBetrag.ToString();

                if (RestBetrag< 5 && RestBetrag >0) 
                {
                    MessageBox.Show("WIR HABEN KEINE MÜNZEN");
                }
            }
            
        }
    }
}
