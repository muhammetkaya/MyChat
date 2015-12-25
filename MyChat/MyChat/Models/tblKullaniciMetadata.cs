using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyChat.Models
{
    [MetadataType(typeof(tblKullanici.Metadata))]
    public partial class tblKullanici
    {
        sealed class Metadata
        {
            [Key]
            public int kullanıcıID { get; set; }

            [Required(ErrorMessage="Kullanici adı alani boş geçilemez!")]
            [Display(Name="Kullanıcı Adı")]
            [StringLength(50)]
            public string kullanıcıAdi { get; set; }
            
            [Required(ErrorMessage="Kullanıcı e-posta alanı boş geçilemez!")]
            [Display(Name="E-Posta")]
            [StringLength(50)]
            public string kullaniciEposta { get; set; }
            [Required(ErrorMessage="Kullanıcı şifre kısmı boş geçilemez!")]
            [Display(Name="Şifre")]
            [StringLength(15)]
            public string kullaniciSifre { get; set; }
                       
            [Display(Name="Son giriş tarihi")]
            public System.DateTime kullaniciSonGirisTarihi { get; set; }
        }
    }
}