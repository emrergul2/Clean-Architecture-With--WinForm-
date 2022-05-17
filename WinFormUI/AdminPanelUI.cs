using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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
    public partial class AdminPanelUI : Form
    {
        public AdminPanelUI()
        {
            InitializeComponent();
        }

        private void AdminPanelUI_Load(object sender, EventArgs e)
        {

        }

        MovieManager movieManager = new MovieManager(new EfMovieDal());
        private void btnGet_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = movieManager.GetAll();
        }

        public void RefreshDataGridView()
        {
            dataGridView1.DataSource = movieManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NullControl())
            {
                movieManager.Add(new Movie()
                {
                    Name = txtMovieName.Text,
                    Description = txtMovieDescription.Text,
                    Duration = Convert.ToInt32(txtMovieDuration.Text),
                    Budget = Convert.ToDecimal(txtMovieBudget.Text),
                    Revenue = Convert.ToDecimal(txtRevenue.Text),
                    ReleaseDate = txtMovieReleaseDate.Text
                });
                RefreshDataGridView();
                MessageBox.Show("Movie Added.");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Any item can not be null.");
                ClearTextBox();
            }

        }
        int findID;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            findID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var selectedItem = movieManager.GetById(findID);
            txtMovieName.Text = selectedItem.Name;
            txtMovieBudget.Text = selectedItem.Budget.ToString();
            txtRevenue.Text = Convert.ToString(selectedItem.Revenue);
            txtMovieReleaseDate.Text = selectedItem.ReleaseDate;
            txtMovieDuration.Text = selectedItem.Duration.ToString();
            txtMovieDescription.Text=selectedItem.Description;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                movieManager.Delete(new Movie()
                {
                    MovieId = findID
                });
                RefreshDataGridView();
                MessageBox.Show("Movie Deleted.");
                ClearTextBox();
            } 
        }
        public bool NullControl()
        {
            bool nullControl = true;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox && string.IsNullOrWhiteSpace(item.Text))
                {
                    nullControl = false;
                }
            }
            return nullControl;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NullControl())
            {
                Movie updatedMovie = new Movie()
                {
                    MovieId = findID,
                    Name = txtMovieName.Text,
                    Description = txtMovieDescription.Text,
                    Duration = Convert.ToInt32(txtMovieDuration.Text),
                    Budget = Convert.ToDecimal(txtMovieBudget.Text),
                    Revenue = Convert.ToDecimal(txtRevenue.Text),
                    ReleaseDate = txtMovieReleaseDate.Text
                };
                movieManager.Update(updatedMovie);
                RefreshDataGridView();
                MessageBox.Show("Movie Updated.");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Any item can not be null.");
                ClearTextBox();
            }
        }
        private void ClearTextBox()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

   
    }
}
