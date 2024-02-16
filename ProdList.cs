using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduct
{
   public  class ProdList
    {
        
        public void Product1()
        {


            List<Products> prodlist = new List<Products>()
                { 
                new Products() { PName = "Soap", Pprice = 50, MfDate = new DateTime(day: 12, month: 5, year: 2023), ExpDate = new DateTime(day: 12, month: 11, year: 2024) },
                new Products(){PName="Shampoo" ,Pprice=45,MfDate=new DateTime(day:05,month:12,year:2022),ExpDate=new DateTime(day:07,month:06,year:2023)},
               new Products(){PName="Oil" ,Pprice=250,MfDate=new DateTime(day:02,month:08,year:2021),ExpDate=new DateTime(day:13,month:11,year:2022)}



            };
         prodlist.Sort((p1,p2)=>p1.PName.CompareTo(p2.PName));
            for(int i=0;i<prodlist.Count;i++)
                Console.WriteLine($"{i}\t{prodlist[i].PName}\t{prodlist[i].Pprice}\t{prodlist[i].MfDate}\t{prodlist[i].ExpDate}");

        }
        
    }
}
