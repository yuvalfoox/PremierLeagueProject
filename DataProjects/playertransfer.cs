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
    
    public partial class playertransfer
    {
        public int PlayerTransferID { get; set; }
        public int PlayerID { get; set; }
        public int DestinationTeamID { get; set; }
        public int SourceTeamID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual player player { get; set; }
        public virtual team team { get; set; }
        public virtual team team1 { get; set; }
    }
}
