using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeLogerExtractor.DataAccess.DataAccess;

namespace ConsoleApplication1
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }
        public FormTable(List<Annonce> list)
        {
            InitializeComponent();

            this.annonceBindingSource.DataSource = list;
        }
    }
}
