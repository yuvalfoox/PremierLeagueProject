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
    
    public partial class competitionmatch
    {
        public competitionmatch()
        {
            this.matchevent = new HashSet<matchevent>();
            this.matchgoal = new HashSet<matchgoal>();
            this.matchplayer = new HashSet<matchplayer>();
        }
    
        public int CompetitionMatchID { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public Nullable<int> WinnerTeamID { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int CompetitionID { get; set; }
        public System.DateTime MatchDate { get; set; }
    
        public virtual competition competition { get; set; }
        public virtual team team { get; set; }
        public virtual team team1 { get; set; }
        public virtual team team2 { get; set; }
        public virtual ICollection<matchevent> matchevent { get; set; }
        public virtual ICollection<matchgoal> matchgoal { get; set; }
        public virtual ICollection<matchplayer> matchplayer { get; set; }
    }
}
