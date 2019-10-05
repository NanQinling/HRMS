using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ZuZhiFenPei
    {
        public int id { get; set; }
        public string 人员编号 { get; set; }
        public DateTime 开始日期 { get; set; }
        public DateTime 结束日期 { get; set; }
        public string 人事范围 { get; set; }
        public string 人事子范围 { get; set; }
        public string 员工组 { get; set; }
        public string 员工子组 { get; set; }
        public string 工资范围 { get; set; }
        public int 职位编码 { get; set; }
        public string 备注 { get; set; }
        public string 更改者 { get; set; }
        public DateTime 更改日期 { get; set; }

        public string 姓名 { get; set; }
        public string EG { get; set; }
        public string 员工子组的名称 { get; set; }

        public string 职位名称 { get; set; }
        public string 二级内设机构 { get; set; }
        public string 三级内设机构 { get; set; }
        public string 内设机构层级 { get; set; }


    }
}
