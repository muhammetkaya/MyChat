//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyChat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMesajlar
    {
        public int mesajID { get; set; }
        public string mesajMetni { get; set; }
        public int gonderenID { get; set; }
        public int sohbetID { get; set; }
        public System.DateTime gonderilmeTarihi { get; set; }
    }
}