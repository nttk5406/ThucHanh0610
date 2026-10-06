namespace Bai5_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnMaNV;
        private System.Windows.Forms.ColumnHeader columnHoTen;
        private System.Windows.Forms.ColumnHeader columnChucVu;
        private System.Windows.Forms.ColumnHeader columnNgayVaoLam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            imageList1 = new ImageList(components);
            lsvEmployees = new ListView();
            columnMaNV = new ColumnHeader();
            columnHoTen = new ColumnHeader();
            columnChucVu = new ColumnHeader();
            columnNgayVaoLam = new ColumnHeader();
            cboView = new ComboBox();
            lblView = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Panel2.Controls.Add(cboView);
            splitContainer1.Panel2.Controls.Add(lblView);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Size = new Size(1029, 667);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = imageList1;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Margin = new Padding(3, 4, 3, 4);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(830, 667);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            imageList1.Images.SetKeyName(1, "user.png");
            // 
            // lsvEmployees
            // 
            lsvEmployees.Columns.AddRange(new ColumnHeader[] { columnMaNV, columnHoTen, columnChucVu, columnNgayVaoLam });
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.Location = new Point(17, 67);
            lsvEmployees.Margin = new Padding(3, 4, 3, 4);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(731, 572);
            lsvEmployees.SmallImageList = imageList1;
            lsvEmployees.TabIndex = 1;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // columnMaNV
            // 
            columnMaNV.Text = "Mã NV";
            columnMaNV.Width = 100;
            // 
            // columnHoTen
            // 
            columnHoTen.Text = "Họ Tên";
            columnHoTen.Width = 180;
            // 
            // columnChucVu
            // 
            columnChucVu.Text = "Chức vụ";
            columnChucVu.Width = 150;
            // 
            // columnNgayVaoLam
            // 
            columnNgayVaoLam.Text = "Ngày vào làm";
            columnNgayVaoLam.Width = 120;
            // 
            // cboView
            // 
            cboView.DropDownStyle = ComboBoxStyle.DropDownList;
            cboView.FormattingEnabled = true;
            cboView.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "Tile" });
            cboView.Location = new Point(623, 16);
            cboView.Margin = new Padding(3, 4, 3, 4);
            cboView.Name = "cboView";
            cboView.Size = new Size(137, 28);
            cboView.TabIndex = 2;
            cboView.SelectedIndexChanged += cboView_SelectedIndexChanged;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Location = new Point(537, 21);
            lblView.Name = "lblView";
            lblView.Size = new Size(91, 20);
            lblView.TabIndex = 3;
            lblView.Text = "Chế độ xem:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(17, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(209, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Danh sách nhân viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 667);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - Quản lý nhân viên";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}