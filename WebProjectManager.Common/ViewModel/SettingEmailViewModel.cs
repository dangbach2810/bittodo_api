using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectManager.Common.ViewModel
{
    public class SettingEmailViewModel
    {
        public bool? SendEmail { set; get; }
        public bool? SendDaily { set; get; }
        public bool? SendWeekly { set; get; }
        public bool? SendMonthly { set; get; }
        public bool? SendYearly { set; get; }

    }
}
