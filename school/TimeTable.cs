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
    public partial class TimeTable : Form
    {
        private int mode;
        //private List<string> days
        public TimeTable(int mode)
        {
            this.mode = mode;
            InitializeComponent();
            workWithDB w = new workWithDB();

        }
    }
}
