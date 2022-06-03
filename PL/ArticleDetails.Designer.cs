namespace PL
{
    partial class ArticleDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLINGPRICEEXCLVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOPADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOPPOSTALCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOPCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOPCOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 169);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUCTDataGridViewTextBoxColumn,
            this.iDSHOPDataGridViewTextBoxColumn,
            this.sHOPNAMEDataGridViewTextBoxColumn,
            this.sTOCKQUANTITYDataGridViewTextBoxColumn,
            this.sELLINGPRICEEXCLVATDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRODUCTTYPEDataGridViewTextBoxColumn,
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn,
            this.sHOPADDRESSDataGridViewTextBoxColumn,
            this.sHOPPOSTALCODEDataGridViewTextBoxColumn,
            this.sHOPCITYDataGridViewTextBoxColumn,
            this.sHOPCOUNTRYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 507);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDPRODUCTDataGridViewTextBoxColumn
            // 
            this.iDPRODUCTDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCT";
            this.iDPRODUCTDataGridViewTextBoxColumn.HeaderText = "ID_PRODUCT";
            this.iDPRODUCTDataGridViewTextBoxColumn.Name = "iDPRODUCTDataGridViewTextBoxColumn";
            // 
            // iDSHOPDataGridViewTextBoxColumn
            // 
            this.iDSHOPDataGridViewTextBoxColumn.DataPropertyName = "ID_SHOP";
            this.iDSHOPDataGridViewTextBoxColumn.HeaderText = "ID_SHOP";
            this.iDSHOPDataGridViewTextBoxColumn.Name = "iDSHOPDataGridViewTextBoxColumn";
            // 
            // sHOPNAMEDataGridViewTextBoxColumn
            // 
            this.sHOPNAMEDataGridViewTextBoxColumn.DataPropertyName = "SHOP_NAME";
            this.sHOPNAMEDataGridViewTextBoxColumn.HeaderText = "SHOP_NAME";
            this.sHOPNAMEDataGridViewTextBoxColumn.Name = "sHOPNAMEDataGridViewTextBoxColumn";
            // 
            // sTOCKQUANTITYDataGridViewTextBoxColumn
            // 
            this.sTOCKQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "STOCK_QUANTITY";
            this.sTOCKQUANTITYDataGridViewTextBoxColumn.HeaderText = "STOCK_QUANTITY";
            this.sTOCKQUANTITYDataGridViewTextBoxColumn.Name = "sTOCKQUANTITYDataGridViewTextBoxColumn";
            // 
            // sELLINGPRICEEXCLVATDataGridViewTextBoxColumn
            // 
            this.sELLINGPRICEEXCLVATDataGridViewTextBoxColumn.DataPropertyName = "SELLING_PRICE_EXCL_VAT";
            this.sELLINGPRICEEXCLVATDataGridViewTextBoxColumn.HeaderText = "SELLING_PRICE_EXCL_VAT";
            this.sELLINGPRICEEXCLVATDataGridViewTextBoxColumn.Name = "sELLINGPRICEEXCLVATDataGridViewTextBoxColumn";
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            // 
            // pRODUCTTYPEDataGridViewTextBoxColumn
            // 
            this.pRODUCTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_TYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_TYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.Name = "pRODUCTTYPEDataGridViewTextBoxColumn";
            // 
            // pRODUCTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_DESCRIPTION";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "PRODUCT_DESCRIPTION";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pRODUCTDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // sHOPADDRESSDataGridViewTextBoxColumn
            // 
            this.sHOPADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SHOP_ADDRESS";
            this.sHOPADDRESSDataGridViewTextBoxColumn.HeaderText = "SHOP_ADDRESS";
            this.sHOPADDRESSDataGridViewTextBoxColumn.Name = "sHOPADDRESSDataGridViewTextBoxColumn";
            // 
            // sHOPPOSTALCODEDataGridViewTextBoxColumn
            // 
            this.sHOPPOSTALCODEDataGridViewTextBoxColumn.DataPropertyName = "SHOP_POSTAL_CODE";
            this.sHOPPOSTALCODEDataGridViewTextBoxColumn.HeaderText = "SHOP_POSTAL_CODE";
            this.sHOPPOSTALCODEDataGridViewTextBoxColumn.Name = "sHOPPOSTALCODEDataGridViewTextBoxColumn";
            // 
            // sHOPCITYDataGridViewTextBoxColumn
            // 
            this.sHOPCITYDataGridViewTextBoxColumn.DataPropertyName = "SHOP_CITY";
            this.sHOPCITYDataGridViewTextBoxColumn.HeaderText = "SHOP_CITY";
            this.sHOPCITYDataGridViewTextBoxColumn.Name = "sHOPCITYDataGridViewTextBoxColumn";
            // 
            // sHOPCOUNTRYDataGridViewTextBoxColumn
            // 
            this.sHOPCOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "SHOP_COUNTRY";
            this.sHOPCOUNTRYDataGridViewTextBoxColumn.HeaderText = "SHOP_COUNTRY";
            this.sHOPCOUNTRYDataGridViewTextBoxColumn.Name = "sHOPCOUNTRYDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(DTO.Stock);
            // 
            // ArticleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ArticleDetails";
            this.Text = "ArticleDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHOPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sELLINGPRICEEXCLVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHOPADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHOPPOSTALCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHOPCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHOPCOUNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource;
    }
}