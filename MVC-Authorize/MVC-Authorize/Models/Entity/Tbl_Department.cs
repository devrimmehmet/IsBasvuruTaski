//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Authorize.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Tbl_Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Tbl_Department()
        {
            this.Tbl_Employee = new HashSet<Tbl_Employee>();
        }
        [DisplayName("Departman")]
        public int Id { get; set; }
        [DisplayName("Departman")]
        public string DepartmentName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Employee> Tbl_Employee { get; set; }
    }
}
