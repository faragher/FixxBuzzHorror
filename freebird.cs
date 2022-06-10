using System.Linq;

namespace FizzBuzzHorror
{
    static class WhatHappensInVegas
    {
        static void Main(string[] Waffles)
        {
            try
            {
                StaysInVegas(Waffles);
            }
            finally
            {
                System.Environment.Exit(0);
            }
        }

        static void StaysInVegas(string[] CurlyFries)
        {
            try
            {
                string String;
                String = CurlyFries[0];
                System.Console.WriteLine("Argument One: "+String);
                if(String == "-good")
                {
                    FizzBuzz(int.Parse(CurlyFries[1]));
                }
                int Z;
                bool DidThatActuallyWork = int.TryParse(CurlyFries[0], out Z);
                if(DidThatActuallyWork == false)
                {
                    ErrorOut();
                }
                try
                {
                    CreamSicle(CurlyFries[0]);
                }
                catch
                {
                    ErrorOut();
                }

            }
            catch
            {
                ErrorOut();
            }
        }

        static void ErrorOut()
        {
            System.Console.WriteLine("General Purpose Error");
        }

        static void CreamSicle(string BurgerBar)
        {
            System.Collections.Generic.Dictionary<string, string> Potato = new System.Collections.Generic.Dictionary<string, string>();
            BuffaloBurger(BurgerBar, out Potato);
            int Potatoe = 0;
            while( false == false)
            {
                if(Potatoe > int.Parse(BurgerBar) || Potatoe == int.Parse(BurgerBar))
                {
                    System.Environment.Exit(0x00);
                }
                Potatoe++;
                if (Potato.ContainsKey(Potatoe.ToString()))
                {
                    string PoTAto = "";
                    for(int i = 0; i < Potato.Count; i++)
                    {
                    if (Potato.Keys.ElementAt(i) == Potatoe.ToString())
                        {
                            PoTAto = Potato.Values.ElementAt(i);
                            System.Console.WriteLine(PoTAto);
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine(Potatoe.ToString());
                }

            }

        }

        static void BuffaloBurger(string Ribwich, out System.Collections.Generic.Dictionary<string, string> CrabRangoon)
        {
            string CremeBrule = 0.ToString();
            System.Collections.Generic.Dictionary<string , string> Pickle = new System.Collections.Generic.Dictionary<string , string>();
            while (true == true)
            {
                CremeBrule = (int.Parse(CremeBrule)+1).ToString();
                System.Collections.Generic.Dictionary<string, string> BuckeyeBall = new System.Collections.Generic.Dictionary<string, string>();
                BuckeyeBall = Pickle;
                string Chicken = new string(0xdeadbeef.ToString());
                double Cheeseburger;
                double SteamedHams;
                Cheeseburger = int.Parse(CremeBrule) / 3;
                SteamedHams = int.Parse(CremeBrule) / 5;
                Cheeseburger = System.Math.Floor(Cheeseburger);
                SteamedHams = System.Math.Floor(SteamedHams);
                Cheeseburger = Cheeseburger * 3;
                SteamedHams = SteamedHams * 5;
                if(int.Parse(CremeBrule) - Cheeseburger == 0)
                {
                    string McFish = "";
                    McFish = McFish + 'F';
                    McFish = McFish + 'i';
                    McFish = McFish + 'z';
                    McFish = McFish + 'z';
                    Chicken = McFish;
                }
                if (Chicken == "" || Chicken == 0xdeadbeef.ToString())
                {
                    if (int.Parse(CremeBrule) - SteamedHams == 0)
                    {
                        string McDouble = "";
                        char Char3 = 'z';
                        McDouble = McDouble + (char)66;
                        McDouble = McDouble + (char)0x75;
                        McDouble = McDouble + Char3;
                        McDouble = McDouble + "z";
                        Chicken = McDouble;
                    }
                }
                else
                {
                    if (int.Parse(CremeBrule) - SteamedHams == 0)
                    {
                        string ButterBurger = "";
                        char[] Whopper;
                        Whopper = new char[3];
                        Whopper[0] = 'B';
                        Whopper[1] = 'u';
                        Whopper[2] = 'z';
                        ButterBurger = ButterBurger + Whopper[0];
                        ButterBurger = ButterBurger + Whopper[1];
                        ButterBurger = ButterBurger+ Whopper[2];
                        ButterBurger = ButterBurger + Whopper[2];
                        Chicken = Chicken + ButterBurger;
                    }
                }

                if (Chicken != 0xdeadbeef.ToString())
                {
                    BuckeyeBall.Add(CremeBrule, Chicken);
                    Pickle = BuckeyeBall;
                }
                if(int.Parse(CremeBrule) == int.Parse(Ribwich)){
                    break;
                }
            }
            CrabRangoon = Pickle;

        }

        static void FizzBuzz(int Target)
        {
            string Payload = "";
            for (int i = 0; i < Target; i++)
            {
                Payload = (i % 3 == 0) ? "Fizz" : "";
                Payload = (i % 5 == 0) ? Payload += "Buzz" : Payload;
                if (Payload == "")
                {
                    Payload = i.ToString();
                }
                System.Console.WriteLine(Payload);

            }
            System.Environment.Exit(0);

        }
    }

}
