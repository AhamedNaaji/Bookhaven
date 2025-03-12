namespace Bookhaven
{
    partial class view_author
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
            this.btn_delete_author = new System.Windows.Forms.Button();
            this.btn_update_author = new System.Windows.Forms.Button();
            this.dgv_author = new System.Windows.Forms.DataGridView();
            this.btn_add_author = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_author = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_author)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete_author
            // 
            this.btn_delete_author.Location = new System.Drawing.Point(442, 506);
            this.btn_delete_author.Name = "btn_delete_author";
            this.btn_delete_author.Size = new System.Drawing.Size(126, 45);
            this.btn_delete_author.TabIndex = 12;
            this.btn_delete_author.Text = "Delete ";
            this.btn_delete_author.UseVisualStyleBackColor = true;
            this.btn_delete_author.Click += new System.EventHandler(this.btn_delete_author_Click);
            // 
            // btn_update_author
            // 
            this.btn_update_author.Location = new System.Drawing.Point(224, 506);
            this.btn_update_author.Name = "btn_update_author";
            this.btn_update_author.Size = new System.Drawing.Size(126, 45);
            this.btn_update_author.TabIndex = 11;
            this.btn_update_author.Text = "Update ";
            this.btn_update_author.UseVisualStyleBackColor = true;
            this.btn_update_author.Click += new System.EventHandler(this.btn_update_author_Click);
            // 
            // dgv_author
            // 
            this.dgv_author.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_author.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_author.Location = new System.Drawing.Point(32, 164);
            this.dgv_author.Name = "dgv_author";
            this.dgv_author.RowHeadersWidth = 51;
            this.dgv_author.RowTemplate.Height = 24;
            this.dgv_author.Size = new System.Drawing.Size(571, 293);
            this.dgv_author.TabIndex = 10;
            this.dgv_author.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_author_CellContentDoubleClick);
            // 
            // btn_add_author
            // 
            this.btn_add_author.Location = new System.Drawing.Point(32, 506);
            this.btn_add_author.Name = "btn_add_author";
            this.btn_add_author.Size = new System.Drawing.Size(126, 45);
            this.btn_add_author.TabIndex = 9;
            this.btn_add_author.Text = "Add ";
            this.btn_add_author.UseVisualStyleBackColor = true;
            this.btn_add_author.Click += new System.EventHandler(this.btn_add_author_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author_Name";
            // 
            // txtbox_author
            // 
            this.txtbox_author.Location = new System.Drawing.Point(32, 69);
            this.txtbox_author.Multiline = true;
            this.txtbox_author.Name = "txtbox_author";
            this.txtbox_author.Size = new System.Drawing.Size(331, 45);
            this.txtbox_author.TabIndex = 7;
            this.txtbox_author.TextChanged += new System.EventHandler(this.txtbox_author_TextChanged);
            // 
            // view_author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 576);
            this.Controls.Add(this.btn_delete_author);
            this.Controls.Add(this.btn_update_author);
            this.Controls.Add(this.dgv_author);
            this.Controls.Add(this.btn_add_author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_author);
            this.Name = "view_author";
            this.Text = "view_author";
            this.Load += new System.EventHandler(this.view_author_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_author;
        private System.Windows.Forms.Button btn_update_author;
        private System.Windows.Forms.DataGridView dgv_author;
        private System.Windows.Forms.Button btn_add_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_author;
    }
}