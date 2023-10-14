namespace ParkingMS
{
    partial class Sections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sections));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label2 = new Label();
            sNameTb = new ULControls.ULTextBox();
            label3 = new Label();
            CapacityTb = new ULControls.ULTextBox();
            label4 = new Label();
            CostTb = new ULControls.ULTextBox();
            label5 = new Label();
            DescTb = new ULControls.ULTextBox();
            label6 = new Label();
            SectionList = new Guna.UI2.WinForms.Guna2DataGridView();
            AddBtn = new ULControls.ULButton();
            DeleteBtn = new ULControls.ULButton();
            EditBtn = new ULControls.ULButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SectionList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 97, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-34, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 44);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(954, 9);
            button1.Name = "button1";
            button1.Size = new Size(47, 23);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 0;
            label1.Text = "Parking Managment System";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(111, 97, 192);
            label2.Location = new Point(34, 110);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 1;
            label2.Text = "Section Name";
            // 
            // sNameTb
            // 
            sNameTb.BackColor = SystemColors.Window;
            sNameTb.BorderColor = Color.MediumSlateBlue;
            sNameTb.BorderFocusColor = Color.HotPink;
            sNameTb.BorderSize = 2;
            sNameTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sNameTb.ForeColor = Color.DimGray;
            sNameTb.Location = new Point(34, 146);
            sNameTb.Multiline = false;
            sNameTb.Name = "sNameTb";
            sNameTb.Padding = new Padding(7);
            sNameTb.PasswordChar = false;
            sNameTb.Size = new Size(210, 30);
            sNameTb.TabIndex = 2;
            sNameTb.Texts = "";
            sNameTb.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(111, 97, 192);
            label3.Location = new Point(250, 110);
            label3.Name = "label3";
            label3.Size = new Size(151, 24);
            label3.TabIndex = 1;
            label3.Text = "Section Capacity";
            // 
            // CapacityTb
            // 
            CapacityTb.BackColor = SystemColors.Window;
            CapacityTb.BorderColor = Color.MediumSlateBlue;
            CapacityTb.BorderFocusColor = Color.HotPink;
            CapacityTb.BorderSize = 2;
            CapacityTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CapacityTb.ForeColor = Color.DimGray;
            CapacityTb.Location = new Point(250, 146);
            CapacityTb.Multiline = false;
            CapacityTb.Name = "CapacityTb";
            CapacityTb.Padding = new Padding(7);
            CapacityTb.PasswordChar = false;
            CapacityTb.Size = new Size(215, 30);
            CapacityTb.TabIndex = 2;
            CapacityTb.Texts = "";
            CapacityTb.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(111, 97, 192);
            label4.Location = new Point(471, 110);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 1;
            label4.Text = "Section Cost";
            // 
            // CostTb
            // 
            CostTb.BackColor = SystemColors.Window;
            CostTb.BorderColor = Color.MediumSlateBlue;
            CostTb.BorderFocusColor = Color.HotPink;
            CostTb.BorderSize = 2;
            CostTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostTb.ForeColor = Color.DimGray;
            CostTb.Location = new Point(471, 146);
            CostTb.Multiline = false;
            CostTb.Name = "CostTb";
            CostTb.Padding = new Padding(7);
            CostTb.PasswordChar = false;
            CostTb.Size = new Size(201, 30);
            CostTb.TabIndex = 2;
            CostTb.Texts = "";
            CostTb.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(111, 97, 192);
            label5.Location = new Point(678, 110);
            label5.Name = "label5";
            label5.Size = new Size(173, 24);
            label5.TabIndex = 1;
            label5.Text = "Section Description";
            // 
            // DescTb
            // 
            DescTb.BackColor = SystemColors.Window;
            DescTb.BorderColor = Color.MediumSlateBlue;
            DescTb.BorderFocusColor = Color.HotPink;
            DescTb.BorderSize = 2;
            DescTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DescTb.ForeColor = Color.DimGray;
            DescTb.Location = new Point(678, 146);
            DescTb.Multiline = false;
            DescTb.Name = "DescTb";
            DescTb.Padding = new Padding(7);
            DescTb.PasswordChar = false;
            DescTb.Size = new Size(264, 30);
            DescTb.TabIndex = 2;
            DescTb.Texts = "";
            DescTb.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(111, 97, 192);
            label6.Location = new Point(82, 66);
            label6.Name = "label6";
            label6.Size = new Size(176, 24);
            label6.TabIndex = 1;
            label6.Text = "Section Managment";
            // 
            // SectionList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SectionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SectionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SectionList.ColumnHeadersHeight = 4;
            SectionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SectionList.DefaultCellStyle = dataGridViewCellStyle3;
            SectionList.GridColor = Color.FromArgb(231, 229, 255);
            SectionList.Location = new Point(34, 219);
            SectionList.Name = "SectionList";
            SectionList.RowHeadersVisible = false;
            SectionList.RowTemplate.Height = 25;
            SectionList.Size = new Size(908, 338);
            SectionList.TabIndex = 3;
            SectionList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SectionList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SectionList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SectionList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SectionList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SectionList.ThemeStyle.BackColor = Color.White;
            SectionList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SectionList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            SectionList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SectionList.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SectionList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SectionList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SectionList.ThemeStyle.HeaderStyle.Height = 4;
            SectionList.ThemeStyle.ReadOnly = false;
            SectionList.ThemeStyle.RowsStyle.BackColor = Color.White;
            SectionList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SectionList.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SectionList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SectionList.ThemeStyle.RowsStyle.Height = 25;
            SectionList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SectionList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SectionList.CellContentClick += SectionList_CellContentClick;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Window;
            AddBtn.BackgroundColor = SystemColors.Window;
            AddBtn.BorderColor = Color.FromArgb(111, 97, 192);
            AddBtn.BorderRadius = 31;
            AddBtn.BorderSize = 1;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.FromArgb(111, 97, 192);
            AddBtn.Location = new Point(415, 182);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(150, 31);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add section";
            AddBtn.TextColor = Color.FromArgb(111, 97, 192);
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.Window;
            DeleteBtn.BackgroundColor = SystemColors.Window;
            DeleteBtn.BorderColor = Color.FromArgb(111, 97, 192);
            DeleteBtn.BorderRadius = 31;
            DeleteBtn.BorderSize = 1;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.FromArgb(111, 97, 192);
            DeleteBtn.Location = new Point(642, 182);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(150, 31);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete section";
            DeleteBtn.TextColor = Color.FromArgb(111, 97, 192);
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.Window;
            EditBtn.BackgroundColor = SystemColors.Window;
            EditBtn.BorderColor = Color.FromArgb(111, 97, 192);
            EditBtn.BorderRadius = 31;
            EditBtn.BorderSize = 1;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.FromArgb(111, 97, 192);
            EditBtn.Location = new Point(205, 182);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(150, 31);
            EditBtn.TabIndex = 4;
            EditBtn.Text = "Edit section";
            EditBtn.TextColor = Color.FromArgb(111, 97, 192);
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // Sections
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 581);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(SectionList);
            Controls.Add(DescTb);
            Controls.Add(label5);
            Controls.Add(CostTb);
            Controls.Add(label4);
            Controls.Add(CapacityTb);
            Controls.Add(label3);
            Controls.Add(sNameTb);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Sections";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sections";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SectionList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private ULControls.ULTextBox sNameTb;
        private ULControls.ULTextBox DescTb;
        private Label label5;
        private ULControls.ULTextBox CostTb;
        private Label label4;
        private ULControls.ULTextBox CapacityTb;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView SectionList;
        private Label label6;
        private ULControls.ULButton AddBtn;
        private ULControls.ULButton DeleteBtn;
        private ULControls.ULButton EditBtn;
    }
}