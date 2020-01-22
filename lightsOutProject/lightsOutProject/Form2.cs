using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lightsOutProject
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            difficultyTextBox.Enabled = false;
            xTextBox.Enabled = false;
            yTextBox.Enabled = false;

            difficultyTextBox.BackColor = Color.White;
            xTextBox.BackColor = Color.White;
            yTextBox.BackColor = Color.White;

            difficultyTextBox.Text = form1.difficulty.ToString();
            xTextBox.Text = form1.width_x.ToString();
            yTextBox.Text = form1.length_y.ToString();
        }

        public void changeDifficulty(int i)
        {
            int d = int.Parse(difficultyTextBox.Text)+i;
            if (d < 1)
            {
                d = 1;
            }
            difficultyTextBox.Text = d.ToString();
        }

        public void changeX(int i)
        {
            int x = int.Parse(xTextBox.Text) + i;
            if (x < 2)
            {
                x = 2;
            }
            xTextBox.Text = x.ToString();
        }

        public void changeY(int i)
        {
            int y = int.Parse(yTextBox.Text) + i;
            if (y < 2)
            {
                y = 2;
            }
            yTextBox.Text = y.ToString();
        }

        private void difficultyNegativeButton_Click(object sender, EventArgs e)
        {
            changeDifficulty(-1);
        }

        private void difficultyPositiveButton_Click(object sender, EventArgs e)
        {
            changeDifficulty(1);
        }

        private void xNegativeButton_Click(object sender, EventArgs e)
        {
            changeX(-1);
        }

        private void xPositiveButton_Click(object sender, EventArgs e)
        {
            changeX(1);
        }

        private void yNegativeButton_Click(object sender, EventArgs e)
        {
            changeY(-1);
        }

        private void yPositiveButton_Click(object sender, EventArgs e)
        {
            changeY(1);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            form1.difficulty = int.Parse(difficultyTextBox.Text);
            form1.width_x = int.Parse(xTextBox.Text);
            form1.length_y = int.Parse(yTextBox.Text);
            button.Parent.FindForm().Close();
        }
    }
}
