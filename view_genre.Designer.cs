namespace Bookhaven
{
    partial class view_genre
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
            this.txtbox_genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_genre = new System.Windows.Forms.Button();
            this.dgv_genre = new System.Windows.Forms.DataGridView();
            this.btn_update_genre = new System.Windows.Forms.Button();
            this.btn_delete_genre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_genre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_genre
            // 
            this.txtbox_genre.Location = new System.Drawing.Point(37, 112);
            this.txtbox_genre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbox_genre.Multiline = true;
            this.txtbox_genre.Name = "txtbox_genre";
            this.txtbox_genre.Size = new System.Drawing.Size(925, 55);
            this.txtbox_genre.TabIndex = 0;
            this.txtbox_genre.TextChanged += new System.EventHandler(this.txtbox_genre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // btn_add_genre
            // 
            this.btn_add_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_genre.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_genre.Location = new System.Drawing.Point(1128, 112);
            this.btn_add_genre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_add_genre.Name = "btn_add_genre";
            this.btn_add_genre.Size = new System.Drawing.Size(205, 56);
            this.btn_add_genre.TabIndex = 3;
            this.btn_add_genre.Text = "Add Genre";
            this.btn_add_genre.UseVisualStyleBackColor = false;
            this.btn_add_genre.Click += new System.EventHandler(this.btn_add_genre_Click);
            // 
            // dgv_genre
            // 
            this.dgv_genre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_genre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_genre.Location = new System.Drawing.Point(37, 231);
            this.dgv_genre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_genre.Name = "dgv_genre";
            this.dgv_genre.ReadOnly = true;
            this.dgv_genre.RowHeadersWidth = 51;
            this.dgv_genre.RowTemplate.Height = 24;
            this.dgv_genre.Size = new System.Drawing.Size(928, 366);
            this.dgv_genre.TabIndex = 4;
            this.dgv_genre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_genre_CellContentClick);
            this.dgv_genre.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_genre_CellContentDoubleClick);
            // 
            // btn_update_genre
            // 
            this.btn_update_genre.BackColor = System.Drawing.Color.Aqua;
            this.btn_update_genre.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_genre.Location = new System.Drawing.Point(1128, 329);
            this.btn_update_genre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update_genre.Name = "btn_update_genre";
            this.btn_update_genre.Size = new System.Drawing.Size(205, 56);
            this.btn_update_genre.TabIndex = 5;
            this.btn_update_genre.Text = "Update Genre";
            this.btn_update_genre.UseVisualStyleBackColor = false;
            this.btn_update_genre.Click += new System.EventHandler(this.btn_update_genre_Click);
            // 
            // btn_delete_genre
            // 
            this.btn_delete_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete_genre.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete_genre.Location = new System.Drawing.Point(1128, 541);
            this.btn_delete_genre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_delete_genre.Name = "btn_delete_genre";
            this.btn_delete_genre.Size = new System.Drawing.Size(205, 56);
            this.btn_delete_genre.TabIndex = 6;
            this.btn_delete_genre.Text = "Delete Genre";
            this.btn_delete_genre.UseVisualStyleBackColor = false;
            this.btn_delete_genre.Click += new System.EventHandler(this.btn_delete_genre_Click);
            // 
            // view_genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 615);
            this.Controls.Add(this.btn_delete_genre);
            this.Controls.Add(this.btn_update_genre);
            this.Controls.Add(this.dgv_genre);
            this.Controls.Add(this.btn_add_genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_genre);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "view_genre";
            this.Text = "view_genre";
            this.Load += new System.EventHandler(this.view_genre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_genre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_genre;
        private System.Windows.Forms.DataGridView dgv_genre;
        private System.Windows.Forms.Button btn_update_genre;
        private System.Windows.Forms.Button btn_delete_genre;
    }
}