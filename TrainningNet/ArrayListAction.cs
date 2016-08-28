using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class ArrayListAction
    {

        public static void GetGroceryList()
        {
            List<string> groceryList = new List<string>();
            
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                var userInput = Console.ReadLine();

                if (userInput.StartsWith("+"))
                    {
                        var addedItem = userInput.Substring(2);
                        groceryList.Add(addedItem);
                        GetUpdatedList(groceryList);
                    }
                else if (userInput.StartsWith("--"))
                {

                    if (IsFilled(groceryList))
                    {
                        SetMessageToUser("The list will be cleared!");
                        groceryList.Clear();
                        GetUpdatedList(groceryList);
                    }
                    else
                    {
                        SetMessageToUser("There is nothing in the grocery list!");
                        GetUpdatedList(groceryList);
                    }
                }
                else if(userInput.StartsWith("-") )
                    {
                       var removedItem = userInput.Substring(2);
                       if (IsFilled(groceryList) && IsInList(groceryList, removedItem)) //see if this is needed
                       {
                           groceryList.Remove(removedItem);
                       }
                       else
                       {
                           SetMessageToUser("There is nothing in the groceryList so nothing can be removed");
                       }
                       GetUpdatedList(groceryList);
                  }
            }
        }

        public static bool IsFilled(List<string> groceryList)
        {
            if (groceryList.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsInList(List<string> groceryList, string removedItem)
        {
            foreach(var g in groceryList)
            {
                if (g.Equals(removedItem))
                {
                    return true;
                }
            }
            return false;
        }

        public static void SetMessageToUser(string message)
        {
            Console.WriteLine(message);
        }

        public static void GetUpdatedList(List<string> groceryList)
        {
            SetMessageToUser("The grocery list is: ");
            foreach (var g in groceryList)
            {
                SetMessageToUser(g + "\n");
            }
        }
    }
}
