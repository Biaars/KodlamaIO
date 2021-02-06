using System;

namespace List_Dictionary_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> days = new Dictionary<int, string>();
            days.Add(1, "Pazartesi");
            days.Add(2, "Salı");
            days.Add(3, "Çarşamba");
            days.Add(4, "Perşembe");
            days.Add(5, "Cuma");
            days.Add(6, "Cumartesi");
            days.Add(7, "Pazar");
           
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days.key[i] + ".gün " + days.value[i]);
           
            }
        }
    }
}
