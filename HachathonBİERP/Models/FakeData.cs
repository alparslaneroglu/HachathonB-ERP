using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HachathonBİERP.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Entity
    {
        public class FakeData
        {
            public List<MevcutKayitliVeri> KayitliVeri
            {
                get
                {
                    return new List<MevcutKayitliVeri> //Ürünler Ekledik
                {
                    new MevcutKayitliVeri
                    {
                        Id = Guid.NewGuid().ToString(),
                        KayitNo = 1,
                        BaslangicTarih = new DateTime(2020,05,23,7,30,0),
                        BitisTarih = new DateTime(2020,05,23,8,30,0),
                        ToplamSure = 1,
                        Statu = "URETIM",

                    },
                    new MevcutKayitliVeri
                    {
                        Id = Guid.NewGuid().ToString(),
                        KayitNo = 2,
                        BaslangicTarih = new DateTime(2020,05,23,8,30,0),
                        BitisTarih = new DateTime(2020,05,23,12,00,0),
                        ToplamSure = 3.30M,
                        Statu = "URETIM",

                    },
                    new MevcutKayitliVeri
                    {
                        Id = Guid.NewGuid().ToString(),
                        KayitNo = 3,
                        BaslangicTarih = new DateTime(2020,05,23,12,00,0),
                        BitisTarih = new DateTime(2020,05,23,13,00,0),
                        ToplamSure = 1,
                        Statu = "URETIM",

                    },
                    new MevcutKayitliVeri
                    {
                        Id = Guid.NewGuid().ToString(),
                        KayitNo = 4,
                        BaslangicTarih = new DateTime(2020,05,23,13,00,0),
                        BitisTarih = new DateTime(2020,05,23,13,45,0),
                        ToplamSure = 0.45M,
                        Statu = "DURUŞ",
                        DurusNeden = "ARIZA"

                    },
                    new MevcutKayitliVeri
                    {
                        Id = Guid.NewGuid().ToString(),
                        KayitNo = 5,
                        BaslangicTarih = new DateTime(2020,05,23,13,45,0),
                        BitisTarih = new DateTime(2020,05,23,17,30,0),
                        ToplamSure = 3.45M,
                        Statu = "URETIM",

                    },

                };

                }

            }
            public List<StandartSituation> StandartSituation
            {
                get
                {
                    return new List<StandartSituation>
                {
                    new StandartSituation()
                    {
                        Id = Guid.NewGuid().ToString(),
                        StartDate = new DateTime(2020,05,23,10,0,0),
                        FinishDate = new DateTime(2020,05,23,10,15,0),
                        Status = "ÇAY MOLASI"
                    },
                    new StandartSituation()
                    {
                        Id = Guid.NewGuid().ToString(),
                        StartDate = new DateTime(2020,05,23,12,0,0),
                        FinishDate = new DateTime(2020,05,23,12,30,0),
                        Status = "YEMEK MOLASI"
                    },
                    new StandartSituation()
                    {
                        Id = Guid.NewGuid().ToString(),
                        StartDate = new DateTime(2020,05,23,15,0,0),
                        FinishDate = new DateTime(2020,05,23,15,15,0),
                        Status = "ÇAY MOLASI"
                    },
                };
                }
            }




        }
    }

}
