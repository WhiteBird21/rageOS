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
    
    public partial class Inventory
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public Nullable<InventoryType> Type { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
    
        public virtual Character characters { get; set; }
    }
}