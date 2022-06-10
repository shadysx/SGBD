namespace PL
{
    partial class ShopTab
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
            System.Windows.Forms.Label labelSearchBy;
            System.Windows.Forms.Label labelFilters;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.textBoxSearchByName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.comboBoxSearchByType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.comboBoxOrderBy = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            labelSearchBy = new System.Windows.Forms.Label();
            labelFilters = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSearchByType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOrderBy)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchBy
            // 
            labelSearchBy.AutoSize = true;
            labelSearchBy.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSearchBy.ForeColor = System.Drawing.Color.White;
            labelSearchBy.Location = new System.Drawing.Point(20, 50);
            labelSearchBy.Name = "labelSearchBy";
            labelSearchBy.Size = new System.Drawing.Size(98, 34);
            labelSearchBy.TabIndex = 2;
            labelSearchBy.Text = "Par nom";
            // 
            // labelFilters
            // 
            labelFilters.AutoSize = true;
            labelFilters.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFilters.ForeColor = System.Drawing.Color.White;
            labelFilters.Location = new System.Drawing.Point(18, 0);
            labelFilters.Name = "labelFilters";
            labelFilters.Size = new System.Drawing.Size(77, 37);
            labelFilters.TabIndex = 0;
            labelFilters.Text = "Filtrer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(19, 214);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 34);
            label1.TabIndex = 3;
            label1.Text = "Trier Par";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1355, 634);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.comboBoxOrderBy);
            this.panelFilter.Controls.Add(this.comboBoxSearchByType);
            this.panelFilter.Controls.Add(label2);
            this.panelFilter.Controls.Add(this.textBoxSearchByName);
            this.panelFilter.Controls.Add(this.rjButton1);
            this.panelFilter.Controls.Add(label1);
            this.panelFilter.Controls.Add(labelFilters);
            this.panelFilter.Controls.Add(labelSearchBy);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFilter.Location = new System.Drawing.Point(1021, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(308, 634);
            this.panelFilter.TabIndex = 1;
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.Location = new System.Drawing.Point(25, 87);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(187, 31);
            this.textBoxSearchByName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSearchByName.StateCommon.Border.Rounding = 12;
            this.textBoxSearchByName.TabIndex = 5;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 12;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(26, 301);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(133, 35);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Appliquer";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.filterButtonClick);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(19, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 34);
            label2.TabIndex = 6;
            label2.Text = "Par Type";
            // 
            // comboBoxSearchByType
            // 
            this.comboBoxSearchByType.DropDownWidth = 178;
            this.comboBoxSearchByType.Location = new System.Drawing.Point(26, 172);
            this.comboBoxSearchByType.Name = "comboBoxSearchByType";
            this.comboBoxSearchByType.Size = new System.Drawing.Size(186, 29);
            this.comboBoxSearchByType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxSearchByType.StateCommon.ComboBox.Border.Rounding = 12;
            this.comboBoxSearchByType.TabIndex = 7;
            this.comboBoxSearchByType.Text = "Tous";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.DropDownWidth = 178;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(26, 251);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(186, 29);
            this.comboBoxOrderBy.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxOrderBy.StateCommon.ComboBox.Border.Rounding = 12;
            this.comboBoxOrderBy.TabIndex = 8;
            this.comboBoxOrderBy.Text = "Aucun";
            // 
            // ShopTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 634);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ShopTab";
            this.Text = "ShopTab";
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSearchByType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOrderBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelFilter;
        private CustomControls.RJControls.RJButton rjButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxSearchByName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxSearchByType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxOrderBy;
    }
}