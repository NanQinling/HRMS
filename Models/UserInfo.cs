using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class UserInfo
    {
        public string 人员编号 { get; set; }
        public string 姓名 { get; set; }
        public string 性别 { get; set; }
        public DateTime 出生日期 { get; set; }
        public string 身份证号 { get; set; }
        public DateTime 参加工作日期 { get; set; }
        public DateTime 加入华能系统日期 { get; set; }
        public DateTime 加入本单位日期 { get; set; }
        public string 入职原因 { get; set; }
        public string 入职学历 { get; set; }
        public string 工资标识 { get; set; }
        public string 工资账号 { get; set; }
        public string 奖金标识 { get; set; }
        public string 奖金账号 { get; set; }
        public string 备注 { get; set; }
        public string 拼音码 { get; set; }
        public string 更改者 { get; set; }
        public DateTime 更改日期 { get; set; }

        public string Actr { get; set; }
        public string 入职原因长文本 { get; set; }

        public string EE { get; set; }
        public string 入职学历长文本 { get; set; }

        public string 工资银行代码 { get; set; }
        public string 奖金银行代码 { get; set; }
        public string 工资银行名称 { get; set; }
        public string 奖金银行名称 { get; set; }



    }
}
