using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GenreManager genreManager = new GenreManager(new EfGenreDal());
            //dataGridView1.DataSource = genreManager.GetAll();

            //MovieManager movieManager = new MovieManager(new EfMovieDal());
            //dataGridView1.DataSource = movieManager.GetAll();

            UserManager userManager = new UserManager(new EfUserDal());
            dataGridView1.DataSource = userManager.GetAll();

            //StarManager starManager = new StarManager(new EfStarDal());
            //dataGridView1.DataSource = starManager.GetAll();

            //ProducerManager producerManager = new ProducerManager(new EfProducerDal());
            //dataGridView1.DataSource = producerManager.GetAll();



        }
    }
}
