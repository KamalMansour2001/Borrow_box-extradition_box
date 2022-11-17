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

namespace Lånabox
{
    public partial class Form1 : Form
    {
        List<Låda> Lådlista = new List<Låda>();
        List<Elev> Elevlista = new List<Elev>();
        public Form1()
        {
            InitializeComponent();
            läsinLådor();
            läsainelever();
        }
        private void läsinLådor()
        {
            string[] allarader = File.ReadAllLines(@"C:\Users\kamal\source\repos\loggain\Lådor.txt");

            foreach (string raden in allarader)
            {
                string[] rad = raden.Split(',');
                Lådlista.Add(new Låda(int.Parse(rad[0]), Convert.ToBoolean(rad[1]), Convert.ToDateTime(rad[2])));
            }
        }

        private void läsainelever()
        {
            string[] allarader = File.ReadAllLines(@"C:\Users\kamal\source\repos\loggain\elever.txt");

            foreach (string raden in allarader)
            {
                string[] rad = raden.Split(',');
                Elevlista.Add(new Elev(rad[0], rad[1], rad[2], rad[3], Convert.ToBoolean(rad[4]), int.Parse(rad[5])));
            }
        }

        private void återställprogram()
        {
            txtAnvänderNamn.Clear();
            txtLössenord.Clear();
            txtAnvänderNamn.Focus();
        }

        private void skrivlådlista()
        {
            // med hjälp av streamwriter ska skriva ner filen från listan till txt filen.
            StreamWriter filskrivaren = new StreamWriter(@"C:\Users\kamal\source\repos\loggain\Lådor.txt", false);
            foreach (Låda lådan in Lådlista)
            {
               filskrivaren.WriteLine(lådan.Nummer + "," + lådan.Ledig + "," + lådan.LåneDatum);
            }
            filskrivaren.Close();
            
        }

        private void skrivelevlista()
        {
            // med hjälp av streamwriter ska skriva ner filen från listan till txt filen.
            StreamWriter filskrivaren = new StreamWriter(@"C:\Users\kamal\source\repos\loggain\elever.txt", false);
            foreach (Elev eleven in Elevlista)
            {
                filskrivaren.WriteLine(eleven.Namn + "," + eleven.Klass + "," + eleven.Användernamn + "," + eleven.Lössenord + "," 
                    + eleven.LånatLåda + "," + eleven.Lådnummer);
            }
            filskrivaren.Close();
        }
        private void bttnJagvillLåna_Click(object sender, EventArgs e)
        {
            string anv = txtAnvänderNamn.Text;
            string lössen = txtLössenord.Text;

            foreach (Elev eleven in Elevlista)
            {
                if (eleven.Användernamn == anv)
                {
                    if (eleven.Lössenord == lössen)
                    {
                        foreach(Låda lådan in Lådlista)
                        {
                            if (lådan.Ledig)
                            {
                                //första ledig lådan. Måste byta dens egenskap till false. sätta datetime på egenskapen av lådan.
                                //lås upp lådan i fem sec.
                                
                                lådan.Ledig = false;
                                lådan.LåneDatum = DateTime.Now;
                                eleven.LånatLåda = true;
                                eleven.Lådnummer = lådan.Nummer;
                                MessageBox.Show("Har öppnat lådan nummer " + lådan.Nummer);
                                skrivelevlista();
                                skrivlådlista();

                            }
                            else
                            {
                                MessageBox.Show("Inga lediga hörlurar tyvärr, återkom senare tack!");
                                återställprogram();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fel Lössen Ord försök igen!!");
                    }
                }
                else
                {
                    MessageBox.Show("Användaren finns ej!, Kontrollera ditt användernamn.");
                    återställprogram();
                }
            }

        }
        private void btnLämnaTbks_Click(object sender, EventArgs e)
        {
            string anv = txtAnvänderNamn.Text;
            string lössen = txtLössenord.Text;

            foreach (Elev eleven in Elevlista)
            {
                if (eleven.Användernamn == anv)
                {
                    if (eleven.Lössenord == lössen)
                    {
                        if (eleven.LånatLåda)
                        {
                                //första ledig lådan. Måste byta dens egenskap till false. sätta datetime på egenskapen av lådan.
                                //lås upp lådan i fem sec.
                            foreach(Låda lådan in Lådlista)
                            {
                                if (eleven.Lådnummer == lådan.Nummer)
                                {
                                    //Öppna lådan nu. Återställ elevens egenskaper och gör lådan tom igen.

                                    lådan.Ledig = true;
                                    lådan.LåneDatum = DateTime.Now;
                                    eleven.LånatLåda = false;
                                    eleven.Lådnummer = 0;
                                    MessageBox.Show("Lådan är öppen lägg tillbaka hörlurarna");
                                    skrivelevlista();
                                    skrivlådlista();
                                }
                                

                            }
                            
                        }
                        else
                        {
                                MessageBox.Show("Du har inte lånat något annars kontakta personal.");
                                återställprogram();
                        }
                     
                    }
                    else
                    {
                        MessageBox.Show("Fel Lössen Ord försök igen!!");
                    }
                }
                else
                {
                    MessageBox.Show("Användaren finns ej!, Kontrollera ditt användernamn.");
                    återställprogram();
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter LådorSkapare = new StreamWriter(@"C:\Users\kamal\source\repos\loggain\Lådor.txt");

            LådorSkapare.WriteLine("1,false," + DateTime.Now);
            LådorSkapare.WriteLine("2,false," + DateTime.Now);
            LådorSkapare.WriteLine("3,false," + DateTime.Now);
            LådorSkapare.WriteLine("4,false," + DateTime.Now);
            LådorSkapare.WriteLine("5,false," + DateTime.Now);
            LådorSkapare.WriteLine("6,false," + DateTime.Now);
            LådorSkapare.WriteLine("7,false," + DateTime.Now);
            LådorSkapare.WriteLine("8,false," + DateTime.Now);
            LådorSkapare.Close();
        }


    }
}
