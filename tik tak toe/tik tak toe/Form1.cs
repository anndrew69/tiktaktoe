using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tik_tak_toe
{
    public partial class Piškvorky : Form
    {

        //bool crossCircle = true; //true == cross, false == circle
        int rounds = 0;
        bool crossCircle = true;
        
        int cross = 0;
        int circle = 0;
        

        public Piškvorky()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("zdarec lulw pravidla omegalul", "dude");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (crossCircle)
            {
                b.Text = "x";
                rounds = rounds + 1;
                crossCircle = false;
                //circle = false;
                //cross = false;
                b.Name = "x";
                //labelResult.Text = crossCircle.ToString();
                b.Enabled = false;
            }
            else if (crossCircle == false)
            {
                b.Text = "o";
                rounds = rounds + 1;
                crossCircle = true;
                //cross = true;
                //circle = true;
                b.Name = "o";
                //labelResult.Text = crossCircle.ToString();
                b.Enabled = false;
            }
            if (rounds == 9)
            {
                labelResult.Text = "draw";
            }
            //straight
            if (crossCircle == false && (A.Name == B.Name) && (B.Name == C.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (A.Name == B.Name) && (B.Name == C.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }

            if (crossCircle == false && (D.Name == E.Name) && (E.Name == F.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (D.Name == E.Name) && (E.Name == F.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }

            if (crossCircle == false && (G.Name == H.Name) && (H.Name == I.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (G.Name == H.Name) && (H.Name == I.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }
            //end of straight

            //down
            if (crossCircle == false && (A.Name == D.Name) && (D.Name == G.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (A.Name == D.Name) && (D.Name == G.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }

            if (crossCircle == false && (B.Name == E.Name) && (E.Name == H.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (B.Name == E.Name) && (E.Name == H.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }

            if (crossCircle == false && (C.Name == F.Name) && (F.Name == I.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (C.Name == F.Name) && (F.Name == I.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }
            //end of down

            //cross
            if (crossCircle == false && (A.Name == E.Name) && (E.Name == I.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (A.Name == E.Name) && (E.Name == I.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }

            if (crossCircle == false && (C.Name == E.Name) && (E.Name == G.Name))
            {
                labelResult.Text = "cross wins";
                cross = cross + 1;
                crosscount.Text = cross.ToString();
            }
            else if (crossCircle == true && (C.Name == E.Name) && (E.Name == G.Name))
            {
                labelResult.Text = "circle wins";
                circle = circle + 1;
                circlecount.Text = circle.ToString();
            }
            //end of cross
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            
            A.Text = "";
            B.Text = "";
            C.Text = "";
            D.Text = "";
            E.Text = "";
            F.Text = "";
            G.Text = "";
            H.Text = "";
            I.Text = "";

            A.Name = "A";
            B.Name = "B";
            C.Name = "C";
            D.Name = "D";
            E.Name = "E";
            F.Name = "F";
            G.Name = "G";
            H.Name = "H";
            I.Name = "I";

            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;
            H.Enabled = true;
            I.Enabled = true;

            rounds = 0;
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
           
        }

        private void Piškvorky_Load(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";

            A.Text = " ";
            B.Text = " ";
            C.Text = " ";
            D.Text = " ";
            E.Text = " ";
            F.Text = " ";
            G.Text = " ";
            H.Text = " ";
            I.Text = " ";

            A.Name = " ";
            B.Name = " ";
            C.Name = " ";
            D.Name = " ";
            E.Name = " ";
            F.Name = " ";
            G.Name = " ";
            H.Name = " ";
            I.Name = " ";

            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;
            H.Enabled = true;
            I.Enabled = true;

            cross = 0;
            circle = 0;

            rounds = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("zdarec lulw pravidla omegalul", "dude");
        }
    
    }
}
