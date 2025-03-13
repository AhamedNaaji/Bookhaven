namespace Bookhaven
{
    partial class view_stock
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
            this.btn_delete_stock = new System.Windows.Forms.Button();
            this.btn_update_stock = new System.Windows.Forms.Button();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_add_stock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_book = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete_stock
            // 
            this.btn_delete_stock.Location = new System.Drawing.Point(468, 503);
            this.btn_delete_stock.Name = "btn_delete_stock";
            this.btn_delete_stock.Size = new System.Drawing.Size(126, 45);
            this.btn_delete_stock.TabIndex = 18;
            this.btn_delete_stock.Text = "Delete ";
            this.btn_delete_stock.UseVisualStyleBackColor = true;
            // 
            // btn_update_stock
            // 
            this.btn_update_stock.Location = new System.Drawing.Point(250, 503);
            this.btn_update_stock.Name = "btn_update_stock";
            this.btn_update_stock.Size = new System.Drawing.Size(126, 45);
            this.btn_update_stock.TabIndex = 17;
            this.btn_update_stock.Text = "Update ";
            this.btn_update_stock.UseVisualStyleBackColor = true;
            this.btn_update_stock.Click += new System.EventHandler(this.btn_update_stock_Click);
            // 
            // dgv_stock
            // 
            this.dgv_stock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(58, 156);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowTemplate.Height = 24;
            this.dgv_stock.Size = new System.Drawing.Size(571, 293);
            this.dgv_stock.TabIndex = 16;
            this.dgv_stock.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellContentDoubleClick);
            // 
            // btn_add_stock
            // 
            this.btn_add_stock.Location = new System.Drawing.Point(58, 503);
            this.btn_add_stock.Name = "btn_add_stock";
            this.btn_add_stock.Size = new System.Drawing.Size(126, 45);
            this.btn_add_stock.TabIndex = 15;
            this.btn_add_stock.Text = "Add ";
            this.btn_add_stock.UseVisualStyleBackColor = true;
            this.btn_add_stock.Click += new System.EventHandler(this.btn_add_stock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stock";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(239, 66);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(187, 45);
            this.txt_quantity.TabIndex = 13;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(468, 66);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(187, 45);
            this.txt_price.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price";
            // 
            // cmb_book
            // 
            this.cmb_book.FormattingEnabled = true;
            this.cmb_book.Location = new System.Drawing.Point(45, 76);
            this.cmb_book.Name = "cmb_book";
            this.cmb_book.Size = new System.Drawing.Size(139, 24);
            this.cmb_book.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Books";
            // 
            // view_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_book);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn_delete_stock);
            this.Controls.Add(this.btn_update_stock);
            this.Controls.Add(this.dgv_stock);
            this.Controls.Add(this.btn_add_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Name = "view_stock";
            this.Text = "view_stock";
            this.Load += new System.EventHandler(this.view_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_stock;
        private System.Windows.Forms.Button btn_update_stock;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_add_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_book;
        private System.Windows.Forms.Label label3;
    }
}