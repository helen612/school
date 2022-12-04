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
    public partial class PostControl : Form
    {
        Dictionary<string, string> posts;
        private List<string> loadPosts()
        {
            workWithDB w = new workWithDB();
            posts = w.getPosts();
            
            return posts.Keys.ToList<string>();
        }
        public PostControl()
        {
            InitializeComponent();
            cb_choosePost.DataSource = loadPosts();
        }
        public PostControl(string id)
        {
            InitializeComponent();
            tb_id_emp.Texts = id;
            cb_choosePost.DataSource = loadPosts();
        }

        private void set_relationships_b_Click(object sender, EventArgs e)
        {
            string s = "";
            posts.TryGetValue(cb_choosePost.SelectedItem.ToString(), out s);
            workWithDB w = new workWithDB();
            if (w.addPost(tb_id_emp.Texts, s)) MessageBox.Show("Должность установлена!");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string s = "";
            posts.TryGetValue(cb_choosePost.SelectedItem.ToString(), out s);
            workWithDB w = new workWithDB();
            if (w.removePost(tb_id_emp.Texts, s)) MessageBox.Show("Должность удалена!");
        }

        private void tb_id_emp__TextChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if (tb_id_emp.Texts != "")
            {
                l_post_empl.Text = workWithDB.getFIOPerson(tb_id_emp.Texts);
            }
        }
    }
}
