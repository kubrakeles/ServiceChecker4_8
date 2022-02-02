using ServiceChecker4_8.Utilities;
using System;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ServiceChecker4_8.Controllers
{
    public class YokController : ApiController
    {

        public class Parameters
        {

            public string uygulamaAdi { get; set; }
            public string sorgulananTC { get; set; }
            public string uygulamaSunucuAdi { get; set; }
            public string kullaniciAdi { get; set; }
            public string istekId { get; set; }
        }

        // GET: Yok
        [HttpGet]
        public HttpResponseMessage Index()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "KURUM WEB SERVIS");
        }

        [HttpPost]
        public  HttpResponseMessage Post([FromBody] Parameters parameters)
        {
            YokResult result = new YokResult();
            Boolean isStudent = false;

            if(parameters==null)
            {
                result.SonucKod = -1;
                result.SonucMesaj = "Giriş parametreleri Boş Geçilemez";
            }else if (parameters.sorgulananTC == null)
            {
                result.SonucKod = -1;
                result.SonucMesaj = "Sorgulanan TC Boş Geçilemez";
            }
            else if (parameters.kullaniciAdi == null)
            {
                result.SonucKod = -1;
                result.SonucMesaj = "Kullanıcı Adı Boş Geçilemez";
            }
            else  if(parameters.uygulamaAdi==null)
            {
                result.SonucKod = -1;
                result.SonucMesaj = "Uygulama Adı Boş Geçilemez";
            }else if(parameters.uygulamaSunucuAdi == null)
            {
                result.SonucKod = -1;
                result.SonucMesaj = "Uygulama Sunucu Adı Boş Geçilemez";
            }

            if (parameters!=null&&parameters.kullaniciAdi!=null&& parameters.uygulamaAdi != null && parameters.uygulamaSunucuAdi != null && parameters.sorgulananTC != null)
            {
              
                try
                {
                    YokOgrenciSorgula.OgrenciOzetRequestType type = new YokOgrenciSorgula.OgrenciOzetRequestType();
                    YokOgrenciSorgula.IstekBilgiTip bilgi = new YokOgrenciSorgula.IstekBilgiTip();
                    bilgi.IstekId = parameters.istekId;
                    bilgi.IstekTarihi = DateTime.Now.ToString();
                    bilgi.UygulamaAdi = parameters.uygulamaAdi;
                    bilgi.UygulamaSunucuAdi = parameters.uygulamaSunucuAdi;
                    bilgi.KullaniciAdi = parameters.kullaniciAdi;

                    type.Istek = bilgi;
                    type.TcKimlikNo = long.Parse(parameters.sorgulananTC);


                    YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPortClient client = new YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPortClient();
                    client.ClientCredentials.UserName.UserName = "980113";
                    client.ClientCredentials.UserName.Password = "fr.geM73kHa";
                    using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
                    {
                        var httpRequestProperty = new HttpRequestMessageProperty();
                        httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
                                     Convert.ToBase64String(Encoding.ASCII.GetBytes(client.ClientCredentials.UserName.UserName + ":" +
                                     client.ClientCredentials.UserName.Password));
                        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;
                        YokOgrenciSorgula.OgrenciOzetResponse response = client.OgrenciOzet(type);
                        YokOgrenciSorgula.OgrenciOzetBilgi[] ogrenciOzetBilgis = response.OgrenciOzetBilgi;
                        if (response.Sonuc != null)
                        {
                            result.SonucKod = response.Sonuc.SonucKod;
                            result.SonucMesaj = response.Sonuc.SonucMesaj;
                            result.DisSistemSonucKod = response.Sonuc.DisSistemSonucKod;
                        }

                        if (ogrenciOzetBilgis != null && ogrenciOzetBilgis.Length != 0)
                        {
                            result.Adi = ogrenciOzetBilgis[0].Adi;
                            result.OgrencilikHakkiVarMi = ogrenciOzetBilgis[0].OgrencilikHakkiVarMi;
                            result.Soyadi = ogrenciOzetBilgis[0].Soyadi;
                            result.UniversiteAdi = ogrenciOzetBilgis[0].UniversiteAdi;
                            isStudent = true;

                        }

                    }
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            }


            if(!isStudent)
            {
                YokAkademikPersonelSorgula.AkademikPersonelOzetRequestType type = new YokAkademikPersonelSorgula.AkademikPersonelOzetRequestType();
                YokAkademikPersonelSorgula.IstekBilgiTip bilgi = new YokAkademikPersonelSorgula.IstekBilgiTip();

                YokAkademikPersonelSorgula.PersonelPortClient clientPersonel = new YokAkademikPersonelSorgula.PersonelPortClient();
                clientPersonel.ClientCredentials.UserName.UserName = "980113";
                clientPersonel.ClientCredentials.UserName.Password = "fr.geM73kHa";
                bilgi.IstekId = parameters.istekId;
                bilgi.IstekTarihi = DateTime.Now.ToString();
                bilgi.UygulamaAdi = parameters.uygulamaAdi;
                bilgi.UygulamaSunucuAdi = parameters.uygulamaSunucuAdi;
                bilgi.KullaniciAdi = parameters.kullaniciAdi;

                type.Istek = bilgi;
                type.TcKimlikNo = long.Parse(parameters.sorgulananTC);
                using (OperationContextScope scope = new OperationContextScope(clientPersonel.InnerChannel))
                {
                    var httpRequestProperty = new HttpRequestMessageProperty();
                    httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
                                 Convert.ToBase64String(Encoding.ASCII.GetBytes(clientPersonel.ClientCredentials.UserName.UserName + ":" +
                                 clientPersonel.ClientCredentials.UserName.Password));
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;
                    YokAkademikPersonelSorgula.AkademikPersonelOzetResponse response = clientPersonel.AkademikPersonelOzet(type);
                    YokAkademikPersonelSorgula.AkademikPersonelOzet[] personelOzetBilgis = response.AkademikPersonelOzet;
                    if (response.Sonuc != null)
                    {
                        result.SonucKod = response.Sonuc.SonucKod;
                        result.SonucMesaj = response.Sonuc.SonucMesaj;
                        result.DisSistemSonucKod = response.Sonuc.DisSistemSonucKod;
                    }

                    if (personelOzetBilgis != null && personelOzetBilgis.Length != 0)
                    {
                        result.Adi = personelOzetBilgis[0].Ad;
                        result.Soyadi = personelOzetBilgis[0].Soyad;
                        result.KadroUnvanAdi = personelOzetBilgis[0].KadroUnvanAdi;
                        result.UniversiteAdi = personelOzetBilgis[0].UniversiteAdi;
                    }

                }
            }

            return  Request.CreateResponse(HttpStatusCode.OK, result);


        }
    }
}