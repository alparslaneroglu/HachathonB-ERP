using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HachathonBİERP.Models
{
    public class StandartDuruslar
    {
        public int Id { get; set; }
        public DateTime Baslangıc { get; set; }
        public DateTime Bitis { get; set; }
        public string DurusNedeni { get; set; }

    }
    public class StandartDuruslarTablo
    {
        public List<StandartDuruslar> tbl = new List<StandartDuruslar>()
        {
            new StandartDuruslar(){Id=1,Baslangıc=new DateTime(0,0,0,10,0,0),Bitis=new DateTime(10,15,0),DurusNedeni="Çay Molası"},
            new StandartDuruslar(){Id=2,Baslangıc=new DateTime(0,0,0,12,0,0),Bitis=new DateTime(12,30,0),DurusNedeni="Yemek Molası"},
            new StandartDuruslar(){Id=3,Baslangıc=new DateTime(0,0,0,15,0,0),Bitis=new DateTime(15,15,0),DurusNedeni="Çay Molası"},
        };
    }
    
    
   
}
