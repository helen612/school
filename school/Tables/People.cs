using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tables
{
    class People
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string nameClass { get; set; }
        public int idClass { get; set; }
        public string address { get; set; }
        public bool starosta { get; set; }
        public bool SOP { get; set; }
        
        public People()
        {
            id = -1;
            address = "";
            starosta = false;
            SOP = false;
            nameClass = "";
            Name = "";
            LastName = "";
            FatherName = "";
            idClass = -1;
        }
        public People(int id, string adr, bool sts, bool SOP, string nameClass, string name, string LastName, string FatherName, int idclass)
        {
            this.id = id;
            this.address = adr;
            this.starosta = sts;
            this.SOP = SOP;
            this.nameClass = nameClass;
            this.Name = name;
            this.LastName = LastName;
            this.FatherName = FatherName;
            this.idClass = idclass;
        }
    }
}
