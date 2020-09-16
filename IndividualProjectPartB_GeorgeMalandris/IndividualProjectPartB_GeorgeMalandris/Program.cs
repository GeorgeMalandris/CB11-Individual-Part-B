using IndividualProjectPartB_GeorgeMalandris.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB_GeorgeMalandris
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualPartBModel db = new IndividualPartBModel();
            Menus.menuRunner(db);
        }
    }
}
