using ServiceChecker4_8.Meb;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceChecker4_8.Controllers
{
    public class MebController : ApiController
    {
        public class Parameters
        {
            public string sorgulananTC { get; set; }
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "KURUM WEB SERVIS");

        }
        public HttpResponseMessage Post([FromBody] Parameters parameters)
        {

            IService service = new ServiceClient();
            Utilities.MebResult mebResult = new Utilities.MebResult();

            OgrenciSorgulaRequest request = new OgrenciSorgulaRequest();

            request.UygulamaBilgileri = CreateUygulamaBilgileri();

            request.TCKimlikNo = long.Parse(parameters.sorgulananTC);

            OgrenciSorgulaResponse response = service.OgrenciSorgula(request);
           

            if (response.Basarili)

            {
                mebResult.Aciklama = response.Aciklama;
                mebResult.Basarili = response.Basarili;
                mebResult.Sinif = response.Ogrenci.Sinif;
                mebResult.TurAdi = response.Ogrenci.TurAdi;
                return Request.CreateResponse(HttpStatusCode.OK, mebResult);
            }
            else
            {
                OgretmenSorgulaRequest requestOgretmen = new OgretmenSorgulaRequest();

                requestOgretmen.UygulamaBilgileri = CreateUygulamaBilgileri();

                requestOgretmen.TCKimlikNo = long.Parse(parameters.sorgulananTC);

                OgretmenSorgulaResponse responseOgretmen = service.OgretmenSorgula(requestOgretmen);
                mebResult.Aciklama = responseOgretmen.Aciklama;
                mebResult.Basarili = responseOgretmen.Basarili;
                mebResult.Durum = responseOgretmen.Ogretmen.Durum;
                mebResult.Il = responseOgretmen.Ogretmen.Il.ToString();
                mebResult.KurumTuru = responseOgretmen.Ogretmen.KurumTuru;

                return Request.CreateResponse(HttpStatusCode.OK, mebResult);

             }
        }

        private static UygulamaBilgileri CreateUygulamaBilgileri()

        {

            UygulamaBilgileri ub = new UygulamaBilgileri();

            ub.KullaniciAdi = "WS_ADANA_PASO_8097";

            ub.KullaniciSifre = "qb13Z@W3RQWAnD4@";

            ub.UygulamaNo = 9016;

            return ub;

        }


    }
}
