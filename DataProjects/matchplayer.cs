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
    
    public partial class matchplayer
    {
        public int MatchPlayerID { get; set; }
        public int MatchID { get; set; }
        public int TeamID { get; set; }
        public int PlayerID { get; set; }
        public Nullable<int> SubstituteMinute { get; set; }
    
        public virtual competitionmatch competitionmatch { get; set; }
        public virtual player player { get; set; }
        public virtual team team { get; set; }
    }
}
