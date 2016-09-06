using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abitrio
{
    public partial class Game : Form
    {

        //TIME//
        int seconds;
        int minute;
        ///////

        //MOVEMENT//
        bool right;
        bool left;
        bool up;
        bool down;

        bool rightBoost;
        bool leftBoost;
        bool upBoost;
        bool downBoost;
        ///////////

        //PLANETS//
        int amount;
        ///////////

        int rdm1x;
        int rdm2x;
        int rdm3x;
        int rdm4x;
        int rdm5x;
        int rdm6x;
        int rdm7x;
        int rdm8x;
        int rdm9x;
        int rdm10x;

        int rdm1y;
        int rdm2y;
        int rdm3y;
        int rdm4y;
        int rdm5y;
        int rdm6y;
        int rdm7y;
        int rdm8y;
        int rdm9y;
        int rdm10y;

     

        public Game()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            planet1.Visible = false;
            planet2.Visible = false;
            planet3.Visible = false;
            planet4.Visible = false;
            planet5.Visible = false;
            planet6.Visible = false;
            planet7.Visible = false;
            planet8.Visible = false;
            planet9.Visible = false;
            planet10.Visible = false;

            gnrCoord();
            amountplanets();
        }

        private void amountplanets()
        {
            Random rndp = new Random();
            amount = rndp.Next(0, 10);


            if (amount == 1)
            {
                planet1.Visible = true;
                planet2.Visible = false;
                planet3.Visible = false;
                planet4.Visible = false;
                planet5.Visible = false;
                planet6.Visible = false;
                planet7.Visible = false;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;
            }
            else if (amount == 2)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = false;
                planet4.Visible = false;
                planet5.Visible = false;
                planet6.Visible = false;
                planet7.Visible = false;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;
            }

            if (amount == 3)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = false;
                planet5.Visible = false;
                planet6.Visible = false;
                planet7.Visible = false;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;
            }

            if (amount == 4)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = false;
                planet6.Visible = false;
                planet7.Visible = false;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;

            }

            if (amount == 5)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = true;
                planet6.Visible = false;
                planet7.Visible = false;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;

            }

            if (amount == 6)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = true;
                planet6.Visible = true;
                planet7.Visible = false;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;


            }

            if (amount == 7)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = true;
                planet6.Visible = true;
                planet7.Visible = true;
                planet8.Visible = false;
                planet9.Visible = false;
                planet10.Visible = false;
            }

            if (amount == 8)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = true;
                planet6.Visible = true;
                planet7.Visible = true;
                planet8.Visible = true;
                planet9.Visible = false;
                planet10.Visible = false;

            }

            if (amount == 9)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = true;
                planet6.Visible = true;
                planet7.Visible = true;
                planet8.Visible = true;
                planet9.Visible = true;
                planet10.Visible = false;

            }

            if (amount == 10)
            {
                planet1.Visible = true;
                planet2.Visible = true;
                planet3.Visible = true;
                planet4.Visible = true;
                planet5.Visible = true;
                planet6.Visible = true;
                planet7.Visible = true;
                planet8.Visible = true;
                planet9.Visible = true;
                planet10.Visible = true;

            }

        }

        private void gnrCoord()
        {
            Random rnd = new Random();


            rdm1x = rnd.Next(0, 640);
            rdm2x = rnd.Next(0, 640);
            rdm3x = rnd.Next(0, 640);
            rdm4x = rnd.Next(0, 640);
            rdm5x = rnd.Next(0, 640);
            rdm6x = rnd.Next(0, 640);
            rdm7x = rnd.Next(0, 640);
            rdm8x = rnd.Next(0, 640);
            rdm9x = rnd.Next(0, 640);
            rdm10x = rnd.Next(0, 640);

            rdm1y = rnd.Next(0, 380);
            rdm2y = rnd.Next(0, 380);
            rdm3y = rnd.Next(0, 380);
            rdm4y = rnd.Next(0, 380);
            rdm5y = rnd.Next(0, 380);
            rdm6y = rnd.Next(0, 380);
            rdm7y = rnd.Next(0, 380);
            rdm8y = rnd.Next(0, 380);
            rdm9y = rnd.Next(0, 380);
            rdm10y = rnd.Next(0, 380);

          

            planet1.Left = rdm1x + planet10.Width / 2;
            planet1.Top = rdm1y;

            planet2.Left = rdm2x + planet10.Width / 2;
            planet2.Top = rdm2y;

            planet3.Left = rdm3x + planet10.Width / 2;
            planet3.Top = rdm3y;

            planet4.Left = rdm4x + planet10.Width / 2;
            planet4.Top = rdm4y;

            planet5.Left = rdm5x + planet10.Width / 2;
            planet5.Top = rdm5y;

            planet6.Left = rdm6x + planet10.Width / 2;
            planet6.Top = rdm6y;

            planet7.Left = rdm7x + planet10.Width / 2;
            planet7.Top = rdm7y;

            planet8.Left = rdm8x + planet10.Width / 2;
            planet8.Top = rdm8y;

            planet9.Left = rdm9x + planet10.Width / 2;
            planet9.Top = rdm9y;

            planet10.Left = rdm10x + planet10.Width / 2;
            planet10.Top = rdm10y;


            rdmobj1.Text = planet1.Left.ToString() + "," + planet1.Top.ToString();
            rdmobj2.Text = planet2.Left.ToString() + "," + planet2.Top.ToString();
            rdmobj3.Text = planet3.Left.ToString() + "," + planet3.Top.ToString();
            rdmobj4.Text = planet4.Left.ToString() + "," + planet4.Top.ToString();
            rdmobj5.Text = planet5.Left.ToString() + "," + planet5.Top.ToString();
            rdmobj6.Text = planet6.Left.ToString() + "," + planet6.Top.ToString();
            rdmobj7.Text = planet7.Left.ToString() + "," + planet7.Top.ToString();
            rdmobj8.Text = planet8.Left.ToString() + "," + planet8.Top.ToString();
            rdmobj9.Text = planet9.Left.ToString() + "," + planet9.Top.ToString();
            rdmobj10.Text = planet10.Left.ToString() + "," + planet10.Top.ToString();


        }

        private void overlapsefix()
        {
            if (planet1.Left + 30 <= planet2.Left && planet1.Top + 30 <= planet2.Top)
            {
                planet1.Left += 40;
            }
        }

        private void movement_Tick(object sender, EventArgs e)
        {

            shipX.Text = Convert.ToString(ship.Left);
            shipY.Text = Convert.ToString(ship.Top);

            if (right == true)
            {
                ship.Left += 1;
            }

            if (left == true)
            {
                ship.Left -= 1;
            }

            if (up == true)
            {
                ship.Top -= 1;
            }

            if (down == true)
            {
                ship.Top += 1;
            }

            /////////////////////////
            //////////BOOST//////////
            /////////////////////////

            if (rightBoost == true)
            {
                ship.Left += 5;
            }

            if (leftBoost == true)
            {
                ship.Left -= 5;
            }

            if (upBoost == true)
            {
                ship.Top -= 5;
            }

            if (downBoost == true)
            {
                ship.Top += 5;
            }

            detectlocation();


        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //////////////////////BOOST//////////////////////////

            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control || e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                rightBoost = true;
            }

            if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Control || e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {

                leftBoost = true;
            }

            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control || e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                upBoost = true;
            }

            if (e.KeyCode == Keys.Down && e.Modifiers == Keys.Control || e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                downBoost = true;
            }

            ////////////////////////////////////////////////////////


            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = true;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = true;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Back)
            {

                gnrCoord();
                amountplanets();
                lblAmount.Text = Convert.ToString(amount);

                overlapsefix();
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control || e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                rightBoost = false;
            }

            if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Control || e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {

                leftBoost = false;
            }

            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control || e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                upBoost = false;
            }

            if (e.KeyCode == Keys.Down && e.Modifiers == Keys.Control || e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                downBoost = false;
            }



            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = false;
            }
        }

        private void stopMovement()
        {
            down = false;
            up = false;
            left = false;
            right = false;

        }

        private void detectlocation()
        {
            rdmobj1.Text = Convert.ToString(planet1.Left + planet1.Width / 2) + "," + Convert.ToString(planet1.Top + planet1.Height/2) ;

            if (ship.Left == planet1.Left + planet1.Width/2 && ship.Top == planet1.Top + planet1.Height/2  )
            {
                lblInfo.Text = "obj 1" + "\n" + "x=" + Convert.ToString(planet1.Left) + "\n" + "y=" + Convert.ToString(planet1.Top);
             
            }
         

            if (ship.Left == planet2.Left && ship.Top == planet2.Top )
            {
                lblInfo.Text = "obj 2" + "\n" + "x=" + Convert.ToString(planet2.Left) + "\n" + "y=" + Convert.ToString(planet2.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }


            if (ship.Left == planet3.Left + planet3.Width / 2 && ship.Top == planet3.Top + planet3.Height / 2)
            {
                lblInfo.Text = "obj 3" + "\n" + "x=" + Convert.ToString(planet3.Left) + "\n" + "y=" + Convert.ToString(planet3.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }


            if (ship.Left == planet4.Left + planet4.Width / 2 && ship.Top == planet4.Top + planet4.Height / 2)
            {
                lblInfo.Text = "obj 4" + "\n" + "x=" + Convert.ToString(planet4.Left) + "\n" + "y=" + Convert.ToString(planet4.Top);

            }
            else
            {
                lblInfo.Text = "...";
            }

            if (ship.Left == planet5.Left + planet5.Width / 2 && ship.Top == planet5.Top + planet5.Height / 2)
            {
                lblInfo.Text = "obj 5" + "\n" + "x=" + Convert.ToString(planet5.Left) + "\n" + "y=" + Convert.ToString(planet5.Top);

            }
            else
            {
                lblInfo.Text = "...";
            }

            if (ship.Left == planet6.Left + planet6.Width / 2 && ship.Top == planet6.Top + planet6.Height / 2)
            {
                lblInfo.Text = "obj 6" + "\n" + "x=" + Convert.ToString(planet6.Left) + "\n" + "y=" + Convert.ToString(planet6.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }

            if (ship.Left == planet7.Left + planet7.Width / 2 && ship.Top == planet7.Top + planet7.Height / 2)
            {
                lblInfo.Text = "obj 7" + "\n" + "x=" + Convert.ToString(planet7.Left) + "\n" + "y=" + Convert.ToString(planet7.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }

            if (ship.Left == planet8.Left + planet8.Width / 2 && ship.Top == planet8.Top + planet8.Height / 2)
            {
                lblInfo.Text = "obj 8" + "\n" + "x=" + Convert.ToString(planet8.Left) + "\n" + "y=" + Convert.ToString(planet8.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }

            if (ship.Left == planet9.Left + planet9.Width / 2 && ship.Top == planet9.Top + planet9.Height / 2)
            {
                lblInfo.Text = "obj 9" + "\n" + "x=" + Convert.ToString(planet9.Left) + "\n" + "y=" + Convert.ToString(planet9.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }

            if (ship.Left == planet10.Left + planet10.Width / 2 && ship.Top == planet10.Top + planet10.Height / 2)
            {
                lblInfo.Text = "obj 10" + "\n" + "x=" + Convert.ToString(planet10.Left) + "\n" + "y=" + Convert.ToString(planet10.Top);
            }
            else
            {
                lblInfo.Text = "...";
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minute++;
            }

            lblTime.Text = "S:" + Convert.ToString(seconds) + "\n" + "M:" + Convert.ToString(minute);
        }
    }
}
