using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyChat.Models
{
    [MetadataType(typeof(tblSohbetler.Metadata))]
    public partial class tblSohbetler
    {
        sealed class Metadata
        {
            [Key]
            public int sohbetID { get; set; }
            [Display(Name="Sohbet Adı")]
            public int sohbetAdi { get; set; }

            [Display(Name="Sohbet Üyeleri")]
            public int sohbetUyeListesiID { get; set; }
            [Display(Name="Sohbet Oluşturulma Tarihi")]
            public System.DateTime sohbetOlusturulmaTarihi { get; set; }

            [Display(Name="Sohbet Tipi")]
            public int sohbetTipID { get; set; }
        }

    }
}