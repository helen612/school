using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tables
{
    class Employer : Person
    {
        public string username { set; get; }
        public string password { set; get; }

        public int idclass { set; get; }
        public bool profs { set; get; }
        public DateTime dateOfEmpl { set; get; }
        public Employer(int id, string ln, string name, string fn, string s, DateTime brth, string num, string mail, string pos, string sw, string ava,
            int idclass, bool profs, DateTime dateOfEmpl, string username, string password) : base(id, ln, name, fn, s, brth, num, mail, pos, sw, ava)
        {
            this.idclass = idclass;
            this.profs = profs;
            this.dateOfEmpl = dateOfEmpl;
            this.username = username;
            this.password = password;
        }
        public Employer () : base()
        {
            this.idclass = -1;
            this.profs = false;
            this.dateOfEmpl = DateTime.Now;
            this.username = "";
            this.password = "";
        }
    }
}
