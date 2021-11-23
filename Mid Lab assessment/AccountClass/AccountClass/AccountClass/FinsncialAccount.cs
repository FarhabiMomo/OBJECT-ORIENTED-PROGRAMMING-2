using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
   internal static class FinsncialAccount
    {
        private static Account[] account = new Account[1000];
        private static int count = 0;

        internal static void AddPerson(Account a)
        {
            account[count] = a;
            count++;
        }

        internal static void ShowAll()
        {
            Console.WriteLine("shob dekhau{0}",count);
            int index = 0;
            while (index < count)
            {
                Console.WriteLine("shob dekhau{0}", index);
                account[index].ShowInfo();
                index++;
            }
        }

        internal static bool SearchIndividual(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    Console.WriteLine("account Found");
                    account[index].ShowInfo();
                    found = true;
                    i = index;
                    return found; //break;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not found");
            return found;
        }
        internal static void DeletePerson(string key)
        {
            int index;
            bool decision = SearchIndividual(key, out index);
            string id = account[index].Id;
            if (decision)
            {
                account[index] = null;
                Console.WriteLine(id + " has been deleted.");
            }
        }
    }
}

