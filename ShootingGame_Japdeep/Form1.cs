using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingGame_Japdeep
{
    public partial class Form1 : Form
    {
        ShootSetting obj = new ShootSetting();
        Random bulletno = new Random();
        int sound = 0, bullet = 0;
        int shootClk = 0;
        public Form1()
        {
            InitializeComponent();

            //pbgun.Image = Properties.Resources.bullet;
            MessageBox.Show("Welcome to the shooting game \n You have only two chance to save yourself");

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            pb_Gun.Image = Properties.Resources.load;
            spinBtn.Enabled = true;
            loadBtn.Enabled = false;
        }

        private void spinBtn_Click(object sender, EventArgs e)
        {
            sound = obj.fire();
            pb_Gun.Image = Properties.Resources.spin;
            shootBtn.Enabled = true;
            shootAwayBtn.Enabled = true;

            spinBtn.Enabled = false;
        }

        private void shootBtn_Click(object sender, EventArgs e)
        {
            // this code is uused when we click on the shoot away button to fire 

            pb_Gun.Image = Properties.Resources.gun;

            shootClk++;
            //if the clik and sound generation value is equal then the message will print and create the sound of fire other wise the empty sound will sound
            if (shootClk == sound)
            {
                //pbgun.Visible = true;

                // enable the timer to work
                timer1.Start();
                // generate the sound of the  fire trigger 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fire);
                player.Play();
                findWinner();


            }
            else
            {
                // generate the sound of the  empty trigger 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Empty);
                player.Play();
                MessageBox.Show("Retry to Shoot ");

            }
            if (shootClk == 4 && shootClk != sound)
            {
                MessageBox.Show("congrats! your player is survive ");
                shootBtn.Enabled = false;
                tryAgainBtn.Enabled = true;
            }
        }
        //tooe code to find the winner of the game if the player win the game other wise it will generate an error 
        public void findWinner()
        {
            shootAwayBtn.Enabled = false;
            shootBtn.Enabled = false;
            tryAgainBtn.Visible = true;

            MessageBox.Show("Player is dead ! Click on retry to play again");
            //pbgun.Visible = false;
            //pbgun.Left = 120;
        }
        // when this is last chance then the game over messsage will display and reset the game will print 


        private void shootAwayBtn_Click(object sender, EventArgs e)
        {
            bullet++;
            if (bullet == sound)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fire);
                player.Play();
                MessageBox.Show("Thank God ! Player is alive ");
                shootAwayBtn.Enabled = false;
                tryAgainBtn.Visible = true;
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Empty);
                player.Play();
            }

            if (bullet == 2)
            {

                MessageBox.Show("Ending up!!");
                shootAwayBtn.Enabled = false;
                tryAgainBtn.Visible = true;
                bullet = 0;
            }
        }

        private void tryAgainBtn_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
