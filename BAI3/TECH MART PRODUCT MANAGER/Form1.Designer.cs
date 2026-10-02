using System.Drawing;
using System.Windows.Forms;

namespace TechMartProductManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;

        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutPanelRight;
        private TableLayoutPanel searchPanel;

        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblSearch;
        private Label lblImage;

        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtSearch;

        private ComboBox cboCategory;

        private PictureBox picAvatar;

        private Button btnChooseImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnExportCSV;

        private DataGridView dgvProducts;

        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;

        private ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelLeft = new TableLayoutPanel();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblImage = new Label();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnExportCSV = new Button();
            tableLayoutPanelRight = new TableLayoutPanel();
            searchPanel = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            errorProvider = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            tableLayoutPanelRight.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 40);
            menuStrip1.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCSVToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportCSVToolStripMenuItem.Size = new Size(343, 44);
            exportCSVToolStripMenuItem.Text = "Export CSV";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(343, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 638);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1200, 42);
            statusStrip1.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(236, 32);
            lblStatus.Text = "Tổng số sản phẩm: 0";
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelLeft, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelRight, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 40);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Padding = new Padding(5);
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1200, 598);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.ColumnCount = 2;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelLeft.Controls.Add(lblProductId, 0, 0);
            tableLayoutPanelLeft.Controls.Add(txtProductId, 1, 0);
            tableLayoutPanelLeft.Controls.Add(lblProductName, 0, 1);
            tableLayoutPanelLeft.Controls.Add(txtProductName, 1, 1);
            tableLayoutPanelLeft.Controls.Add(lblUnitPrice, 0, 2);
            tableLayoutPanelLeft.Controls.Add(txtUnitPrice, 1, 2);
            tableLayoutPanelLeft.Controls.Add(lblQuantity, 0, 3);
            tableLayoutPanelLeft.Controls.Add(txtQuantity, 1, 3);
            tableLayoutPanelLeft.Controls.Add(lblCategory, 0, 4);
            tableLayoutPanelLeft.Controls.Add(cboCategory, 1, 4);
            tableLayoutPanelLeft.Controls.Add(lblImage, 0, 5);
            tableLayoutPanelLeft.Controls.Add(picAvatar, 1, 5);
            tableLayoutPanelLeft.Controls.Add(btnChooseImage, 1, 6);
            tableLayoutPanelLeft.Controls.Add(btnAdd, 0, 7);
            tableLayoutPanelLeft.Controls.Add(btnUpdate, 1, 7);
            tableLayoutPanelLeft.Controls.Add(btnDelete, 0, 8);
            tableLayoutPanelLeft.Controls.Add(btnClear, 1, 8);
            tableLayoutPanelLeft.Controls.Add(btnExportCSV, 0, 9);
            tableLayoutPanelLeft.Dock = DockStyle.Fill;
            tableLayoutPanelLeft.Location = new Point(8, 8);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.Padding = new Padding(5);
            tableLayoutPanelLeft.RowCount = 10;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Size = new Size(410, 582);
            tableLayoutPanelLeft.TabIndex = 0;
            // 
            // lblProductId
            // 
            lblProductId.Dock = DockStyle.Fill;
            lblProductId.Location = new Point(8, 5);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(134, 40);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP";
            lblProductId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProductId
            // 
            txtProductId.Dock = DockStyle.Fill;
            txtProductId.Location = new Point(148, 8);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(254, 39);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Location = new Point(8, 45);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(134, 40);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProductName
            // 
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(148, 48);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(254, 39);
            txtProductName.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.Location = new Point(8, 85);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(134, 40);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Đơn giá";
            lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Location = new Point(148, 88);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(254, 39);
            txtUnitPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(8, 125);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(134, 40);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Số lượng";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(148, 128);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(254, 39);
            txtQuantity.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(8, 165);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(134, 40);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboCategory
            // 
            cboCategory.Dock = DockStyle.Fill;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(148, 168);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(254, 40);
            cboCategory.TabIndex = 9;
            // 
            // lblImage
            // 
            lblImage.Dock = DockStyle.Fill;
            lblImage.Location = new Point(8, 205);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(134, 150);
            lblImage.TabIndex = 10;
            lblImage.Text = "Ảnh sản phẩm";
            lblImage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Dock = DockStyle.Fill;
            picAvatar.Location = new Point(148, 208);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(254, 144);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 11;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Dock = DockStyle.Fill;
            btnChooseImage.Location = new Point(148, 358);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(254, 34);
            btnChooseImage.TabIndex = 12;
            btnChooseImage.Text = "Chọn Ảnh";
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(8, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 34);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm mới";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Location = new Point(148, 398);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(254, 34);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(8, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(148, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(254, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Làm mới";
            btnClear.Click += btnClear_Click;
            // 
            // btnExportCSV
            // 
            tableLayoutPanelLeft.SetColumnSpan(btnExportCSV, 2);
            btnExportCSV.Dock = DockStyle.Fill;
            btnExportCSV.Location = new Point(8, 478);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(394, 96);
            btnExportCSV.TabIndex = 17;
            btnExportCSV.Text = "Xuất CSV";
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.ColumnCount = 1;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Controls.Add(searchPanel, 0, 0);
            tableLayoutPanelRight.Controls.Add(dgvProducts, 0, 1);
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(424, 8);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 2;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Size = new Size(768, 582);
            tableLayoutPanelRight.TabIndex = 1;
            // 
            // searchPanel
            // 
            searchPanel.ColumnCount = 2;
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchPanel.Controls.Add(lblSearch, 0, 0);
            searchPanel.Controls.Add(txtSearch, 1, 0);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(3, 3);
            searchPanel.Name = "searchPanel";
            searchPanel.RowCount = 1;
            searchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchPanel.Size = new Size(762, 34);
            searchPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(144, 34);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm sản phẩm";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(153, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(606, 39);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeight = 46;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 43);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(762, 536);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(1200, 680);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechMart Product Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelLeft.ResumeLayout(false);
            tableLayoutPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            tableLayoutPanelRight.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}