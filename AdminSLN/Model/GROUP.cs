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
    
    public partial class GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GROUP()
        {
            this.MEMBERS = new HashSet<MEMBER>();
        }
    
        public int GID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> INUSE { get; set; }
        public string ACCESSGRP { get; set; }
        public Nullable<int> ORGID { get; set; }
        public Nullable<int> ISWEIGHTED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEMBER> MEMBERS { get; set; }
    }
}
