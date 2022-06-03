using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class ArticleDetails : Form
    {
        public ArticleDetails(string articleName)
        {
            InitializeComponent();
            this.label1.Text = articleName;
        }
    }
}
