using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Movies = new Form2();
            Movies.Show();
        }

        private void Actors_Click(object sender, EventArgs e)
        {
            actForm act = new actForm();
            act.Show();
        }

        private void sixtoeight_Click(object sender, EventArgs e)
        {
           //query to be written
            Form3 rat = new Form3();
            rat.Show();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            //query to be written
            Form3 rat = new Form3();
            rat.Show();
        }

        private void fourtosix_Click(object sender, EventArgs e)
        {
            //query to be written
            Form3 rat = new Form3();
            rat.Show();
        }

        private void twotofour_Click(object sender, EventArgs e)
        {

            //query to be written
            Form3 rat = new Form3();
            rat.Show();
        }

        private void belowtwo_Click(object sender, EventArgs e)
        {
            //query to be written
            Form3 rat = new Form3();
            rat.Show();
        }

        private void directors_Click(object sender, EventArgs e)
        {
            dirForm dir=new dirForm();
            dir.Show();
        }

        private void genres_Click(object sender, EventArgs e)
        {
            genresForm gen = new genresForm();
            gen.Show();
        }
    }
}
