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
    
    public partial class ULTVIEW
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ULTVIEW()
        {
            this.TRUSTEDUSERS = new HashSet<TRUSTEDUSER>();
        }
    
        public string ORGNAME { get; set; }
        public Nullable<int> VTYPE { get; set; }
        public byte[] VIEWINFO { get; set; }
        public string VIEWNAME { get; set; }
        public string VIEWID { get; set; }
        public string FRUID_USER { get; set; }
        public string FOLDERID { get; set; }
        public Nullable<int> FILTERMASK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUSTEDUSER> TRUSTEDUSERS { get; set; }
    }
}