using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace santa
{
    public partial class Form1 : Form
    {
        int treeSpeed = 8;
        int gravity = 15;
        int score = 0;
        
        
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            treebottom.Left -= treeSpeed;
            treetop.Left -= treeSpeed;
            ScoreText.Text = score.ToString();

            if(treebottom.Left < -50)
            {
                treebottom.Left = 800;
                score++;
            }
            if(treetop.Left < -80)
            {
                treetop.Left = 950;
                score++;
            }

            if(Santa.Bounds.IntersectsWith(treebottom.Bounds) ||
              Santa.Bounds.IntersectsWith(treetop.Bounds) ||
              Santa.Bounds.IntersectsWith(ground.Bounds)
              )
            {
                endGame();
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }



        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
    
    
     private void endGame()
     {
      GameTimer.Stop();
      ScoreText.Text +="Game Over!";
     }
    
    
    
    }



}
