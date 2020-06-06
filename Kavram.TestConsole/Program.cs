using Kavram.App;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Kavram.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new storage
            var kavram = KavramObject.Create();

            // We save string variable with Kavram
            String name = "Berke";
            kavram.Update("name", name);

            // We get a variable with Kavram
            var newName = kavram.Get("name");
            Console.WriteLine(newName);

            // We save list variable with Kavram
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            kavram.Update("numberList", numberList);

            // We get a list with Kavram
            IList collection = (IList)kavram.Get("numberList");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            // You can check the key
            bool check = kavram.IsKeyContains("name");

            // You can delete all data
            kavram.ClearAllData();

            // You can get a count of datas
            int count = kavram.GetKeysCount();

            Console.ReadKey();
        }
    }
}
