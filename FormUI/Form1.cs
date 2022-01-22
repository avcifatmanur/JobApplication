using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _rectangle;
        List<City> cities;

        int dRId;
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);

        }
        CityManager cityManager = new CityManager(new EfCityDal());
        BoroughManager boroughManager = new BoroughManager(new EfBoroughDal());
        PersonManager personManager = new PersonManager(new EfPersonDal());
        CandidateManager candidateManager = new CandidateManager(new EfCandidateDal());

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Job;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DataTable table = new DataTable();
        

        private void dtp_TextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select * from cities", connection);
            SqlDataReader dr;
            connection.Open();
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cityComboBox.Items.Add(dr["CityName"]);
                this.dRId = Convert.ToInt32(dr["CityId"]);
            }
            connection.Close();


        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Column1":
                    _rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex, true);
                    dtp.Size = new Size(_rectangle.Width, _rectangle.Height);
                    dtp.Location = new Point(_rectangle.X, _rectangle.Y);
                    dtp.Visible = true;
                    DateTime column1 = dtp.Value.Date; //seçilen zamanı tuttuk.
                    break;

                case "Column2":
                    Column2.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("select * from cities", connection);
                    SqlDataReader dr;
                    connection.Open();
                    dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        Column2.Items.Add(dr["CityName"]);

                    }
                    connection.Close();
                    break;
                case "Column3":
                    break;
            }
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            boroughComboBox.Items.Clear();
            if (cityComboBox.SelectedIndex!=-1)
            {
                SqlCommand cmd2 = new SqlCommand("select * from boroughs" +
                    " inner join cities on boroughs.cityId=cities.cityId " + dRId, connection);
                SqlDataReader dr;
                connection.Open();
                dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    boroughComboBox.Items.Add(dr["BoroughName"]);
                }
                connection.Close();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birtDate = dateTimePicker1.Value.Date;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            string desc = descriptionTextBox.Text.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
