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
    
    public partial class INCIDENT
    {
        public string PROCESSNAME { get; set; }
        public Nullable<int> PROCESSVERSION { get; set; }
        public int INCIDENT1 { get; set; }
        public Nullable<int> PRIORITY { get; set; }
        public string SUMMARY { get; set; }
        public Nullable<System.DateTime> STARTTIME { get; set; }
        public Nullable<System.DateTime> ENDTIME { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string INITIATOR { get; set; }
        public Nullable<System.DateTime> TIMELIMIT { get; set; }
        public string HELPURL { get; set; }
        public byte[] MAINSS { get; set; }
        public string REFERER { get; set; }
        public string SCHEMADATA { get; set; }
        public Nullable<int> MAPVERSION { get; set; }
        public Nullable<bool> DISABLEABORT { get; set; }
        public int ARCHIVED { get; set; }
    }
}
