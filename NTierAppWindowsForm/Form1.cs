using Ninject;
using NTierApp.Business.Abstract;
using NTierApp.Business.DependencyResolvers.Ninject;
using NTierApp.Entities.Concrete;

namespace NTierApp.WindowsForm
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;

        public Form1()
        {
            InitializeComponent();

            _productManager = new StandardKernel(new BusinessModule()).Get<IProductService>();
            _categoryManager = new StandardKernel(new BusinessModule()).Get<ICategoryService>();
            // _productManager = new ProductManager(new EfProductDal());
            // _categoryManager = new CategoryManager(new EfCategoryDal());
            // _productManager = new ProductManager(new AdnProductDal());
            // _categoryManager = new CategoryManager(new AdnCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDgvProduct();
            LoadCategoryComboBox();
        }

        private void LoadCategoryComboBox()
        {
            cbxSearchByCategory.DataSource = _categoryManager.GetAll();
            cbxSearchByCategory.DisplayMember = "CategoryName";
            cbxSearchByCategory.ValueMember = "CategoryId";

            cbxAddCategory.DataSource = _categoryManager.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";

            cbxUpdateCategory.DataSource = _categoryManager.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
        }

        private void LoadDgvProduct()
        {
            dgvProduct.DataSource = _productManager.GetAll();
        }

        private void tbxSearchByProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchByProductName.Text))
            {
                dgvProduct.DataSource = _productManager.GetProductsByProductName(tbxSearchByProductName.Text);
            }
            else
            {
                LoadDgvProduct();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProduct.CurrentRow;
            if (row != null)
            {
                tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
                cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
                tbxUpdatePrice.Text = row.Cells[3].Value.ToString();
                tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
                tbxUpdateStockAmount.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvProduct.CurrentRow;

                if (row != null)
                {
                    Product product = new Product
                    {
                        ProductName = tbxUpdateProductName.Text,
                        CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                        ProductId = Convert.ToInt32(row.Cells[0].Value),
                        QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                        UnitPrice = Convert.ToDecimal(tbxUpdatePrice.Text),
                        UnitsInStock = Convert.ToInt16(tbxUpdateStockAmount.Text),
                    };

                    _productManager.Update(product);
                }

                MessageBox.Show(@"Ürün Başarıyla Güncellendi");
                LoadDgvProduct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product()
                {
                    ProductName = tbxAddProductName.Text,
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxAddStockAmount.Text),
                };

                _productManager.Add(product);
                MessageBox.Show(@"Ürün başarıyla eklendi");
                LoadDgvProduct();
                ClearTextBoxes(gbxAddProduct);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ClearTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = dgvProduct.CurrentRow;
            if (row != null)
            {
                Product product = new Product()
                {
                    ProductId = Convert.ToInt32(row.Cells[0].Value),
                };
                _productManager.Delete(product);
            }

            MessageBox.Show(@"Seçtiğiniz ürün başarıyla silindi!");
            ClearTextBoxes(gbxUpdateProduct);
            LoadDgvProduct();
        }

        private void cbxSearchByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource =
                    _productManager.GetProductsByCategory(Convert.ToInt32(cbxSearchByCategory.SelectedValue));
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"Hata oluştu: {exception.Message}");
            }
        }
    }
}