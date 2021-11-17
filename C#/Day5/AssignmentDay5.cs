using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    

    class Mobike
    {
        string Name;
        string BikeNumber;
        string PhoneNumber;
        int Days;
        int Charge;


        public void Input()
        {
            
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter BikeNumber :");
            BikeNumber = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber :");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Days :");
            Days = Convert.ToInt32(Console.ReadLine());


        }

        public void Compute()
        {
            Charge = 0; 
            for(int i = 0; i <= Days; i++) {
                if (i <= 5)
                {
                    Charge = Days * 500;
                }
                else if (i>5 && i <= 10)
                {
                    Charge = Days * 400;
                }
                else
                {
                    Charge = Days * 200;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine(Name + "\t" + BikeNumber + "\t" + PhoneNumber + "\t" + Days + "\t" + Charge + "\n");
        }
    }

    class AssignmentDay5
    {
        static void Displaylist(object o)
        {
            List<Mobike> mobikelist = (List<Mobike>)o;
            Console.WriteLine("Name | BikeNumber | PhoneNumber | Days | Charge\n");
            foreach(Mobike i in mobikelist)
            {
                i.Display();
            }
        }
        static void Main(string[] args)
        {
                            
            List<Mobike> mobikelist = new List<Mobike>();
            for (int i = 0; i < 2; i++)
            {
                Mobike m1 = new Mobike();
                m1.Input();
                m1.Compute();
                mobikelist.Add(m1);
            }
            Displaylist(mobikelist);

            int exit = 1;
            while(exit == 1) {
                Console.WriteLine("Enter 1 For Add, 2 For Delete, 3 For Edit, 4 For Search : ");

                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Mobike m = new Mobike();
                        m.Input();
                        m.Compute();
                        mobikelist.Add(m);
                        Console.WriteLine("Customer Added");
                        Displaylist(mobikelist);
                        break;
                    case 2:
                        Console.WriteLine("Enter Index You Want To Delete");
                        int deleteindex = Convert.ToInt32(Console.ReadLine());
                        if(deleteindex < mobikelist.Count)
                        {
                            mobikelist.RemoveAt(deleteindex);
                            Console.WriteLine("Customer Deleted");
                            Displaylist(mobikelist);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Index");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter index you want to edit");
                        int editindex = Convert.ToInt32(Console.ReadLine());
                        if(editindex < mobikelist.Count)
                        {
                            mobikelist[editindex].Input();
                            mobikelist[editindex].Compute();
                            Console.WriteLine("Customer Details Edited");
                            Displaylist(mobikelist);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Index");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter index you want to search");
                        int searchindex = Convert.ToInt32(Console.ReadLine());
                        if (searchindex < mobikelist.Count)
                        {
                            Console.WriteLine("Name | BikeNumber | PhoneNumber | Days | Charge\n");
                            mobikelist[searchindex].Display();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Index");
                        }
                        break;
                    case 5:
                        exit = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
 