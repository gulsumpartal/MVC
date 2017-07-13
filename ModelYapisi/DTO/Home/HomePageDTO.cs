using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelYapisi.Models;

namespace ModelYapisi.DTO.Home
{
    public class HomePageDTO
    {
        public List<Kisi> Kisiler { get; set; }
        public List<Adress> Adresler { get; set; }
    }
}