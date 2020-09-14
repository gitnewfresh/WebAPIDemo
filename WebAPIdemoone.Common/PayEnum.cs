using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIdemoone.Common
{
    /// <summary>
    /// 费用项枚举
    /// </summary>
    public enum PayEnum
    {
        [Description("学费")]
        Tuition=1,

        [Description("住宿费")]
        Accommodationfee=2,

        [Description("饭卡费")]
         MealCard =3,

        [Description("水电费")]
        UtilityBill=4





    }
}
