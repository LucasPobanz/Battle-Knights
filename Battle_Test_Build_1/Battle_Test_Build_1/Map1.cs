using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Test_Build_1
{
    public partial class Map1 : Form
    {
        bool right;
        bool rightCpu;
        bool leftCpu;
        bool left;
        bool jumpCpu;
        bool jump;
        int g = 25;
        int force;
        int forceCpu;

        public Map1()
        {
            InitializeComponent();
        }

        private void Map1_Load(object sender, EventArgs e)
        {
            
        }
        private void movementTime_Tick(object sender, EventArgs e)
        {
            // code for main platform
            if (player1.Right > mainPlatform.Left && player1.Left < mainPlatform.Right - player1.Width / 2 && player1.Bottom > mainPlatform.Top)
            {
                right = false;
            } 
            if (player1.Left < mainPlatform.Right && player1.Right > mainPlatform.Left + player1.Width / 2 && player1.Bottom > mainPlatform.Top)
            {
                left = false;

            }
            // code for platform 1 right platform
            if (player1.Right > platform1.Left && player1.Left < platform1.Right - player1.Width && player1.Bottom < platform1.Bottom && player1.Bottom > platform1.Top)
            {
                right = false;
            }
            if (player1.Left < platform1.Right && player1.Right > platform1.Left + player1.Width && player1.Bottom < platform1.Bottom && player1.Bottom > platform1.Top)
            {
                left = false;

            }

            // code for platform 2 left platform
            if (player1.Right > platform2.Left && player1.Left < platform2.Right - player1.Width && player1.Bottom < platform2.Bottom && player1.Bottom > platform2.Top)
            {
                right = false;
            }
            if (player1.Left < platform2.Right && player1.Right > platform2.Left + player1.Width && player1.Bottom < platform2.Bottom && player1.Bottom > platform2.Top)
            {
                left = false;
            }

            // player1 movement due to platform
            if (right == true)
            {
                player1.Left += 5;
            }
            if (left == true)
            {
                player1.Left -= 5;
            }
            if (jump == true)
            {
                player1.Top -= force;
                force -= 1;
            } 
            if (player1.Top + player1.Height >= panel1.Height)
            {
                player1.Top = panel1.Height - player1.Height;
                jump = false;
            } else
            {
                player1.Top += 5;
            }

            // top of main platform collision
            if (player1.Left + player1.Width -1 > mainPlatform.Left && player1.Left + player1.Width + 5 < mainPlatform.Left + mainPlatform.Width + player1.Width && player1.Top +player1.Height >= mainPlatform.Top && player1.Top < mainPlatform.Top)
            {
                player1.Top = panel1.Height - mainPlatform.Height - player1.Height;
                force = 0;
                jump = false;
            }

            // top and bottom of platform 1 collision 
            if (player1.Left + player1.Width  > platform1.Left && player1.Left + player1.Width  < platform1.Left + platform1.Width + player1.Width && player1.Top + player1.Height >= platform1.Top && player1.Top < platform1.Top)
            {
                jump = false;
                force = 0;
                player1.Top = platform1.Location.Y - player1.Height;
            }
            if (player1.Left + player1.Width > platform1.Left && player1.Left + player1.Width < platform1.Left + platform1.Width + player1.Width && player1.Top - platform1.Bottom <= 10 && player1.Top - platform1.Top > -10)
            {
                force = -1;
            }

            //top and bottom of platform 2 collision
            if (player1.Left + player1.Width > platform2.Left && player1.Left + player1.Width < platform2.Left + platform2.Width + player1.Width && player1.Top + player1.Height >= platform2.Top && player1.Top < platform2.Top)
            {
                jump = false;
                force = 0;
                player1.Top = platform2.Location.Y - player1.Height;
            }
            if (player1.Left + player1.Width > platform2.Left && player1.Left + player1.Width < platform2.Left + platform2.Width + player1.Width && player1.Top - platform2.Bottom <= 10 && player1.Top - platform2.Top > -10)
            {
                force = -1;
            }

            // code for cpu 




            // code for main platform
            if (cpu1.Right > mainPlatform.Left && cpu1.Left < mainPlatform.Right - cpu1.Width / 2 && cpu1.Bottom > mainPlatform.Top)
            {
                rightCpu = false;
            }
            if (cpu1.Left < mainPlatform.Right && cpu1.Right > mainPlatform.Left + cpu1.Width / 2 && cpu1.Bottom > mainPlatform.Top)
            {
                leftCpu = false;

            }
            // code for platform 1 right platform
            if (cpu1.Right > platform1.Left && cpu1.Left < platform1.Right - cpu1.Width && cpu1.Bottom < platform1.Bottom && cpu1.Bottom > platform1.Top)
            {
                rightCpu = false;
            }
            if (cpu1.Left < platform1.Right && cpu1.Right > platform1.Left + cpu1.Width && cpu1.Bottom < platform1.Bottom && cpu1.Bottom > platform1.Top)
            {
                leftCpu = false;

            }

            // code for platform 2 left platform
            if (cpu1.Right > platform2.Left && cpu1.Left < platform2.Right - cpu1.Width && cpu1.Bottom < platform2.Bottom && cpu1.Bottom > platform2.Top)
            {
                rightCpu = false;
            }
            if (cpu1.Left < platform2.Right && cpu1.Right > platform2.Left + cpu1.Width && cpu1.Bottom < platform2.Bottom && cpu1.Bottom > platform2.Top)
            {
                leftCpu = false;
            }

            // player1 movement due to platform
            if (rightCpu == true)
            {
                cpu1.Left += 5;
            }
            if (leftCpu == true)
            {
                cpu1.Left -= 5;
            }
            if (jumpCpu == true)
            {
                cpu1.Top -= forceCpu;
                forceCpu -= 1;
            }
            if (cpu1.Top + cpu1.Height >= panel1.Height)
            {
                cpu1.Top = panel1.Height - cpu1.Height;
                jumpCpu = false;
            }
            else
            {
                cpu1.Top += 5;
            }

            // top of main platform collision
            if (cpu1.Left + cpu1.Width - 1 > mainPlatform.Left && cpu1.Left + cpu1.Width + 5 < mainPlatform.Left + mainPlatform.Width + cpu1.Width && cpu1.Top + cpu1.Height >= mainPlatform.Top && cpu1.Top < mainPlatform.Top)
            {
                cpu1.Top = panel1.Height - mainPlatform.Height - cpu1.Height;
                forceCpu = 0;
                jumpCpu = false;
            }

            // top and bottom of platform 1 collision 
            if (cpu1.Left + cpu1.Width > platform1.Left && cpu1.Left + cpu1.Width < platform1.Left + platform1.Width + cpu1.Width && cpu1.Top + cpu1.Height >= platform1.Top && cpu1.Top < platform1.Top)
            {
                jumpCpu = false;
                forceCpu = 0;
                cpu1.Top = platform1.Location.Y - cpu1.Height;
            }
            if (cpu1.Left + cpu1.Width > platform1.Left && cpu1.Left + cpu1.Width < platform1.Left + platform1.Width + cpu1.Width && cpu1.Top - platform1.Bottom <= 10 && cpu1.Top - platform1.Top > -10)
            {
                forceCpu = -1;
            }

            //top and bottom of platform 2 collision
            if (cpu1.Left + cpu1.Width > platform2.Left && cpu1.Left + cpu1.Width < platform2.Left + platform2.Width + cpu1.Width && cpu1.Top + cpu1.Height >= platform2.Top && cpu1.Top < platform2.Top)
            {
                jumpCpu = false;
                forceCpu = 0;
                cpu1.Top = platform2.Location.Y - cpu1.Height;
            }
            if (cpu1.Left + cpu1.Width > platform2.Left && cpu1.Left + cpu1.Width < platform2.Left + platform2.Width + cpu1.Width && cpu1.Top - platform2.Bottom <= 10 && cpu1.Top - platform2.Top > -10)
            {
                forceCpu = -1;
            }

            // AI for the CPU
            
            
                if (cpu1.Right < player1.Right && cpu1.Right + 10 < player1.Right)
                {
                  //  Task.Delay(10000).Wait();
                    rightCpu = true;
                    leftCpu = false;
                }

                if (cpu1.Left > player1.Left && cpu1.Left - 10 > player1.Left)
                {
                //Task.Delay(10000).Wait();
                    leftCpu = true;
                    rightCpu = false;
                }

                if (jumpCpu != true)
                {
                    if (cpu1.Bottom > mainPlatform.Top || player1.Bottom < cpu1.Top)
                    {

                        jumpCpu = true;
                        forceCpu = g;
                    }
                }

            
        


    }


    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Map1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jump = true;
                    force = g;
                }
            }
        }

        private void Map1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }
    }
}
