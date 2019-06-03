namespace stock
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprocode = new System.Windows.Forms.TextBox();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.cmbprostatus = new System.Windows.Forms.ComboBox();
            this.btnaddpro = new System.Windows.Forms.Button();
            this.btndeletepro = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // txtprocode
            // 
            this.txtprocode.Location = new System.Drawing.Point(15, 60);
            this.txtprocode.Name = "txtprocode";
            this.txtprocode.ReadOnly = true;
            this.txtprocode.Size = new System.Drawing.Size(135, 20);
            this.txtprocode.TabIndex = 1;
            // 
            // txtproname
            // 
            this.txtproname.Location = new System.Drawing.Point(158, 60);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(135, 20);
            this.txtproname.TabIndex = 2;
            // 
            // cmbprostatus
            // 
            this.cmbprostatus.FormattingEnabled = true;
            this.cmbprostatus.Items.AddRange(new object[] {
            "Deactive",
            "Active"});
            this.cmbprostatus.Location = new System.Drawing.Point(299, 60);
            this.cmbprostatus.Name = "cmbprostatus";
            this.cmbprostatus.Size = new System.Drawing.Size(135, 21);
            this.cmbprostatus.TabIndex = 3;
            // 
            // btnaddpro
            // 
            this.btnaddpro.Location = new System.Drawing.Point(441, 60);
            this.btnaddpro.Name = "btnaddpro";
            this.btnaddpro.Size = new System.Drawing.Size(75, 23);
            this.btnaddpro.TabIndex = 4;
            this.btnaddpro.Text = "Add";
            this.btnaddpro.UseVisualStyleBackColor = true;
            this.btnaddpro.Click += new System.EventHandler(this.btnaddpro_Click);
            // 
            // btndeletepro
            // 
            this.btndeletepro.Location = new System.Drawing.Point(522, 60);
            this.btndeletepro.Name = "btndeletepro";
            this.btndeletepro.Size = new System.Drawing.Size(75, 23);
            this.btndeletepro.TabIndex = 5;
            this.btndeletepro.Text = "Delete";
            this.btndeletepro.UseVisualStyleBackColor = true;
            this.btndeletepro.Click += new System.EventHandler(this.btndeletepro_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridView.Location = new System.Drawing.Point(12, 86);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(582, 201);
            this.DataGridView.TabIndex = 6;
            this.DataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(441, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(153, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 300);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btndeletepro);
            this.Controls.Add(this.btnaddpro);
            this.Controls.Add(this.cmbprostatus);
            this.Controls.Add(this.txtproname);
            this.Controls.Add(this.txtprocode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprocode;
        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.ComboBox cmbprostatus;
        private System.Windows.Forms.Button btnaddpro;
        private System.Windows.Forms.Button btndeletepro;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnNew;
    }
}