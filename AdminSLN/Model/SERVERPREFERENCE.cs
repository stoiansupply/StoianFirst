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
    
    public partial class SERVERPREFERENCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVERPREFERENCE()
        {
            this.USERSERVERPREFERENCES = new HashSet<USERSERVERPREFERENCE>();
        }
    
        public string SERVERNAME { get; set; }
        public string COMPUTERNAME { get; set; }
        public int PORT { get; set; }
        public bool SECURE { get; set; }
        public int SERVERVERSION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERSERVERPREFERENCE> USERSERVERPREFERENCES { get; set; }
    }
}