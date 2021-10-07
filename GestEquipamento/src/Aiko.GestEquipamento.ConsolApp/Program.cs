using System;
using System.Linq;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.ConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (var context = new AppContextConsole()) 
            {
                var l = context.Equipments.ToList();

                foreach (var item in l)
                {
                    Console.WriteLine(item.Name);
                }
            }        
        }
    }
}
