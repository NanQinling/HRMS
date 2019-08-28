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
        public DateTime 开始日期 { get; set; }
        public DateTime 结束日期 { get; set; }
        public string 备注 { get; set; }
        public string 更改者 { get; set; }
        public DateTime 更改日期 { get; set; }
        public int ParentID { get; set; }







    }
}
