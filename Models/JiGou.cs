using System;

namespace Models
{
    public class JiGou
    {
        public int 机构编号 { get; set; }
        public string 机构名称 { get; set; }
        public string 机构简称 { get; set; }
        public DateTime 开始日期 { get; set; }
        public DateTime 结束日期 { get; set; }
        public string 成立日期 { get; set; }
        public string 成立文号 { get; set; }
        public string 内设机构层级 { get; set; }
        public bool 是否虚拟组织 { get; set; }
        public bool 是否挂靠组织 { get; set; }
        public string 备注 { get; set; }
        public int ParentID { get; set; }
        public int 排序 { get; set; }
        public string 更改者 { get; set; }
        public DateTime 更改日期 { get; set; }

        public int id { get; set; }
        public string DT { get; set; }
        public string 机构类型长文本 { get; set; }

    }
}
