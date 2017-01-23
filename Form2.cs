using System;
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
    public partial class Form2 : Form
    {

        //bruker 5 pictureBox: spiller, prosjektil, fiende1, fiende2, fiende3
        int score = 0;
        int liv = 6;
        int timeLeft = 600; //30 sekunder. Teller dobbelt så fort. Deler på 20 og viser det i UI, da dette telte smoothere ned enn timeLeft = 30 og timeLeftLabel = timeLeft.ToString();
        string name = "";
        Random rand = new Random();

        public Form2(String name)
        {

            InitializeComponent();

            
            this.name = name; //brukerens navn fra form1.TextBox1
            this.MinimumSize = new Size(300, 375);
            this.MaximumSize = new Size(300, 375);


        }


        private void Form2_Load(object sender, EventArgs e)
        {

            // tilfeldige int mellom. brukes til å sette tilfeldige Y-posisjoner for fiender. Sørger for at de ikke kolliderer.
            int fiende1Y = rand.Next(50, 101); // tilfeldig tall mellom første og (siste - 1)
            int fiende2Y = rand.Next(120, 171);
            int fiende3Y = rand.Next(180, 231);
            //setter fiendenes startposisjon
            fiende1.Location = new Point(1, fiende1Y);
            fiende2.Location = new Point(299, fiende2Y);
            fiende3.Location = new Point(1, fiende3Y);

            prosjektil.Visible = false; //prosjektil starter usynlig

            timer1.Enabled = true; //styrer fiende og spiller

            timer2.Enabled = true; //styrer prosjektil

            timer3.Enabled = true; //kjører sjekk per tick om du skal få poeng og sørger for at fiendene går rundt og rundt

            timer4.Enabled = true; //teller ned til spillets slutt/sjekker om du har flere liv. 


            // sett intervall for timer. Lavere = raskere
            timer1.Interval = 100;
            timer2.Interval = 50;
            timer3.Interval = 50;
            //  timer4.Interval = 1000;

            
            // koble eventhandler til timer sin tick
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            timer3.Tick += timer3_Tick;
            timer4.Tick += timer4_Tick;


            timer1.Start();
            // timer2.Start(); //prosjektilets timer. starter når spacebar trykkes
            timer3.Start();
            timer4.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //flytter fiender
        {

            fiende1.Left += 5; //beveg +5 pixler venstre per timerX_tick. Left += legger til til x-koordinat fra venstre, så objektet beveger seg mot høyre
            fiende2.Left -= 7; //omvendt av linjen over
            fiende3.Left += 8;
            sjekkOmTruffet();
            sendInfoTilLabel(score, liv); //oppdater score og liv


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            prosjektil.Top -= 7;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sjekkOmIkkeTruffet();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            String timeInSeconds = (timeLeft / 20).ToString();
            timerLabel.Text = timeInSeconds;
            timeLeft--;

            if (timeLeft == 0)
            {
                finish();

            }
            else if (liv == 0)
            {
                finish();
            }

        }

        private void sjekkOmTruffet()
        {

            if (fiende1.Bounds.IntersectsWith(prosjektil.Bounds)) //hvis prosjektils grense treffer fiende1
            {

                Console.WriteLine("Kræsjet med fiende 1");
                prosjektil.Visible = false; //skjul prosjektilet
                spiller.Visible = true; //vis spilleren igjen, nytt liv
                prosjektil.Location = new Point(spiller.Location.X, spiller.Location.Y); //sett posisjonen til prosjektil til der spilleren er, så det ikke fortsetter å kollidere
                liv--; //du mister et liv
                timer2.Stop(); //sørg for at prosjektilet ikke beveger seg

            }

            if (fiende2.Bounds.IntersectsWith(prosjektil.Bounds)) //gjenta for fiende2
            {

                prosjektil.Location = new Point(spiller.Location.X, spiller.Location.Y);
                Console.WriteLine("Kræsjet med fiende 2");
                prosjektil.Visible = false;
                spiller.Visible = true;
                liv--;
                timer2.Stop();

            }

            if (fiende3.Bounds.IntersectsWith(prosjektil.Bounds)) //gjenta for fiende3
            {
                //denne slår inn ved spillets start. hvorfor?
                prosjektil.Location = new Point(spiller.Location.X, spiller.Location.Y);
                prosjektil.Visible = false;
                spiller.Visible = true;
                Console.WriteLine("Kræsjet med fiende 3");
                liv--;
                timer2.Stop();

            }

        }

        public void sjekkOmIkkeTruffet()
        {

            if (prosjektil.Location.Y < 0) //om prosjektilet ikke treffer noe
            {
                score++;
                prosjektil.Location = new Point(spiller.Location.X, spiller.Location.Y); //sett prosjektil tilbake til spiller
                prosjektil.Visible = false;
                spiller.Visible = true;
                timer2.Stop();
                Console.WriteLine("Du fikk en skilpadde over elven!");
                

            }

            if (fiende1.Location.X > 300) //om fiende1 beveger seg ut 
            {
                int fiende1Y = rand.Next(50, 101);
                fiende1.Location = new Point(-100, fiende1Y);
            }

            if (fiende2.Location.X < -99) //om fiende2 beveger seg ut
            {
                int fiende2Y = rand.Next(120, 171);
                fiende2.Location = new Point(299, fiende2Y);

            }

            if (fiende3.Location.X > 300) //om fiende3 beveger seg ut
            {
                int fiende3Y = rand.Next(180, 231);
                fiende3.Location = new Point(-50, fiende3Y);
            }

            if (spiller.Location.X < -50) //om spiller går ut til venstre
            {
                spiller.Location = new Point(299, 290); //start litt utenfor bildet så spiller glir inn igjen

            }
            else if (spiller.Location.X > 350) //eller høyre
            {
                spiller.Location = new Point(-20, 290); //start litt utenfor bildet så spiller glir inn igjen
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) { spiller.Left -= 10; }
            if (e.KeyCode == Keys.Right) { spiller.Left += 10; }

            //spacebar
            if (e.KeyValue == 32)
            {
                if (liv > 0)
                {
                    prosjektil.Location = new Point(spiller.Location.X, spiller.Location.Y);
                    prosjektil.Visible = true;
                    spiller.Visible = false;
                    timer2.Start();
                 
                    
                }
            }

        }

        private void sendInfoTilLabel(int score, int liv)
        {
            scoreLabel.Text = "Poeng: " + score.ToString();
            livesRemainingLabel.Text = "Liv: " + liv.ToString();
        }

        private void finish()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;

            scoreLabel.Text = "GAME";
            timerLabel.Text = ":-(";
            livesRemainingLabel.Text = "OVER";

            String text = name + "|" + score + "\n";
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(System.Environment.CurrentDirectory + "/highscores.txt", true))
            {
                file.WriteLine(text);
            }

            this.Close();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            string message = "Du fikk: " + score + " poeng, med " + liv + " liv og " + (timeLeft/20) + " sekunder igjen.\n Du klarer bedre enn det! Vil du prøve på nytt?";
            string caption = "Nytt Spill";

            var prompt = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (prompt == DialogResult.Yes) //hvis bruker svarer ja..
            {
                Form2 form2 = new Form2(name); //lag nytt spill
                form2.Show(); //vis det
            }
            else //hvis nei
            {
                Application.Exit();
              
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //"låser" spillet om brukeren trykker X. Nytt spill-dialog dukker opp
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }
    }
}
