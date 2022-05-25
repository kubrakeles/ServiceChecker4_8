using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceChecker4_8.Models
{
    public class MernisResult
    {
        public string TCKimlikNo { get; set; } = "";
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";
        public string AnneAd { get; set; } = "";
        public string BabaAd { get; set; } = "";
        public string DogumTarihGun { get; set; } = "";
        public string DogumTarihAy { get; set; } = "";
        public string DogumTarihYil { get; set; } = "";
        public string DogumYer { get; set; } = "";
        public string Cinsiyet { get; set; } = "";
        public string Din { get; set; } = "";
        public string MedeniHal { get; set; } = "";
        public string OlumGun { get; set; } = "";
        public string OlumAy { get; set; } = "";
        public string OlumYil { get; set; } = "";
        public string Il { get; set; } = "";
        public string Ilce { get; set; } = "";
        public string AileSiraNo { get; set; } = "";
        public string BireySiraNo { get; set; } = "";
        public string Mahalle { get; set; } = "";
        public string Csbm { get; set; } = "";
        public string DisKapiNo { get; set; } = "";
        public string IcKapiNo { get; set; } = "";
        public string KatNo { get; set; } = "";

        public string AcikAdres { get; set; } = "";
        public string Koy { get; set; } = "";

        public string CuzdanVerilmeNeden { get; set; } = "";
        public int? CuzdanVerilmeNedenKod { get; set; } = -1;
        public string CuzdanVerilmeTarihYil { get; set; } = "";
        public string CuzdanVerilmeTarihAy { get; set; } = "";
        public string CuzdanVerilmeTarihGun { get; set; } = "";
        public string CuzdanSeriNo { get; set; } = "";
        public string CuzdanVerilenYer { get; set; } = "";
        public long? CuzdanKayitNo { get; set; } = -1;


        public string YurtDisiUlke { get; set; } = "";
        public string YurtDisiIl { get; set; } = "";
        public string YurtDisiAdres { get; set; } = "";

    }
}