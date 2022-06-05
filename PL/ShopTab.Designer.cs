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
            System.Windows.Forms.Label labelOrderBy;
            ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxSearchByName;
            System.Windows.Forms.Label labelFilters;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            labelOrderBy = new System.Windows.Forms.Label();
            textBoxSearchByName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            labelFilters = new System.Windows.Forms.Label();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrderBy
            // 
            labelOrderBy.AutoSize = true;
            labelOrderBy.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOrderBy.ForeColor = System.Drawing.Color.White;
            labelOrderBy.Location = new System.Drawing.Point(19, 50);
            labelOrderBy.Name = "labelOrderBy";
            labelOrderBy.Size = new System.Drawing.Size(99, 34);
            labelOrderBy.TabIndex = 2;
            labelOrderBy.Text = "Order By";
            // 
            // textBoxSearchByName
            // 
            textBoxSearchByName.Location = new System.Drawing.Point(25, 87);
            textBoxSearchByName.Name = "textBoxSearchByName";
            textBoxSearchByName.Size = new System.Drawing.Size(249, 31);
            textBoxSearchByName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            textBoxSearchByName.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            textBoxSearchByName.StateCommon.Border.Rounding = 10;
            textBoxSearchByName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxSearchByName.TabIndex = 1;
            // 
            // labelFilters
            // 
            labelFilters.AutoSize = true;
            labelFilters.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFilters.ForeColor = System.Drawing.Color.White;
            labelFilters.Location = new System.Drawing.Point(18, 0);
            labelFilters.Name = "labelFilters";
            labelFilters.Size = new System.Drawing.Size(80, 37);
            labelFilters.TabIndex = 0;
            labelFilters.Text = "Filters";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1015, 634);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(textBoxSearchByName);
            this.panelFilter.Controls.Add(labelFilters);
            this.panelFilter.Controls.Add(labelOrderBy);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFilter.Location = new System.Drawing.Point(1021, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(308, 634);
            this.panelFilter.TabIndex = 1;
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
            this.Load += new System.EventHandler(this.ShopTab_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelFilter;
    }
}