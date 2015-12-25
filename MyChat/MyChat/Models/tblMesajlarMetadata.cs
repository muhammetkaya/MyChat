using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyChat.Models
{
    [MetadataType(typeof(tblMesajlar.Metadata))]
    public partial class tblMesajlar
    {
        sealed class Metadata
        {
            [Key]
            public int mesajID { get; set; }
            [Display(Name="Mesaj")]
            public string mesajMetni { get; set; }
            [Display(Name = "Gönderici ID")]
            public int gonderenID { get; set; }
            [Display(Name="Mesajın ait olduğu sohbet ID")]
            public int sohbetID { get; set; }
            [Display(Name="Gönderilme Tarihi")]
            public System.DateTime gonderilmeTarihi { get; set; }
        }
    }
}