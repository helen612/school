using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tables
{
    class Parents : Person
    {
        public string username { set; get; }
        public string password { set; get; }

        public string work { set; get; }

        public Parents() : base()
        {
            this.username = "";
            this.password = "";
            this.work = "";
        }
        public Parents(int id, string ln, string name, string fn, string s, DateTime brth, string num, string mail, string pos, string sw, string ava,
           string username, string password, string work) : base(id, ln, name, fn, s, brth, num, mail, pos, sw, ava)
        {
            this.username = username;
            this.password = password;
            this.work = work;
        }
    }
}
