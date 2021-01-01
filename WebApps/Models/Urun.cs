using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApps.Models
{
    public class Urun
    {
        public string adi { get; set; }
        public string turu { get; set; }
        public string aciklamasi { get; set; }
        public int fiyat { get; set; }
        public bool durum { get; set; }
        public string durum2 { get 
            { 
            
            if(durum==true)
                {
                    return "Sıfır";
                }
            else
                {
                    return "İkinci El";
                }
            
            
            }}
    }
}
