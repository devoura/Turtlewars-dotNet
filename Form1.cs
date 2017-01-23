using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(System.Environment.CurrentDirectory + "/highscores.txt")) //om filen highscore.txt finnes i current directory
            {
                //filen legges i bin/debug/
                int counter = 0; //brukes til å telle antall linjer i highscores.txt
                string line; //linjen som leses av
                string[] allScores = new string[1000]; //numerativt stringarray hvor line plasseres på index counter

                // les filen 
                System.IO.StreamReader file =
                    new System.IO.StreamReader(System.Environment.CurrentDirectory + "/highscores.txt");
                while ((line = file.ReadLine()) != null) //så lenge det er noe å lese fra hver enkelt linje i filen..
                {
                    if (line != null && !line.Equals("")) //hvis linjen ikke er tom og ikke er tom . 
                    {
                        allScores[counter] = line; //stringArray allScores legger til line på index counter
                        counter++; //tallet går opp, slik at neste linje kan legges på neste index i allScores
                    }

                }

                file.Close(); //lukk filen

                String[] score = allScores[0].Split('|'); //Deler første score til navn og score
                int high = Convert.ToInt32(score[1]); //lagrer score verdien, gjør fra string til int
                int highlocation = 0; //index til highscore
                int secondhigh = 0; //neste høyeste score
                int secondhighlocation = 0; //index til nest høyeste score

                for (int i = 0; i < counter; i++) //for hver linje, se om score er høyere enn registrerte høyeste
                {
                    String[] innerscore = allScores[i].Split('|'); //splitter linjen
                    if (Convert.ToInt32(innerscore[1]) > high) //sjekker om scoren på linjen er høyere enn registrerte highscore
                    {
                        high = Convert.ToInt32(innerscore[1]); //registrerer ny highscore
                        highlocation = i; //lagrer indexen til scoren
                    }
                }

                if (counter > 1) //hvis mer enn ett element, finner vi også nest høyeste
                {
                    for (int i = 0; i < counter; i++) //
                    {
                        String[] innerscore = allScores[i].Split('|');
                        if (Convert.ToInt32(innerscore[1]) > secondhigh && i != highlocation) //hvis score er høyere enn registrerte 2ndhigh og ikke samme linje som highscore
                        {
                            secondhigh = Convert.ToInt32(innerscore[1]);
                            secondhighlocation = i;
                        }
                    }
                }

                string[] firstplace = allScores[highlocation].Split('|'); //lager ny tabell, splitter highscore og highscore navn
                labelfirst.Text = "1. " + firstplace[0] + " : " + firstplace[1];
                if (counter > 1)
                {
                    string[] secondplace = allScores[secondhighlocation].Split('|'); //lager andreplass tabell
                    labelsecond.Text = "2. " + secondplace[0] + " : " + secondplace[1];
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && textBox1.Text != "")
            {
                Form2 form2 = new Form2(textBox1.Text);
                form2.Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
