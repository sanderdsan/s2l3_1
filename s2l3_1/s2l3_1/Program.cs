using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace s2l3_1
{
    class Worker
    {
        public string name;
        public string surname;
        public int wage;
        public int days;
        public static int Count;
        public Worker(string _name, string _surname, int _wage, int _days)
        {
            name = _name;
            surname = _surname;
            wage = _wage;
            days = _days;
            Count++;
        }
        public int Money()
        {
            return wage * days;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Worker[] workers = new Worker[3];
    //        workers[0] = new Worker("Jorato", "Kujo", 450, 23);
    //        workers[1] = new Worker("Dio", "Brando", 500, 750);
    //        workers[2] = new Worker("Kira", "Yoshikage", 340, 76);

    //        for (int i = 0; i < Worker.Count; i++)
    //        {
    //            int money = workers[i].Money();
    //            Console.WriteLine($"{workers[i].name} {workers[i].surname} got {money}$");
    //        }
    //    }
    //}
    class Saving
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];
            workers[0] = new Worker("Jorato", "Kujo", 450, 23);
            workers[1] = new Worker("Dio", "Brando", 500, 750);
            workers[2] = new Worker("Kira", "Yoshikage", 340, 76);

            SaveToJson(new[] { workers[0], workers[1], workers[2] }, "workers.json");
        }

        static void SaveToJson(Worker[] workers, string fileName)
        {
            string json = JsonConvert.SerializeObject(workers);

            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.Write(json);
            }
        }
    }

    //class Showing
    //{
    //    static void Main(string[] args)
    //    {
    //        Worker[] workers = LoadFromJson("workers.json");

    //        foreach (Worker worker in workers)
    //        {
    //            Console.WriteLine($"{worker.name} {worker.surname}: {worker.wage * worker.days}");
    //        }
    //    }
    //    static Worker[] LoadFromJson(string superworkers)
    //    {
    //        using (StreamReader streamReader = new StreamReader(superworkers))
    //        {
    //            string json = streamReader.ReadToEnd();
    //            return JsonConvert.DeserializeObject<Worker[]>(json);
    //        }
    //    }
    //}


}

