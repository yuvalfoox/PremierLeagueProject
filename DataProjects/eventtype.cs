//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class eventtype
    {
        public eventtype()
        {
            this.matchevent = new HashSet<matchevent>();
        }
    
        public int EventTypeID { get; set; }
        public string EventName { get; set; }
    
        public virtual ICollection<matchevent> matchevent { get; set; }
    }
}
