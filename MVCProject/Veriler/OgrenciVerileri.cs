using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Veriler
{
    public class OgrenciVerileri
    {
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci
            {
                Id = 1,
                Ad="Burcu",
                Soyad="Yeni",
                TcNo="11111111111",
                BolumAdi="Yazılım",
                KayitYili=2018,
                EpostaAdresi="burcu@okulumuz.com",
                DogumYeri="Kadıköy"


            },
             new Ogrenci
            {
                Id = 2,
                Ad="Sevda",
                Soyad="Masal",
                TcNo="11111111112",
                BolumAdi="Yazılım",
                KayitYili=2019,
                EpostaAdresi="sevda@okulumuz.com",
                DogumYeri="Maltepe"


            },
              new Ogrenci
            {
                Id = 3,
                Ad="Ali",
                Soyad="Derya",
                TcNo="11111111113",
                BolumAdi="Yazılım",
                KayitYili=2018,
                EpostaAdresi="ali@okulumuz.com",
                DogumYeri="Şişli"


            }

        };
    }
}