using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ExcelDataReader;
using Newtonsoft.Json;
using RestSharp;
using ServiceChecker4_8.Models;

namespace ServiceChecker4_8.Controllers
{

    public class HomeController : Controller
    {

        private static readonly HttpClient client = new HttpClient();
        ValuesController valuesobj = new ValuesController();
        [HttpGet]
        public ActionResult Index()
        {
            
            return View(new List<excModel>());
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {

            using (ABBServiceCheckerEntities dbEntities=new ABBServiceCheckerEntities())
            {
                List<Parameters> parametersList = new List<Parameters>();
                var tcListesi = dbEntities.kontrol.ToList();
                foreach (var item in tcListesi)
                {
                   
                    if(item.dogumAy!= "          " && item.mernis_acik_adres==null)
                    {
                        Parameters parametersObj = new Parameters{ 
                        sorgulananTC=item.tc,
                        dogumAy=item.dogumAy,
                        dogumGun=item.dogumGun,
                        dogumYil=item.dogumYil
                        
                        };
                        parametersList.Add(parametersObj);

                    }
                    
                }

                for (int i=0;i<parametersList.Count();i++)
                {
                    var item = parametersList[i];

                    if (item != null)
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://kurumapi.adana.bel.tr/api/values");
                        request.Method = "POST";
                        var postData = "sorgulananTC=" + Uri.EscapeDataString(item.sorgulananTC);
                        postData += "&dogumGun=" + Uri.EscapeDataString(item.dogumGun);
                        postData += "&dogumAy=" + Uri.EscapeDataString(item.dogumAy);
                        postData += "&dogumYil=" + Uri.EscapeDataString(item.dogumYil);
                        var data = Encoding.ASCII.GetBytes(postData);
                     
                        request.AllowAutoRedirect = false;
                        request.ContentLength = data.Length; //başlık için gerekli uzunluğumuzu belirtiyoruz
                        request.ContentType = "application/x-www-form-urlencoded";
                        request.Proxy = WebRequest.GetSystemWebProxy();
                        request.Timeout = 15000;
                        Stream reqStream = request.GetRequestStream();
                        reqStream.Write(data, 0, data.Length);
                        reqStream.Close();
                        try
                        {

                            WebResponse response = request.GetResponse();
                            Stream responseStream = response.GetResponseStream();
                            StreamReader str = new StreamReader(response.GetResponseStream()); //aldığımız yanıtı okuyoruz
                                                                                            // var serializer = new System.Web.javaScriptSerializer(); //
                                                                                            //var jsonObject = serializer.DeserializeObject(str.ReadToEnd());
                            kontrol kontrolobj = new kontrol();
                            dynamic jsonData = JsonConvert.DeserializeObject(str.ReadToEnd());
                            if (jsonData.TCKimlikNo == item.sorgulananTC)
                            {
                                kontrolobj = dbEntities.kontrol.SingleOrDefault(x => x.tc == item.sorgulananTC);
                                kontrolobj.mernis_acik_adres = jsonData.AcikAdres;
                                dbEntities.SaveChanges();
                            }


                        }
                        catch (WebException webex)
                        {
                            WebResponse errResp = webex.Response;
                            using (Stream respStream = errResp.GetResponseStream())
                            {
                                StreamReader reader = new StreamReader(respStream);
                                string text = reader.ReadToEnd();
                            }
                        }
                        


                         
                        

                      
                    }
                  
                }
                return View();

            }
            return View();
        }
    }
}
