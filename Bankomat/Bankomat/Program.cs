namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirish");
            Console.WriteLine("1-O'zbekcha");
            Console.WriteLine("2-Ruscha");
            Console.WriteLine("3-Ingilizcha");

            int pasword = 6904;

            int p = int.Parse(Console.ReadLine());

            if (p == 1)
            {
                Console.WriteLine("Plastik kartangiz parolini kiriting!");
                Console.Write("Parol: ");
                int parol =int.Parse( Console.ReadLine());

                if (parol == pasword)
                {
                    Menyu();
                    int mp= int.Parse(Console.ReadLine());

                     if (mp == 1)
                    {
                        Console.WriteLine("                                   Balansni tekshirish                  ");
                        Console.WriteLine("Balansda 1000000 so'm pul bor ");
                    }
                     else if (mp == 2)
                    {
                        Console.WriteLine("                                   Naqt pul olish:   ");
                        Console.WriteLine("1: 50 ming");
                        Console.WriteLine("2: 100 ming");
                        Console.WriteLine("3: 150 ming");
                        Console.WriteLine("4: 200 ming");
                        Console.WriteLine("5: 300 ming");
                        Console.WriteLine("6: 400 ming");
                        Console.WriteLine("7: 500 ming");
                        Console.WriteLine("8: Boshqa summa");
                        Console.WriteLine("9: ortga");
                        int sum = int.Parse(Console.ReadLine());

                        if(sum == 1|| sum==2 || sum==3 || sum==4||sum==5 || sum==6 ||sum==7)
                        {
                            Console.WriteLine("Iltimos kuting........");
                        }
                        else if(sum == 8)
                        {
                            Console.Write("   Kiriting");
                            int sumk = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Xato!!!!!");
                        }
                             
                    }
                    else if(mp == 3)
                    {
                        Console.WriteLine("                                  Sms xabarnomaga ulash");
                        Console.Write("Raqamni kiriting: +998 ");
                        Console.ReadLine();

                    }
                    else if(mp == 4)
                    {

                        Console.WriteLine("                                  Parolni uzgartirish.");
                    }
                     else if(mp == 5)
                    {
                        Console.WriteLine("                                  Telifon raqamga to'lov");
                        Console.Write("Raqamni kiriting: +998 ");
                        Console.ReadLine();
                        Console.Write("To'lov summasi:");
                        Console.ReadLine();
                    }
                     else if(mp == 6)
                    {
                        Console.WriteLine("                                   Kredit uchun to'lov.");
                        Console.Write("Kredit olingan hisob raqami: ");
                        Console.ReadLine();
                        Console.Write("To'lov summasi:");
                        Console.ReadLine();
                    }
                     else if (mp == 7)
                    {
                        Console.WriteLine("                                    Komunal to'lovlar");
                        Console.WriteLine("1-elektr energiyasi.");
                        Console.WriteLine("2-issiq suv.");
                        Console.WriteLine("3-sovuq suv.");
                        Console.WriteLine("4-gaz.");
                       Console.ReadLine() ; 
                    }
                     else if(mp == 8) 
                        
                    {
                        Main(args);

                    }


                }
               
                else
                {
                    Console.WriteLine("Parol xato!!!!");
                }
            }


        }
        static void Menyu()
        {
            Console.WriteLine("1-Balansni tekshirish");
            Console.WriteLine("2-Naqt pul olish");
            Console.WriteLine("3-Sms xabarnoma ulash");
            Console.WriteLine("4-Parolni uzgartirish");
            Console.WriteLine("5-Mobil aloqa uchun to'lov ");
            Console.WriteLine("6-Kredit uchun to'lov");
            Console.WriteLine("7-Komunal to'lovlar");
            Console.WriteLine("8-Dasturdan chiqish");
            
        }

            
       
    }
}