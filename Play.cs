using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace MYFACE
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        int score { get; set; }
        int lives { get; set; }
        private void reset()
        {
            lives = 4;
            score = 0;

            pictureBox_heart1.Visible = true;
            pictureBox_heart2.Visible = true;
            pictureBox_heart3.Visible = true;
            pictureBox_heart4.Visible = true;
        }




        FaceRec_Location FaceRec_Location = new FaceRec_Location();
        private void Play_Load(object sender, EventArgs e)
        {
            FaceRec_Location.openCamera(pictureBox1,false);        
        }
        PictureBox basket = new PictureBox();
        PictureBox pictureBox_basket_top_layer = new PictureBox();
        private void loadBasket(PictureBox pictureBox_basket)
        {
            pictureBox_basket.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_basket.BringToFront();
            pictureBox_basket.Image = Properties.Resources.basket;
            pictureBox_basket.Width = 75;
            pictureBox_basket.Height = 40;
            pictureBox1.Controls.Add(pictureBox_basket); 

            ///ITO ANG PANG KUHA NG POINTS PAG DITO DUMIKIT
            pictureBox1.Controls.Add(pictureBox_basket_top_layer);
            pictureBox_basket_top_layer.BringToFront();
            pictureBox_basket_top_layer.BackColor = Color.Silver;
            pictureBox_basket_top_layer.Height = 5;
            pictureBox_basket_top_layer.Width = 75;

        }
        private void basket_movement(PictureBox pictureBox_basket)
        {
            pictureBox_basket.Location = new Point(FaceRec_Location.getFaceLocation_X, FaceRec_Location.getFaceLocation_Y-60);         
            pictureBox_basket_top_layer.Location = new Point(FaceRec_Location.getFaceLocation_X, FaceRec_Location.getFaceLocation_Y - 60);
        }
        private void basket_collision(PictureBox pictureBox_fruit)
        {
            if (pictureBox_basket_top_layer.Bounds.IntersectsWith(pictureBox_fruit.Bounds))//SHOOT INSIDE THE BASKET
            {
                loadFruits(pictureBox_fruit);
                score++;
                label1.Text = "Score : " + score.ToString();
            }
        }

        private void loadFruits(PictureBox pictureBox_fruit)
        {
            //SET THE IMAGE PROPERTIES
            pictureBox_fruit.Width = 50;
            pictureBox_fruit.Height = 50;
            pictureBox_fruit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_fruit.BringToFront();

            //SET LOCATION OF THE FRUITS
            Random randomX = new Random();
            Random randomY = new Random();
            int locationX = randomX.Next(0,320);
            int locationY = randomY.Next(100,500);
            pictureBox_fruit.Location = new Point(locationX, -locationY);

            //SET RANDOM IMAGE
            Random randomImage = new Random();
            int image = randomX.Next(0, 7);
            if(image == 0)
            {
                pictureBox_fruit.Image = Properties.Resources.apple;
            }
            if (image == 1)
            {
                pictureBox_fruit.Image = Properties.Resources.banana;
            }
            if (image == 2)
            {
                pictureBox_fruit.Image = Properties.Resources.cherry;
            }
            if (image == 3)
            {
                pictureBox_fruit.Image = Properties.Resources.grapes;
            }
            if (image == 4)
            {
                pictureBox_fruit.Image = Properties.Resources.orrange;
            }
            if (image == 5)
            {
                pictureBox_fruit.Image = Properties.Resources.strawberry;
            }
            if (image == 6)
            {
                pictureBox_fruit.Image = Properties.Resources.water_melon;
            }
            pictureBox1.Controls.Add(pictureBox_fruit);
            pictureBox1.BackColor = Color.Transparent;
        }
        PictureBox fruits1 = new PictureBox();
        PictureBox fruits2 = new PictureBox();
        PictureBox fruits3 = new PictureBox();
        PictureBox fruits4 = new PictureBox();
        PictureBox fruits5 = new PictureBox();
        int fruit_speed = 3;

        private void timer_play_Tick(object sender, EventArgs e)
        {
            fruit_movement(fruits1);
            fruit_movement(fruits2);
            fruit_movement(fruits3);
            fruit_movement(fruits4);
            fruit_movement(fruits5);
            fruit_collision();
            basket_movement(basket);

            basket_collision(fruits1);
            basket_collision(fruits2);
            basket_collision(fruits3);
            basket_collision(fruits4);
            basket_collision(fruits5);
            gameOver();


        }
        private void fruit_movement(PictureBox pictureBox_fruit)
        {
            if (pictureBox_fruit.Top < 500)
            {
                pictureBox_fruit.Top += fruit_speed;
            }
            else
            {
                loadFruits(pictureBox_fruit);
                lives--;
            }
        }
        private void fruit_collision()
        {
            if (fruits1.Bounds.IntersectsWith(fruits2.Bounds) || fruits1.Bounds.IntersectsWith(fruits3.Bounds) || fruits1.Bounds.IntersectsWith(fruits4.Bounds) || fruits1.Bounds.IntersectsWith(fruits5.Bounds))
            {
                loadFruits(fruits1);
            }
            if (fruits2.Bounds.IntersectsWith(fruits1.Bounds) || fruits2.Bounds.IntersectsWith(fruits3.Bounds) || fruits2.Bounds.IntersectsWith(fruits4.Bounds) || fruits2.Bounds.IntersectsWith(fruits5.Bounds))
            {
                loadFruits(fruits2);
            }
            if (fruits3.Bounds.IntersectsWith(fruits1.Bounds) || fruits3.Bounds.IntersectsWith(fruits2.Bounds) || fruits3.Bounds.IntersectsWith(fruits4.Bounds) || fruits3.Bounds.IntersectsWith(fruits5.Bounds))
            {
                loadFruits(fruits3);
            }
            if (fruits4.Bounds.IntersectsWith(fruits1.Bounds) || fruits4.Bounds.IntersectsWith(fruits2.Bounds) || fruits4.Bounds.IntersectsWith(fruits3.Bounds) || fruits4.Bounds.IntersectsWith(fruits5.Bounds))
            {
                loadFruits(fruits4);
            }
            if (fruits5.Bounds.IntersectsWith(fruits1.Bounds) || fruits5.Bounds.IntersectsWith(fruits2.Bounds) || fruits5.Bounds.IntersectsWith(fruits3.Bounds) || fruits5.Bounds.IntersectsWith(fruits4.Bounds))
            {
                loadFruits(fruits5);
            }
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            reset();
            loadFruits(fruits1);
            loadFruits(fruits2);
            loadFruits(fruits3);
            loadFruits(fruits4);
            loadFruits(fruits5);

            loadBasket(basket);
            timer_play.Enabled = true;
            button_start.Visible = false;
        }
        private void gameOver()
        {
            if(lives == 3)
            {
                pictureBox_heart4.Visible = false;
            }
            if (lives == 2)
            {
                pictureBox_heart3.Visible = false;
            }
            if (lives == 1)
            {
                pictureBox_heart2.Visible = false;
            }
            if (lives == 0)
            {
                pictureBox_heart1.Visible = false;
                timer_play.Enabled = false;
                button_start.Visible = true;
                MessageBox.Show(this, "Game Over", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
