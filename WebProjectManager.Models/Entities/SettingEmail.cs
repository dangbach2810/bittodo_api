using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectManager.Models.Entities
{
    public partial class SettingEmail
    {
        public Guid Id { set; get; }
        public Guid UserId { set; get; }
        public bool? SendEmail { set; get; }
        public bool? SendDaily { set; get; }
        public bool? SendWeekly { set; get; }
        public bool? SendMonthly { set; get; }
        public bool? SendYearly { set; get; }
        public virtual User? SettingEmailNavigation { get; set; }
    }
}
