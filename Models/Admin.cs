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
        public bool Attendance { get; set; }
        public bool Overtime { get; set; }
        public bool Evaluation { get; set; }
        public bool Assessment { get; set; }
        //public DateTime time { get; set; }









    }
}
