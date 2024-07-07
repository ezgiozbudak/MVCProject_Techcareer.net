using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace MVCProject.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [DisplayName("TC Kimlik No")]
        [MinLength(11, ErrorMessage= "TC Kimlik Numarası 11 karakterden küçük olmamalıdır")]
        [MaxLength(11, ErrorMessage= "TC Kimlik Numarası 11 karakterden büyük olmamalıdır")]
        public string TcNo { get; set; }
        public string BolumAdi { get; set; }
        public int KayitYili { get; set; }
        
        public string EpostaAdresi { get; set;}
        public string DogumYeri {  get; set; }
        /*[DisplayName("Şifrenizi Tekrar Girin")]
        [DataType(DataType.Password)]
        [Compare("sifre")]
        public string kontrolsifre { get; set; }*/


    }
}