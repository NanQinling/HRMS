using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Admin
    {
        public int id { get; set; }
        public int deptid { get; set; }
        public string dept { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public string pwd { get; set; }
        public Boolean Attendance { get; set; }
        public Boolean Overtime { get; set; }
        public Boolean Evaluation { get; set; }
        public Boolean Assessment { get; set; }
        //public DateTime time { get; set; }
        public int ParentID { get; set; }








    }
}
