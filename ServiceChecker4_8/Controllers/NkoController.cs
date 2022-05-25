using Mernis.Kps.Sample.WCF.Utilities;
using Microsoft.IdentityModel.Protocols.WSTrust;
using ServiceChecker4_8.NufusKayitOrnegi;
using ServiceChecker4_8.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ServiceChecker4_8.Controllers
{ 
    public class Nko_Parameters
    {
        protected int nkotur;
        public string sorgulananTC { get; set; }
        //doğum tarihi
        public string dogumAy { get; set; }
        public string dogumGun { get; set; }
        public string dogumYil { get; set; }
        public int NkoTur_ { 
            get { return nkotur; }
            set { nkotur = 2; }
        }
    }
    public class NkoController : ApiController
    {
        // GET: Nko
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "KURUM WEB SERVIS");
        }
        //Post  api/Nko
        public HttpResponseMessage Post([FromBody] Nko_Parameters parameters)
        {
            KPSConfiguration.Instance.Username = "KRM-6984181";
            KPSConfiguration.Instance.Password = "0147852";
            KPSConfiguration.Instance.EndPoint = "https://kpsv2.nvi.gov.tr/Services/RoutingService.svc";
            Result result = new Result();

            using (ChannelFactory<NkoSorgulaTCKimlikNoServis> channelFactory = new ChannelFactory<ServiceChecker4_8.NufusKayitOrnegi.NkoSorgulaTCKimlikNoServis>("CustomBinding_NkoSorgulaTCKimlikNoServis", new EndpointAddress(KPSConfiguration.Instance.EndPoint)))
            {
                channelFactory.Credentials.SupportInteractive = false;

                channelFactory.ConfigureChannelFactory();

                NkoSorgulaTCKimlikNoServis servis = channelFactory.CreateChannelWithIssuedToken(KPSServiceFactory.Instance.CreateToken(KPSConfiguration.Instance.Username));

                NkoTCKimlikNoSorguKriteri[] kriterListesi = new NkoTCKimlikNoSorguKriteri[2];
                kriterListesi[0] = new NkoTCKimlikNoSorguKriteri()
                {
                    TCKimlikNo = long.Parse(parameters.sorgulananTC),
                    DogumAy = int.Parse(parameters.dogumAy),
                    DogumGun = int.Parse(parameters.dogumGun),
                    DogumYil = int.Parse(parameters.dogumYil),
                    NKOTipi = NkoTur.AileKayitOrnek,
                    EskiEsListele = false,
                    Vukuatli = false


                };

                NkoSonucu sonuc = servis.Sorgula(kriterListesi);

                //    if (sonuc.HataBilgisi == null)
                //    { 
                //        if (sonuc.SorguSonucu.Length > 0)
                //        {
                //            if (sonuc.SorguSonucu[0].Kisiler != null)
                //            {
                //                if (sonuc.SorguSonucu[0].NkoTuru != null)
                //                {
                //                    if (sonuc.SorguSonucu[0].HataBilgisi == null)
                //                    {
                //                        result.TCKimlikNo = sonuc.SorguSonucu[0].? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TCKimlikNo.ToString() : "";
                //                        result.Ad = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.Ad;
                //                        result.Soyad = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.Soyad;
                //                        result.AnneAd = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.AnneAd;
                //                        result.BabaAd = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.BabaAd;
                //                        result.DogumTarihGun = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumTarih.Gun != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumTarih.Gun.ToString() : "--";
                //                        result.DogumTarihAy = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumTarih.Ay != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumTarih.Ay.ToString() : "--";
                //                        result.DogumTarihYil = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumTarih.Yil != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumTarih.Yil.ToString() : "--";
                //                        result.DogumYer = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.DogumYer;
                //                        result.Cinsiyet = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.Cinsiyet != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.TemelBilgisi.Cinsiyet.Aciklama.ToString() : "";
                //                    }
                //                    if (sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi != null)
                //                    {
                //                        result.Din = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.Din != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.Din.Aciklama.ToString() : "";
                //                        result.MedeniHal = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.MedeniHal != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.MedeniHal.Aciklama.ToString() : "";
                //                        result.OlumGun = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.OlumTarih.Gun != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.OlumTarih.Gun.ToString() : "";
                //                        result.OlumAy = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.OlumTarih.Ay != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.OlumTarih.Ay.ToString() : "";
                //                        result.OlumYil = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.OlumTarih.Yil != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.DurumBilgisi.OlumTarih.Yil.ToString() : "";
                //                    }

                //                    if (sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi != null)
                //                    {
                //                        result.Il = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.Il != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.Il.Aciklama.ToString() : "";
                //                        result.Ilce = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.Ilce != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.Ilce.Aciklama.ToString() : "";
                //                        result.AileSiraNo = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.AileSiraNo != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.AileSiraNo.ToString() : "";
                //                        result.BireySiraNo = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.BireySiraNo != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.BireySiraNo.ToString() : "";
                //                        result.Koy = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.Cilt != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.KayitYeriBilgisi.Cilt.Aciklama.ToString() : "";

                //                    }

                //                    if (sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi != null)
                //                    {
                //                        result.CuzdanVerilmeNeden = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.CuzdanVerilmeNeden != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.CuzdanVerilmeNeden.Aciklama : "";
                //                        result.CuzdanVerilmeNedenKod = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.CuzdanVerilmeNeden != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.CuzdanVerilmeNeden.Kod : -1;
                //                        result.CuzdanVerilenYer = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerildigiIlce != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerildigiIlce.Aciklama : "";
                //                        result.CuzdanVerilmeTarihGun = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerilmeTarih != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerilmeTarih.Gun.ToString() : "";
                //                        result.CuzdanVerilmeTarihAy = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerilmeTarih != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerilmeTarih.Ay.ToString() : "";
                //                        result.CuzdanVerilmeTarihYil = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerilmeTarih != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.VerilmeTarih.Yil.ToString() : "";
                //                        result.CuzdanKayitNo = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.CuzdanKayitNo != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.CuzdanKayitNo : -1;
                //                        result.CuzdanSeriNo = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.Seri != null ? sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.NufusCuzdaniBilgisi.Seri.ToString() : "";

                //                    }
                //                }
                //                else
                //                {
                //                    string hata = sonuc.SorguSonucu[0].TCVatandasiKisiKutukleri.KisiBilgisi.HataBilgisi.Aciklama;
                //                }
                //            }
                //        }
                //    }
                //    else
                //    {
                //        string hata = sonuc.HataBilgisi.Aciklama;
                //    }

                //    ChannelFactory<KimlikNoSorgulaAdresServis> channelFactoryAddress = new ChannelFactory<KimlikNoSorgulaAdresServis>("BindingTcKimlikNoSorgulaAdresServis", new EndpointAddress(KPSConfiguration.Instance.EndPoint));
                //    channelFactoryAddress.Credentials.SupportInteractive = false;
                //    channelFactoryAddress.ConfigureChannelFactory();
                //    KimlikNoSorgulaAdresServis servisAddress = channelFactoryAddress.CreateChannelWithIssuedToken(KPSServiceFactory.Instance.CreateToken(KPSConfiguration.Instance.Username));

                //    List<KimlikNoileAdresSorguKriteri> listAddress = new List<KimlikNoileAdresSorguKriteri>();
                //    listAddress.Add(new KimlikNoileAdresSorguKriteri()
                //    {
                //        KimlikNo = long.Parse(parameters.sorgulananTC),
                //        DogumAy = int.Parse(parameters.dogumAy),
                //        DogumGun = int.Parse(parameters.dogumGun),
                //        DogumYil = int.Parse(parameters.dogumYil)
                //    });

                //    KimlikNoileKisiAdresBilgileriSonucu sonucAddress = servisAddress.Sorgula(listAddress);
                //    if (sonucAddress.HataBilgisi == null)
                //    {
                //        if (sonucAddress.SorguSonucu.Count > 0)
                //        {
                //            if (sonucAddress.SorguSonucu[0].HataBilgisi == null)
                //            {
                //                string adresTip = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.AdresTip.Aciklama;

                //                switch (sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.AdresTip.Aciklama)
                //                {
                //                    case "Bilinmiyor":
                //                        break;
                //                    case "İl/İlçe Merkezi":
                //                        result.Il = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.Il;
                //                        result.Ilce = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.Ilce;
                //                        result.Mahalle = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.Mahalle;
                //                        result.Csbm = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.Csbm;
                //                        result.DisKapiNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.DisKapiNo;
                //                        result.IcKapiNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.IcKapiNo;
                //                        result.AcikAdres = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.AcikAdres;
                //                        result.KatNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.KatNo;

                //                        break;
                //                    case "Belediye Adresi":

                //                        result.Il = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.BeldeAdresi.Il;
                //                        result.Ilce = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.BeldeAdresi.Ilce;
                //                        result.Mahalle = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.BeldeAdresi.Mahalle;
                //                        result.Csbm = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.BeldeAdresi.Csbm;
                //                        result.DisKapiNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.BeldeAdresi.DisKapiNo;
                //                        result.IcKapiNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.BeldeAdresi.IcKapiNo;
                //                        result.AcikAdres = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.AcikAdres;
                //                        result.KatNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.KatNo;

                //                        break;
                //                    case "Köy Adresi":
                //                        result.Il = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.Il;
                //                        result.Ilce = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.Ilce;
                //                        result.Koy = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.Koy;
                //                        result.Mahalle = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.Mahalle;
                //                        result.Csbm = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.Csbm;
                //                        result.DisKapiNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.DisKapiNo;
                //                        result.IcKapiNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.KoyAdresi.IcKapiNo;
                //                        result.AcikAdres = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.AcikAdres;
                //                        result.KatNo = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.IlIlceMerkezAdresi.KatNo;

                //                        break;
                //                    case "Yurt Dışı Adresi":
                //                        result.YurtDisiUlke = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.YurtDisiAdresi.YabanciUlke.Aciklama;
                //                        result.YurtDisiIl = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.YurtDisiAdresi.YabanciSehir;
                //                        result.YurtDisiAdres = sonucAddress.SorguSonucu[0].YerlesimYeriAdresi.YurtDisiAdresi.YabanciAdres;

                //                        break;
                //                    default:
                //                        break;
                //                }

                //            }
                //            else
                //            {
                //                string hata = sonuc.SorguSonucu[0].HataBilgisi.Aciklama;
                //            }
                //        }
                //    }
                //    else
                //    {
                //        string hata = sonuc.HataBilgisi.Aciklama;
                //    }
                //}
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
        }

    }
}