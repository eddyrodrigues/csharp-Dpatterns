using Application;
using Sorter;
using Microsoft.AspNetCore.Mvc;

namespace Controllers{
    [ApiController]
    [Route("[controller]")]
    public class SortersController {
        public SortersController()
        {
            
        }
        [HttpGet]
        public void RunSorters(){
            Sorter1 sorter1 = new Sorter1();
            Sorter2 sorter2 = new Sorter2();
            SorterApp app = new SorterApp(sorter1);
            app.RunApp();

            Console.WriteLine("-----------------------------------");
            
            app = new SorterApp(sorter2);
            app.RunApp();
        }
    }
}