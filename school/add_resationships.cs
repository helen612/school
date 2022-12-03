using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class add_resationships : Form
    {
        public add_resationships()
        {
            InitializeComponent();
        }
        public add_resationships(int idParent, int idStudier)
        {
            InitializeComponent();
            tb_id_child.Texts = idStudier == -1 ? "" : idStudier.ToString();
            tb_id_parrent.Texts = idParent == -1 ? "" : idParent.ToString();
        }
    }
}
