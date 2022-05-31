using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace MYFACE
{
    public partial class Face_Main_Form : Form
    {
        public Face_Main_Form()
        {
            InitializeComponent();
        }

        FaceRec faceRec = new FaceRec();   // Creating new object instance

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBoxCam, pictureBoxFace);   // turns On camera
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            faceRec.isTrained = true;   // starts matching faces in live video stream

            faceRec.getPersonName(label6); 

            if (textBoxUser.Text == label6.Text && textBoxUser.Text != null)
            {
               faceRec.getPersonName(labelWelUser);
               pictureBoxCam.Hide();
               pictureBoxFace.Hide();
            }
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(textBoxUser.Text);   // Saving person's image identity
            MessageBox.Show("User Save success! \nNow you can Login !");

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Play play1 = new Play();
            play1.ShowDialog();      // Show Game Form
            this.Hide();
        }
    }
}
