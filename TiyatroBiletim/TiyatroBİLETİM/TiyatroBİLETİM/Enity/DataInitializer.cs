using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TiyatroBİLETİM.Enity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategorıler = new List<Kategori>()
        {
            new Kategori(){Name="Aşk", Description="Aşk sevgi"},
            new Kategori(){Name="Korku", Description="gerilim"},
            new Kategori(){Name="Aksiyon", Description="Romatizm"},
            new Kategori(){Name="Bilim-kurgu", Description="Macera"},
            new Kategori(){Name="Tarihsel", Description="Tarihsel"},
            new Kategori(){Name="Dram", Description="Dram"},
        };

            foreach (var kategori in kategorıler)
            {

                context.Kategorıs.Add(kategori);


            }
            context.SaveChanges();

            List<Oyunlarimiz> oyunlars = new List<Oyunlarimiz>()
        {
            new Oyunlarimiz(){Name="Kamelyalı kadın",Description="bir kadın ve erkeğin askı",Price=50,Yer=true,KategorıId=0111,IsHome=true,Id=1},
            new Oyunlarimiz(){Name="Bu diyar bir başkadır",Description="sehirden köye",Price=50,Yer=true,KategorıId=1111,IsHome = true,Id = 2},
            new Oyunlarimiz(){Name="Tenor-3",Description="bir liselinin yasadığı korku macerası",Price=50,Yer=true,KategorıId=2222, IsHome = true,Id = 3},
            new Oyunlarimiz(){Name="RomeoVeJuliet",Description="bir kadın ve erkeğin dıramatik aşkı",Price=50,Yer=true,KategorıId=3333, IsHome = true,Id = 4},
            new Oyunlarimiz(){Name="MadamButtherfly",Description="sihirli bir dadının ev halkının hayatını değiştirmesi",Price=50,Yer=true,KategorıId=4444, IsHome = true,Id=5},
            new Oyunlarimiz(){Name="Celebi",Description="hazerfen ahmet celebinin hayatı",Price=50,Yer=true,KategorıId=5555, IsHome = true,Id = 6},
            new Oyunlarimiz(){Name="KülKedisi",Description="dilekler ask kıskançlık",Price=50,Yer=true,KategorıId=6666, IsHome = true,Id=7},
            new Oyunlarimiz(){Name="Dünya Dans Gün'ü",Description="bir kadın dans yolculuğu",Price=50,Yer=true,KategorıId=3333,IsHome=true,Id=8},
            new Oyunlarimiz(){Name="Barok Akşamı",Description="iki mafyanın arasındaki savas",Price=50,Yer=true,KategorıId=4444,IsHome=true,Id=9},
             new Oyunlarimiz(){Name="Beni Hatırlayınız",Description="bir adamın mirası",Price=50,Yer=true,KategorıId=1111,IsHome=true,Id=10},

        };


            foreach(var Oyunlarimiz in oyunlars)
            {
                context.Oyunlars.Add(Oyunlarimiz);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}