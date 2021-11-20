using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersOfTheWorld
{
    class WondersLogic
    {
        public void StartApp()
        {
            Console.WriteLine("To start application choose what you wont to do?");
            Console.WriteLine("Write (Info) to get information about seven wonders of the world");
            Console.WriteLine("Write (Exit) to exit application");

            string answer = Console.ReadLine();
            switch(answer)
            {
                case "Info":
                    GetInfoAboutSevenWonders();
                    break;
                case "Exit":
                        Console.WriteLine();
                    break;
            }
        }

        private void GetInfoAboutSevenWonders()
        {
            Console.WriteLine("About what wonder you wonna know?");
            Console.WriteLine("Write (Pyramid) if u wonna know some about Pyramid Of Cheops");
            Console.WriteLine("Write (Gardens) if u wonna know some about Hanging Gardens of Babylon");
            Console.WriteLine("Write (Zeus) if u wonna know some about Zeus statue in Olympia");
            Console.WriteLine("Write (Ephesus) if u wonna know some about Temple of Artemis of Ephesus");
            Console.WriteLine("Write (Mausoleum) if u wonna know some about mausoleum in Halicarnassus");
            Console.WriteLine("Write (Colossus) if u wonna know some about The Colossus of Rhodes");
            Console.WriteLine("Write (Lighthouse) if u wonna know some about Alexandrian lighthouse");

            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Pyramid":
                    new ThePyramidOfCheops().GetInfo();
                    break;
                case "Gardens":
                    new HangingGardensOfBabylon().GetInfo();
                    break;
                case "Zeus":
                    new ZeusStatueInOlympia().GetInfo();
                    break;
                case "Ephesus":
                    new TempleOfArtemisOfEphesus().GetInfo();
                    break;
                case "Mausoleum":
                    new MausoleumInHalicarnassus().GetInfo();
                    break;
                case "Colossus":
                    new TheColossusOfRhodes().GetInfo();
                    break;
                case "Lighthouse":
                    new AlexandrianLighthouse().GetInfo();
                    break;
            }
        }
    }
}
