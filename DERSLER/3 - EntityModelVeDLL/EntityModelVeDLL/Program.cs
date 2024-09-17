﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriErisimKatmani;


namespace EntityModelVeDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VeriModeli vm = new VeriModeli();

            List<Kategori> kategoriler = vm.KategorileriGetir();
            for (int i = 0; i < kategoriler.Count; i++)
            {
                Kategori k = kategoriler[i];
                Console.WriteLine($"{k.ID}) {k.isim} {k.Aciklama}");
            }

        }
    }
}
