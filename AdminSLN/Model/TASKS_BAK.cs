//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TASKS_BAK
    {
        public string TASKID { get; set; }
        public string PROCESSNAME { get; set; }
        public Nullable<int> PROCESSVERSION { get; set; }
        public Nullable<int> INCIDENT { get; set; }
        public string STEPID { get; set; }
        public string STEPLABEL { get; set; }
        public string RECIPIENT { get; set; }
        public Nullable<int> RECIPIENTTYPE { get; set; }
        public string TASKUSER { get; set; }
        public string ASSIGNEDTOUSER { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> SUBSTATUS { get; set; }
        public Nullable<System.DateTime> STARTTIME { get; set; }
        public Nullable<System.DateTime> ENDTIME { get; set; }
        public Nullable<System.DateTime> QSTARTTIME { get; set; }
        public Nullable<System.DateTime> QENDTIME { get; set; }
        public Nullable<System.DateTime> DELAYTIME { get; set; }
        public Nullable<System.DateTime> OVERDUETIME { get; set; }
        public Nullable<System.DateTime> URGENTDUETIME { get; set; }
        public Nullable<double> TASKRATE { get; set; }
        public Nullable<int> TASKTIME { get; set; }
        public Nullable<double> COST { get; set; }
        public string HELPURL { get; set; }
        public string REFERER { get; set; }
        public byte[] LOCALSS { get; set; }
        public string ORGANIZATION { get; set; }
        public string SCHEMADATA { get; set; }
        public string CHECKOUTUSER { get; set; }
        public int ARCHIVED { get; set; }
    }
}
