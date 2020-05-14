using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM2HAHA.Models
{

    public class APICall
    {
        public string status { get; set; }
        public Data data { get; set; }

    }
    public class Data
    {
        public int idx { get; set; }
        public int aqi { get; set; }
        public City city { get; set; }
        public Iaqi iaqi { get; set; }
    }
    public class City
    {
        public string name { get; set; }

      
    }
    public class Iaqi
    {
        public Co co { get; set; }
        public H h { get; set; }
        public No2 no2 { get; set; }
        public O3 o3 { get; set; }
        public P p { get; set; }
        public Pm10 pm10 { get; set; }
        public Pm25 pm25 { get; set; }
        public R r { get; set; }
        public So2 so2 { get; set; }
        public T t { get; set; }
        public W w { get; set; }

    }
    public class Co
    {
        public decimal V { get; set; }
    }
    public class H
    {
        public int V { get; set; }
    }
    public class No2
    {
        public decimal V { get; set; }
    }
    public class O3
    {
        public decimal V { get; set; }
    }
    public class P
    {
        public decimal V { get; set; }
    }
    public class Pm10
    {
        public int V { get; set; }
    }
    public class Pm25
    {
        public int V { get; set; }
    }
    public class R
    {
        public decimal V { get; set; }
    }
    public class So2
    {
        public decimal V { get; set; }
    }
    public class T
    {
        public decimal V { get; set; }
    }
    public class W
    {
        public decimal V { get; set; }
    }



}
