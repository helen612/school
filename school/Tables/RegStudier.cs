using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tables
{
    class RegStudier : Person
    {
        public string username { set; get; }
        public string password { set; get; }

        public int idclass { set; get; }
        public string adress { set; get; }
        public bool starosta { set; get; }
        public bool SOP { set; get; }


        public RegStudier(int id, string ln, string name, string fn, string s, DateTime brth, string num, string mail, string pos, string sw, string ava,
            int idClass, string adress, bool starosta, bool SOP, string username, string password) :base(id,ln,name,fn,s,brth,num,mail,pos,sw,ava)
        {
            this.username = username;
            this.password = password;
            this.idclass = idclass;
            this.adress = adress;
            this.starosta = starosta;
            this.SOP = SOP;
        }
        public RegStudier() : base()
        {
            this.username = "";
            this.password = "";
            this.idclass = -1;
            this.adress = "";
            this.starosta = false;
            this.SOP = false;
        }

    }
}
