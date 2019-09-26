using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class GangWei
    {
        public int 职位编码 { get; set; }
        public string 职位名称 { get; set; }
        public string 职位简称 { get; set; }
        public DateTime 开始日期 { get; set; }
        public DateTime 结束日期 { get; set; }
        public string 岗位性质 { get; set; }
        public string 岗位序列 { get; set; }
        public string 岗级 { get; set; }
        public bool 是否特殊岗位 { get; set; }
        public bool 是否关键岗位 { get; set; }
        public bool 是否运行岗位 { get; set; }
        public bool 是否虚拟岗位 { get; set; }
        public string 备注 { get; set; }
        public int ParentID { get; set; }
        public int 排序 { get; set; }
        public string 更改者 { get; set; }
        public DateTime 更改日期 { get; set; }


        public int id { get; set; }
        public string dt { get; set; }
        public string 岗位性质长文本 { get; set; }








    }
}
