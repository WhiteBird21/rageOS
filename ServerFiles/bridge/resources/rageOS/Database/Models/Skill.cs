//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RageOS.Database.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public Nullable<SkillTypes> SkillType { get; set; }
        public Nullable<bool> SkillLearned { get; set; }
        public int SkillLevel { get; set; }
    
        public virtual Character characters { get; set; }
    }
}
