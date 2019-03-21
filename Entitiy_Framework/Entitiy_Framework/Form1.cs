using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entitiy_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowCustomer.DataSource= Customer.GetCustomers();
        }
        int index = 0;
        CRUDCust Customer = new CRUDCust();



        private void button2_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            List<Customer> a = new List<Customer>();
            a.Add(Customer.GetCustomerById(ID));
            ShowCustomer.DataSource = a;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowCustomer.DataSource = Customer.GetCustomers();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

            Customer nuevo = new Customer();
            nuevo.CustomerID = txtCustomerID.Text;
            nuevo.CompanyName = txtCompanyName.Text;
            nuevo.ContactName = txtContactName.Text;
            nuevo.ContactTitle = txtContactTitle.Text;
            nuevo.Address = txtAddres.Text;
            nuevo.City = txtCity.Text;
            nuevo.Region = txtRegion.Text;
            nuevo.Phone = txtPhone.Text;
            nuevo.Country = txtCountry.Text;
            nuevo.PostalCode = txtPostalCode.Text;
            nuevo.Fax = txtFax.Text;
            Customer.InsertCustomers (nuevo);
            MessageBox.Show("TUPLA INSERTADA CON EXITO");

        }

        private void ShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            try { txtCustomerID.Text = ShowCustomer.Rows[index].Cells[0].Value.ToString(); }
            catch { txtCustomerID.Text = "NULL"; }
            try { txtCompanyName.Text = ShowCustomer.Rows[index].Cells[1].Value.ToString(); }
            catch { txtCompanyName.Text = "NULL"; }
            try { txtContactName.Text = ShowCustomer.Rows[index].Cells[2].Value.ToString(); }
            catch { txtContactName.Text = "NULL"; }
            try { txtContactTitle.Text = ShowCustomer.Rows[index].Cells[3].Value.ToString(); }
            catch { txtContactTitle.Text = "NULL"; }
            try { txtAddres.Text = ShowCustomer.Rows[index].Cells[4].Value.ToString(); }
            catch { txtAddres.Text = "NULL"; }
            try { txtCity.Text = ShowCustomer.Rows[index].Cells[5].Value.ToString(); }
            catch { txtCity.Text = "NULL"; }
            try { txtRegion.Text = ShowCustomer.Rows[index].Cells[6].Value.ToString();}
            catch { txtRegion.Text = "NULL";}
            try { txtPhone.Text = ShowCustomer.Rows[index].Cells[9].Value.ToString(); }
            catch { txtPhone.Text = "NULL"; }
            try { txtCountry.Text = ShowCustomer.Rows[index].Cells[8].Value.ToString(); }
            catch { txtCountry.Text = "NULL"; }
            try { txtPostalCode.Text = ShowCustomer.Rows[index].Cells[7].Value.ToString(); }
            catch { txtPostalCode.Text = "NULL"; }
            try { txtFax.Text = ShowCustomer.Rows[index].Cells[10].Value.ToString(); }
            catch { txtFax.Text = "NULL"; }
            btnEliminar.Enabled = true;
            btnInsertar.Enabled = true;
            btnModificicar.Enabled = true;




        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer nuevo = new Customer();
            nuevo.CustomerID = txtCustomerID.Text;
            nuevo.CompanyName = txtCompanyName.Text;
            nuevo.ContactName = txtContactName.Text;
            nuevo.ContactTitle = txtContactTitle.Text;
            nuevo.Address = txtAddres.Text;
            nuevo.City = txtCity.Text;
            nuevo.Region = txtRegion.Text;
            nuevo.Phone = txtPhone.Text;
            nuevo.Country = txtCountry.Text;
            nuevo.PostalCode = txtPostalCode.Text;
            nuevo.Fax = txtFax.Text;
            string id= ShowCustomer.Rows[index].Cells[0].Value.ToString();
            Customer.UpdateCustomer(id, nuevo);
            MessageBox.Show("TUPLA ACTUALIZADA CON EXITO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = ShowCustomer.Rows[index].Cells[0].Value.ToString();
            Customer.DeleteCustomer(id);
            MessageBox.Show("TUPLA ELIMINADA CON EXITO");
        }

        private void ShowCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
