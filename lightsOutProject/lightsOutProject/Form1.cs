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
    public partial class Form1 : Form
    {
        private LightsOutPanel[,] lightsOutPanels;
        public int difficulty;
        public int width_x;
        public int length_y;

        public Form1()
        {
            InitializeComponent();
            difficulty = 3;
            width_x = 2;
            length_y = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void GameStart_Click(object sender, EventArgs e)
        {
            lightsOutPanels = new LightsOutPanel[width_x, length_y];
            Form gameForm = new Form();
            gameForm.Size = new Size((width_x * 49)+40, (length_y * 49)+50);
            for (int x = 0; x < width_x; x++)
            {
                for(int y = 0; y < length_y; y++)
                {
                    LightsOutPanel panel = new LightsOutPanel(x,y);
                    panel.Click += new EventHandler(panel_Click);
                    panel.changeColor();
                    panel.Size = new Size(48, 48);
                    panel.Location = new Point((x*49)+5,(y*49)+5);
                    gameForm.Controls.Add(panel);
                    lightsOutPanels[x, y] = panel;
                }
            }
            setup_Game();
            gameForm.Show();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            LightsOutPanel panel = (LightsOutPanel)sender;
            //MessageBox.Show(x.ToString()+ " , " + y.ToString());
            changeAction(panel.coordX, panel.coordY);
            Form form = (Form)panel.Parent;
            checkWin(form);
        }

        private void changeAction(int x, int y)
        {
            lightsOutPanels[x,y].changeOn_Off();
            for (int i = 1; i >= -1; i -= 2)
            {
                try
                {
                    lightsOutPanels[x + i, y].changeOn_Off();
                }
                catch { }
                try
                {
                    lightsOutPanels[x, y + i].changeOn_Off();
                }
                catch { }
            }
        }

        private void setup_Game()
        {
            Random random = new Random();
            int x;
            int y;
            for (int i = 0; i < difficulty; i++)
            {
                x = random.Next(width_x);
                y = random.Next(length_y);
                changeAction(x, y);
            }
            
        }

        private void checkWin(Form form)
        {
            bool b = true;
            foreach (LightsOutPanel panel in lightsOutPanels)
            {
                if (panel.on_off)
                {
                    b = false;
                }
            }
            if (b)
            {
                MessageBox.Show("You Win!");
                form.Close();
            }
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2(this);
            form.Show();

            //Form form = new Form();
            //GroupBox difficultyBox = new GroupBox();
            //GroupBox sizeBox = new GroupBox();
            //Label difficultyLabel = new Label();
            //Label sizeLabel = new Label();
            //TextBox difficultyTextBox = new TextBox();
            //TextBox sizeTextBox = new TextBox();
            //Button difficultyButton = new Button();
            //Button sizeButton = new Button();

            //difficultyBox.Controls.Add(difficultyLabel);
            //difficultyBox.Controls.Add(difficultyTextBox);
            //difficultyBox.Controls.Add(difficultyButton);

            //sizeBox.Controls.Add(sizeLabel);
            //sizeBox.Controls.Add(sizeTextBox);
            //sizeBox.Controls.Add(sizeButton);

            //form.Controls.Add(difficultyBox);
            //form.Controls.Add(sizeBox);

            //form.Show();

        }
    }
}
