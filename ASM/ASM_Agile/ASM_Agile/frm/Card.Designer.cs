namespace ASM_Agile.frm
{
	partial class Card
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
			this.dtg_DanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
			this.PhoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.btnClear = new Guna.UI2.WinForms.Guna2Button();
			this.btnExits = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 8;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.Gray;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(1010, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(30, 29);
			this.guna2ControlBox1.TabIndex = 125;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Gray;
			this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(1055, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new System.Drawing.Size(30, 29);
			this.guna2ControlBox2.TabIndex = 124;
			// 
			// guna2Panel5
			// 
			this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
			this.guna2Panel5.BorderColor = System.Drawing.Color.White;
			this.guna2Panel5.BorderRadius = 5;
			this.guna2Panel5.BorderThickness = 2;
			this.guna2Panel5.Controls.Add(this.dtg_DanhSach);
			this.guna2Panel5.Location = new System.Drawing.Point(12, 158);
			this.guna2Panel5.Name = "guna2Panel5";
			this.guna2Panel5.Size = new System.Drawing.Size(1076, 207);
			this.guna2Panel5.TabIndex = 126;
			// 
			// dtg_DanhSach
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dtg_DanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_DanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtg_DanhSach.ColumnHeadersHeight = 27;
			this.dtg_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtg_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneID,
            this.TenSanPham,
            this.TenBrand,
            this.Gia,
            this.SoLuong,
            this.NhaSanXuat});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(175)))), ((int)(((byte)(174)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtg_DanhSach.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtg_DanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtg_DanhSach.Location = new System.Drawing.Point(24, 26);
			this.dtg_DanhSach.Name = "dtg_DanhSach";
			this.dtg_DanhSach.RowHeadersVisible = false;
			this.dtg_DanhSach.RowHeadersWidth = 51;
			this.dtg_DanhSach.RowTemplate.Height = 24;
			this.dtg_DanhSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_DanhSach.Size = new System.Drawing.Size(1029, 199);
			this.dtg_DanhSach.TabIndex = 18;
			this.dtg_DanhSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dtg_DanhSach.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dtg_DanhSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dtg_DanhSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dtg_DanhSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dtg_DanhSach.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dtg_DanhSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtg_DanhSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dtg_DanhSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dtg_DanhSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtg_DanhSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dtg_DanhSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtg_DanhSach.ThemeStyle.HeaderStyle.Height = 27;
			this.dtg_DanhSach.ThemeStyle.ReadOnly = false;
			this.dtg_DanhSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dtg_DanhSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtg_DanhSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtg_DanhSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dtg_DanhSach.ThemeStyle.RowsStyle.Height = 24;
			this.dtg_DanhSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtg_DanhSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// PhoneID
			// 
			this.PhoneID.HeaderText = "PhoneID";
			this.PhoneID.MinimumWidth = 6;
			this.PhoneID.Name = "PhoneID";
			// 
			// TenSanPham
			// 
			this.TenSanPham.HeaderText = "Tên Sản Phẩm";
			this.TenSanPham.MinimumWidth = 6;
			this.TenSanPham.Name = "TenSanPham";
			// 
			// TenBrand
			// 
			this.TenBrand.HeaderText = "Tên Brand";
			this.TenBrand.MinimumWidth = 6;
			this.TenBrand.Name = "TenBrand";
			this.TenBrand.ReadOnly = true;
			// 
			// Gia
			// 
			this.Gia.HeaderText = "Giá";
			this.Gia.MinimumWidth = 6;
			this.Gia.Name = "Gia";
			// 
			// SoLuong
			// 
			this.SoLuong.HeaderText = "Số Lượng";
			this.SoLuong.MinimumWidth = 6;
			this.SoLuong.Name = "SoLuong";
			// 
			// NhaSanXuat
			// 
			this.NhaSanXuat.HeaderText = "Nhà Sản Xuất";
			this.NhaSanXuat.MinimumWidth = 6;
			this.NhaSanXuat.Name = "NhaSanXuat";
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 9;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.Image = global::ASM_Agile.Properties.Resources.edit;
			this.guna2Button2.ImageSize = new System.Drawing.Size(35, 35);
			this.guna2Button2.Location = new System.Drawing.Point(143, 402);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(138, 41);
			this.guna2Button2.TabIndex = 130;
			this.guna2Button2.Text = "Edit";
			this.guna2Button2.UseTransparentBackground = true;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Transparent;
			this.btnClear.BorderRadius = 9;
			this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnClear.Image = global::ASM_Agile.Properties.Resources.clean;
			this.btnClear.ImageSize = new System.Drawing.Size(35, 35);
			this.btnClear.Location = new System.Drawing.Point(598, 402);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(138, 41);
			this.btnClear.TabIndex = 129;
			this.btnClear.Text = "Clear";
			this.btnClear.UseTransparentBackground = true;
			// 
			// btnExits
			// 
			this.btnExits.BackColor = System.Drawing.Color.Transparent;
			this.btnExits.BorderRadius = 9;
			this.btnExits.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnExits.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnExits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnExits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnExits.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnExits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnExits.ForeColor = System.Drawing.Color.White;
			this.btnExits.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnExits.Image = global::ASM_Agile.Properties.Resources.cancel;
			this.btnExits.ImageSize = new System.Drawing.Size(35, 35);
			this.btnExits.Location = new System.Drawing.Point(828, 402);
			this.btnExits.Name = "btnExits";
			this.btnExits.Size = new System.Drawing.Size(138, 41);
			this.btnExits.TabIndex = 128;
			this.btnExits.Text = "Exits";
			this.btnExits.UseTransparentBackground = true;
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 9;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.Image = global::ASM_Agile.Properties.Resources.money;
			this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
			this.guna2Button1.Location = new System.Drawing.Point(371, 402);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(138, 41);
			this.guna2Button1.TabIndex = 127;
			this.guna2Button1.Text = "Thanh Toan";
			this.guna2Button1.UseTransparentBackground = true;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::ASM_Agile.Properties.Resources.shopping_cart;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(465, 26);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(160, 109);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 131;
			this.guna2PictureBox1.TabStop = false;
			// 
			// Card
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.ClientSize = new System.Drawing.Size(1097, 486);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnExits);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.guna2Panel5);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Card";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Card";
			this.guna2Panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
		private Guna.UI2.WinForms.Guna2DataGridView dtg_DanhSach;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenBrand;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
		private Guna.UI2.WinForms.Guna2Button btnClear;
		private Guna.UI2.WinForms.Guna2Button btnExits;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
	}
}