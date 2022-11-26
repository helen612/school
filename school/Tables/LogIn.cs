using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tables
{
    class LogIn
    {
        public int id { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public int lvl { set; get; }
        public LogIn()
        {
            id = -1;
            username = "";
            password = "";
            lvl = 0;
        }
        public LogIn(int id, string username, string password, int lvl)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.lvl = lvl;
        }
    }
}
