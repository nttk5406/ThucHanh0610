namespace Bai5_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            label2 = new Label();
            label3 = new Label();
            btnSelect = new Button();
            btnRemove = new Button();
            btnRemoveAll = new Button();
            lblTotal = new Label();
            lblDiscount = new Label();
            lblPayment = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại dịch vụ";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            cboCategory.Location = new Point(319, 42);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(171, 113);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(185, 164);
            lstAvailableServices.TabIndex = 2;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(447, 113);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(189, 164);
            lstSelectedServices.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 81);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Dịch vụ có sẵn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 81);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Đã chọn";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(376, 151);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(51, 29);
            btnSelect.TabIndex = 6;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(376, 210);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(51, 29);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(305, 295);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(51, 29);
            btnRemoveAll.TabIndex = 8;
            btnRemoveAll.Text = "<<";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(206, 338);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(196, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Tổng tiền chưa giảm: 0 VNĐ";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(206, 374);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(138, 20);
            lblDiscount.TabIndex = 10;
            lblDiscount.Text = "Tỷ lệ chiết khấu: 0%";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(206, 411);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(203, 20);
            lblPayment.TabIndex = 11;
            lblPayment.Text = "Thành tiền thanh toán: 0 VNĐ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPayment);
            Controls.Add(lblDiscount);
            Controls.Add(lblTotal);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(cboCategory);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Label label2;
        private Label label3;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnRemoveAll;
        private Label lblTotal;
        private Label lblDiscount;
        private Label lblPayment;
    }
}
