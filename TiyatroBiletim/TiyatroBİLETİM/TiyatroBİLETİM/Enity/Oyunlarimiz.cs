using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiyatroBİLETİM.Enity
{
    public class Oyunlarimiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public bool Yer { get; set; }

        public bool IsHome { get; set; }

        public int KategorıId { get; set; }

        public Kategori Kategori { get; set; }
    }
}