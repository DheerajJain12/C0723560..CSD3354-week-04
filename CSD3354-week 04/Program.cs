using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_week_04
{
   
class Program
    {
        static void Main(string[] args)
        {


        }
    }
    class village
    {
        public bool isAstrildeHere;
        public village nextvillage;
        public village prevvillage;
        public String villagename;


    }


    class countryside
    {
        village maple;
        village toronto;
        village ajax;

        public void run()
        {
            maple = new village();
            maple.villagename = "toronto";
            maple.nextvillage = toronto;

        }

    }



}