using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TechMartProductManager
{
    public partial class Form1 : Form
    {
        BindingList<Product> products =
            new BindingList<Product>();

        BindingSource bindingSource =
            new BindingSource();

        public Form1()
        {
            InitializeComponent();

            LoadCategory();

            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;

            UpdateStatus();
        }

        void LoadCategory()
        {
            BindingList<Category> categories =
                new BindingList<Category>();

            categories.Add(
                new Category("DT", "Điện thoại"));

            categories.Add(
                new Category("LT", "Laptop"));

            categories.Add(
                new Category("PK", "Phụ kiện"));

            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Value";
        }

        bool ValidateInput()
        {
            errorProvider.Clear();

            bool result = true;

            if (string.IsNullOrWhiteSpace(
                txtProductName.Text))
            {
                errorProvider.SetError(
                    txtProductName,
                    "Tên sản phẩm không được để trống!");

                result = false;
            }

            decimal price;

            if (!decimal.TryParse(
                txtUnitPrice.Text,
                out price) || price <= 0)
            {
                errorProvider.SetError(
                    txtUnitPrice,
                    "Đơn giá phải lớn hơn 0!");

                result = false;
            }

            int quantity;

            if (!int.TryParse(
                txtQuantity.Text,
                out quantity) || quantity < 0)
            {
                errorProvider.SetError(
                    txtQuantity,
                    "Số lượng phải lớn hơn hoặc bằng 0!");

                result = false;
            }

            return result;
        }

        Product GetProduct()
        {
            Product product = new Product();

            product.ProductId =
                txtProductId.Text.Trim();

            product.ProductName =
                txtProductName.Text.Trim();

            product.Category =
                cboCategory.Text;

            product.CategoryValue =
                cboCategory.SelectedValue?.ToString();

            product.UnitPrice =
                decimal.Parse(txtUnitPrice.Text);

            product.Quantity =
                int.Parse(txtQuantity.Text);

            product.Avatar =
                picAvatar.ImageLocation;

            return product;
        }

        void ShowProduct(Product product)
        {
            txtProductId.Text =
                product.ProductId;

            txtProductName.Text =
                product.ProductName;

            txtUnitPrice.Text =
                product.UnitPrice.ToString();

            txtQuantity.Text =
                product.Quantity.ToString();

            cboCategory.SelectedValue =
                product.CategoryValue;

            if (!string.IsNullOrEmpty(product.Avatar)
                && File.Exists(product.Avatar))
            {
                picAvatar.ImageLocation =
                    product.Avatar;
            }
            else
            {
                picAvatar.Image = null;
                picAvatar.ImageLocation = null;
            }
        }

        void ClearInput()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();

            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0;

            picAvatar.Image = null;
            picAvatar.ImageLocation = null;

            errorProvider.Clear();

            dgvProducts.ClearSelection();
        }

        void UpdateStatus()
        {
            lblStatus.Text =
                "Tổng số sản phẩm: " +
                products.Count;
        }

        private void btnChooseImage_Click(
            object sender,
            EventArgs e)
        {
            OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Title =
                "Chọn ảnh sản phẩm";

            dialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() ==
                DialogResult.OK)
            {
                picAvatar.ImageLocation =
                    dialog.FileName;
            }
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            Product product =
                GetProduct();

            products.Add(product);

            bindingSource.ResetBindings(false);

            UpdateStatus();

            MessageBox.Show(
                "Thêm sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearInput();
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần cập nhật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput())
                return;

            Product oldProduct =
                dgvProducts.CurrentRow
                .DataBoundItem as Product;

            if (oldProduct == null)
                return;

            Product newProduct =
                GetProduct();

            oldProduct.ProductId =
                newProduct.ProductId;

            oldProduct.ProductName =
                newProduct.ProductName;

            oldProduct.Category =
                newProduct.Category;

            oldProduct.CategoryValue =
                newProduct.CategoryValue;

            oldProduct.UnitPrice =
                newProduct.UnitPrice;

            oldProduct.Quantity =
                newProduct.Quantity;

            oldProduct.Avatar =
                newProduct.Avatar;

            bindingSource.ResetCurrentItem();

            MessageBox.Show(
                "Cập nhật sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Product product =
                dgvProducts.CurrentRow
                .DataBoundItem as Product;

            if (product == null)
                return;

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa sản phẩm này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                products.Remove(product);

                bindingSource.ResetBindings(false);

                UpdateStatus();

                ClearInput();

                MessageBox.Show(
                    "Xóa sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearInput();
        }

        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Product product =
                dgvProducts.Rows[e.RowIndex]
                .DataBoundItem as Product;

            if (product != null)
                ShowProduct(product);
        }

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            string keyword =
                txtSearch.Text.Trim().ToLower();

            if (keyword == "")
            {
                bindingSource.DataSource =
                    products;

                return;
            }

            BindingList<Product> result =
                new BindingList<Product>();

            foreach (Product product in products)
            {
                if (product.ProductName
                    .ToLower()
                    .Contains(keyword))
                {
                    result.Add(product);
                }
            }

            bindingSource.DataSource =
                result;
        }

        private void btnExportCSV_Click(
            object sender,
            EventArgs e)
        {
            SaveFileDialog dialog =
                new SaveFileDialog();

            dialog.Title =
                "Xuất danh sách sản phẩm";

            dialog.Filter =
                "CSV Files|*.csv";

            dialog.FileName =
                "Products.csv";

            if (dialog.ShowDialog() !=
                DialogResult.OK)
                return;

            StringBuilder csv =
                new StringBuilder();

            csv.AppendLine(
                "Mã SP,Tên SP,Danh Mục,Đơn Giá,Số Lượng");

            foreach (Product product in products)
            {
                csv.AppendLine(
                    "\"" +
                    product.ProductId +
                    "\"," +

                    "\"" +
                    product.ProductName +
                    "\"," +

                    "\"" +
                    product.Category +
                    "\"," +

                    "\"" +
                    product.UnitPrice.ToString("N0") +
                    "\"," +

                    "\"" +
                    product.Quantity +
                    "\"");
            }

            File.WriteAllText(
                dialog.FileName,
                csv.ToString(),
                Encoding.UTF8);

            MessageBox.Show(
                "Xuất file CSV thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void exportCSVToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            btnExportCSV_Click(
                sender,
                e);
        }

        private void exitToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}