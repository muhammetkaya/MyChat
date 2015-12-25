using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyChat.Models
{
    [MetadataType(typeof(tblSohbetListeleri.Metadata))]
    public partial class tblSohbetListeleri
    {
        sealed class Metadata
        {
            [Key]
            public int sohbetUyeListesiID { get; set; }
            [Display(Name="Kullanici ID")]
            public int kullanıcıID { get; set; }

            [Display(Name="Kullanıcının sohbete girme tarihi")]
            public System.DateTime dahilOlmaTarihi { get; set; }

        }
    }
}