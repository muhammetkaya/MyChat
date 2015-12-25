using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyChat.Models
{
    [MetadataType(typeof(tblSohbetTipleri.Metadata))]
    public partial class tblSohbetTipleri
    {
        sealed class Metadata
        {
            [Key]
            public int sohbetTipID { get; set; }
            [Display(Name="Sohbet tipi")]
            public string Tip { get; set; }
        }

    }
}