using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM2HAHA.Models
{
    public class Products
    {
   
        public string status { get; set; }
        public Data data { get; set; }
        


        public string s { get; set; }
        public string tz { get; set; }

       
        public int pm25 { get; set; }
        public int url { get; set; }

        //{"status":"ok","data":{"aqi":95,"idx":5775,"attributions":[{"url":"http://aqmthai.com/","name":"Division of Air Quality Data, Air Quality and Noise Management Bureau, Pollution Control Department.","logo":"Thailand-PCD.png"},{"url":"http://worldweather.wmo.int","name":"World Meteorological Organization - surface synoptic observations (WMO-SYNOP)"},{"url":"https://waqi.info/","name":"World Air Quality Index Project"}],"city":{"geo":[18.787747,98.9931284],"name":"Chiang Mai","url":"https://aqicn.org/city/chiang-mai"},"dominentpol":"pm25","iaqi":{"co":{"v":0.1},"h":{"v":40},"no2":{"v":2.4},"o3":{"v":16.6},"p":{"v":1005.7},"pm10":{"v":40},"pm25":{"v":95},"so2":{"v":0.6},"t":{"v":40.8},"w":{"v":1.3}},"time":{"s":"2020-05-09 15:00:00","tz":"+07:00","v":1589036400},"debug":{"sync":"2020-05-09T18:09:28+09:00"}}}


    }
    public class Data
    {
        public int idx { get; set; }
        public int aqi { get; set; }
        public City city { get; set; }

    }
    public class City 
    {
        public ArrayList(int capacity);
        public virtual decimal geo { get; set; }
        
        public string name { get; set; }
    }

}
