using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PM2HAHA.Models;

namespace PM2HAHA.Controllers
{
    public class ApiController : Controller
    {
        int i = 0;
        public ApiController()
        {
            try
            {


                String[] province = new String[] { "Chiang Mai", "Chiang Rai", "Lampang", "Lamphun", "Mae Hong Son", "Nan", "Phayao", "Phrae", "Uttaradit",
                                          "Kalasin", "Khon Kaen", "Chaiyaphum", "Nakhon Phanom", "Nakhon Ratchasima", "Bueng Kan", "Buriram", "Maha Sarakham", "Mukdahan", "Yasothon", "Roi Et",
                                          "Loei","Sakon Nakhon","Surin","Sisaket","Nong Khai","Nong Bua Lamphu","Udon Thani","Ubon Ratchathani","Amnat Charoen",
                        "Bangkok","Kamphaeng Phet","Chai Nat","Nakhon Nayok","Nakhon Pathom","Nakhon Sawan","Nonthaburi","Pathum Thani","Phra Nakhon Si Ayutthaya","Phichit ","Phitsanulok ","Phetchabun ",
                        "Lopburi ","Samut Prakan","Samut Songkhram","Samut Sakhon","Sing Buri","Sukhothai","Suphan Buri","Saraburi","Ang Thong","Uthai Thani",
                        "Chanthaburi","Chachoengsao","Chonburi","Trat","Prachinburi","Rayong","Sa Kaeo","Kanchanaburi","Tak","Prachuap Khiri Khan","Phetchaburi","Ratchaburi",
                        "Krabi","Chumphon","Trang","Nakhon Si Thammarat","Narathiwat","Pattani","Phang Nga","Phatthalung","Phuket","Ranong","Satun","Songkhla","Surat Thani","Yala"};
                

                using (test_dbContext ctx = new test_dbContext())
                {
                    foreach (string cityname in province)
                    {


                        var client = new WebClient();
                        
                        var json = client.DownloadString($"https://api.waqi.info/feed/ChiangMai/?token=c5a40e7f8af3b6fac5f3ca3828fda8b05ec1e60a");
                            APICall m = JsonConvert.DeserializeObject<APICall>(json);
                            var datatest = m.data;
                            var datatest1 = m.data.iaqi;
                            MstDataRaw getdata = new MstDataRaw()
                            {

                                Aqi = datatest.aqi,
                                Idx = datatest.idx,
                                City = datatest.city.name,
                                Co = datatest1.co.V,
                                H = datatest1.h.V,
                                No2 = datatest1.no2.V,
                                O3 = datatest1.o3.V,
                                P = datatest1.p.V,
                                Pm25 = datatest1.pm25.V,
                                Pm10 = datatest1.pm10.V,
                                So2 = datatest1.so2.V,
                                T = datatest1.t.V,
                                W = datatest1.w.V,
                                time = DateTime.Now,
                                CreateAt = DateTime.Now,
                                UploadAt = DateTime.Now,


                            };
                            ctx.MstDataRaws.Add(getdata);
                        ctx.SaveChanges();
                    }         
                    ctx.Database.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
            }

           
        }
    
    }
        
        
    
    
}