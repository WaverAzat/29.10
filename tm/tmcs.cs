using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Banc_Acc
    {
        private uint Id { get; set; }
        private decimal Balance;
        public enum Chest_Type : byte
        {
            KGU = 0,
            KAI,
            KHTI
        }
        private Chest_Type Type;
        private static HashSet<uint> Last_Random = new HashSet<uint> { 0 };

        public Banc_Acc()
        {

        }

        public Banc_Acc(uint id, Chest_Type type)
        {
            Id = id;
            Type = type;
        }

        public Banc_Acc(Chest_Type type)
        {
            Random random = new Random();
            Id = (uint)random.Next(100, 999);
            if (!Last_Random.Add(Id))
            {
                Id += 1;
            }
            Type = type;
        }

        public void Top_Acc(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"Operation is completed! Balance = {Balance}");
            }
            else
            {
                Console.WriteLine("Incorrect Input!");
            }
        }

        public void Down_Acc(decimal money)
        {
            if (money > 0)
            {
                if (Balance - money > 0)
                {
                    Balance -= money;
                    Console.WriteLine($"Operation is completed! Balance = {Balance}");
                }
                else
                {
                    Console.WriteLine($"insufficient funds! Balance = {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input!");
            }
        }

        public void Print() => Console.WriteLine($"ID = {Id}, Balance = {Balance}, Type of schet = {Type}");
    }

    public class Building
    {
        private uint id, height, rooms_count, podezd_count;
        private int floors;
        private static HashSet<uint> Last_id = new HashSet<uint> { 0 };

        public Building()
        {

        }

        public Building(uint id, uint height, int floors, uint rooms_count, uint podezd_count)
        {
            this.id = id;
            this.height = height;
            this.rooms_count = rooms_count;
            this.podezd_count = podezd_count;
            this.floors = floors;
        }

        public Building(uint height, int floors, uint rooms_count, uint podezd_count)
        {
            Random random = new Random();
            id = (uint)random.Next(100, 999);
            if (!Last_id.Add(id))
            {
                id += 1;
            }

            this.height = height;
            this.floors = floors;
            this.rooms_count = rooms_count;
            this.podezd_count = podezd_count;
        }

        public void Height_of_floor()
        {
            Console.WriteLine($"Height of floor: {(double)height / (double)floors}");
        }

        public void Rooms_for_podezd()
        {
            Console.WriteLine($"Rooms for podezd: {rooms_count / podezd_count}");
        }

        public void Rooms_for_floor()
        {
            Console.WriteLine($"Rooms for floor: {rooms_count / podezd_count / floors}");
        }

        public void Print() => Console.WriteLine($"ID: {id}\nHeight: {height}\nFloors: {floors}\n" +
            $"Rooms Count: {rooms_count}\nPodezd count: {podezd_count}");

    }



    internal class Program
    {
        static void new_page()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            // ClassWork 1
            Console.WriteLine("ClassWork 1");
            Banc_Acc student_1 = new Banc_Acc(874, Banc_Acc.Chest_Type.KGU);
            student_1.Print();
            Console.WriteLine();
            Console.ReadKey();
            new_page();

            // ClassWork 2
            Console.WriteLine("ClassWork 2");
            Banc_Acc student_2 = new Banc_Acc(Banc_Acc.Chest_Type.KAI);
            student_2.Print();
            Console.WriteLine();
            new_page();

            // ClassWork 3
            Console.WriteLine("ClassWork 3");
            Banc_Acc student_3 = new Banc_Acc(Banc_Acc.Chest_Type.KHTI);
            student_3.Print();
            Console.WriteLine();
            student_3.Top_Acc(350);
            Console.WriteLine();
            student_3.Down_Acc(400);
            Console.WriteLine();
            student_3.Down_Acc(200);
            Console.WriteLine();
            new_page();

            // HomeWork 1
            Console.WriteLine("HomeWork 1");
            Console.WriteLine();
            Building building_1 = new Building(111, 1000, 100, 400, 5);
            building_1.Print();
            Console.WriteLine();
            building_1.Height_of_floor();
            building_1.Rooms_for_podezd();
            building_1.Rooms_for_floor();
            Console.WriteLine();

            Building building_2 = new Building(1000, 500, 100, 10);
            building_2.Print();
            Console.WriteLine();
            building_2.Height_of_floor();
            building_2.Rooms_for_podezd();
            building_2.Rooms_for_floor();
            new_page();
        }
    }
}
