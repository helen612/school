using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tables
{
    class Person
    {
        public int id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public string Position { get; set; }
        public string SecretWord { get; set; }
        public string Avatar { get; set; }

        public Person()
        {
            id = -1;
            LastName = "";
            Name = "";
            FatherName = "";
            Sex = "";
            Birthday = DateTime.Now;
            Number = "";
            Mail = "";
            Position = "";
            SecretWord = "";
            Avatar = "";
        }

        public Person(int id, string ln, string name, string fn, string s, DateTime brth, string num, string mail, string pos, string sw, string ava)
        {
            this.id = id;
            this.LastName = ln;
            this.Name = name;
            this.FatherName = fn;
            this.Sex = s;
            this.Birthday = brth;
            this.Number = num;
            this.Mail = mail;
            this.Position = pos;
            this.SecretWord = sw;
            this.Avatar = ava;
        }
    }
}
