//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int id_activity { get; set; }
        public Nullable<int> seq_no { get; set; }
        public string description { get; set; }
        public string result { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> date_request { get; set; }
        public Nullable<System.DateTime> date_fin_cancel { get; set; }
        public Nullable<int> id_request { get; set; }
        public string act_type { get; set; }
        public Nullable<int> id_personel { get; set; }
    
        public virtual Act_dict Act_dict { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Request Request { get; set; }
    }
}
