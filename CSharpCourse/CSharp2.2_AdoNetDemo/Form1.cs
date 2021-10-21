using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            ;
            dataGridView1.DataSource = _productDal.GetAll();
            //writeDataTable();

        }

        private void writeDataTable()
        {
            ProductDal productDal = new ProductDal();
            DataTable dataTable = productDal.GetAll2();
            dataGridView1.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
                
                
            });
            MessageBox.Show("Urun eklendi");
            DataLoad();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            MessageBox.Show("Guncellendi");
            DataLoad();

            
        }

        private void DataLoad()
        {
            dataGridView1.DataSource = _productDal.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _productDal.Delete(Id);
            DataLoad();
        }
    }
}
