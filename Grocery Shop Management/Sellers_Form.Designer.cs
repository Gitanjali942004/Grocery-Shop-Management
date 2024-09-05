
namespace Grocery_Shop_Management
{
    partial class Sellers_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sellers_Form));
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.billdatagrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stockdatagrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblbill = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnaddtobill = new System.Windows.Forms.Button();
            this.txtclientname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblbilling = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(313, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(749, 67);
            this.label4.TabIndex = 11;
            this.label4.Text = "GROCERY SHOP MANAGEMENT ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.billdatagrid);
            this.panel1.Controls.Add(this.TotalLbl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.stockdatagrid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblbill);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnaddtobill);
            this.panel1.Controls.Add(this.txtclientname);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.txtitem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblbilling);
            this.panel1.Location = new System.Drawing.Point(56, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 780);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Fuchsia;
            this.label7.Location = new System.Drawing.Point(45, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "+ New Customer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // billdatagrid
            // 
            this.billdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Items,
            this.Price,
            this.Qty,
            this.Total});
            this.billdatagrid.Location = new System.Drawing.Point(756, 138);
            this.billdatagrid.Name = "billdatagrid";
            this.billdatagrid.RowHeadersWidth = 51;
            this.billdatagrid.RowTemplate.Height = 24;
            this.billdatagrid.Size = new System.Drawing.Size(569, 226);
            this.billdatagrid.TabIndex = 39;
            this.billdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billdatagrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Items
            // 
            this.Items.HeaderText = "Items";
            this.Items.MinimumWidth = 6;
            this.Items.Name = "Items";
            this.Items.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.BackColor = System.Drawing.Color.White;
            this.TotalLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.Magenta;
            this.TotalLbl.Location = new System.Drawing.Point(982, 534);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(99, 46);
            this.TotalLbl.TabIndex = 38;
            this.TotalLbl.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(961, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 45);
            this.button1.TabIndex = 37;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(202, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 48);
            this.label6.TabIndex = 36;
            this.label6.Text = "Stock Available";
            // 
            // stockdatagrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockdatagrid.Location = new System.Drawing.Point(40, 472);
            this.stockdatagrid.Name = "stockdatagrid";
            this.stockdatagrid.RowHeadersWidth = 51;
            this.stockdatagrid.RowTemplate.Height = 24;
            this.stockdatagrid.Size = new System.Drawing.Size(603, 257);
            this.stockdatagrid.TabIndex = 34;
            this.stockdatagrid.ColumnHeadersDefaultCellStyleChanged += new System.EventHandler(this.Sellers_Form_Load);
            this.stockdatagrid.SelectionChanged += new System.EventHandler(this.stockdatagrid_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblbill
            // 
            this.lblbill.AutoSize = true;
            this.lblbill.BackColor = System.Drawing.Color.White;
            this.lblbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbill.Font = new System.Drawing.Font("Sitka Banner", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.ForeColor = System.Drawing.Color.Magenta;
            this.lblbill.Location = new System.Drawing.Point(1011, 67);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(81, 58);
            this.lblbill.TabIndex = 32;
            this.lblbill.Text = "Bill";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnreset.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(344, 350);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(194, 45);
            this.btnreset.TabIndex = 28;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnaddtobill
            // 
            this.btnaddtobill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnaddtobill.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtobill.Location = new System.Drawing.Point(61, 350);
            this.btnaddtobill.Name = "btnaddtobill";
            this.btnaddtobill.Size = new System.Drawing.Size(199, 45);
            this.btnaddtobill.TabIndex = 27;
            this.btnaddtobill.Text = "Add To Bill";
            this.btnaddtobill.UseVisualStyleBackColor = false;
            this.btnaddtobill.Click += new System.EventHandler(this.btnaddtobill_Click);
            // 
            // txtclientname
            // 
            this.txtclientname.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclientname.Location = new System.Drawing.Point(344, 265);
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.Size = new System.Drawing.Size(219, 35);
            this.txtclientname.TabIndex = 26;
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(40, 265);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(220, 35);
            this.txtprice.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(339, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "CLIENT NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "PRICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "QUANTITY";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(345, 173);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(219, 35);
            this.txtquantity.TabIndex = 21;
            // 
            // txtitem
            // 
            this.txtitem.Enabled = false;
            this.txtitem.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Location = new System.Drawing.Point(40, 173);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(220, 35);
            this.txtitem.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "ITEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(606, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 4);
            this.panel2.TabIndex = 14;
            // 
            // lblbilling
            // 
            this.lblbilling.AutoSize = true;
            this.lblbilling.BackColor = System.Drawing.Color.White;
            this.lblbilling.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblbilling.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbilling.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblbilling.Location = new System.Drawing.Point(607, 0);
            this.lblbilling.Name = "lblbilling";
            this.lblbilling.Size = new System.Drawing.Size(120, 45);
            this.lblbilling.TabIndex = 12;
            this.lblbilling.Text = "Billing";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(56, 856);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 45);
            this.button3.TabIndex = 28;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Sellers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1475, 906);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(1493, 953);
            this.Name = "Sellers_Form";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sellers_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblbilling;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtclientname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnaddtobill;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.DataGridView stockdatagrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.DataGridView billdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}