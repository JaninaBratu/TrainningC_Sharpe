using System;
using System.Collections.Generic;


namespace TrainningNet.Lessons.Lesson_14
{
    public class OrderAction
    {
        public static List<Order> orderList = new List<Order>();
        public static List<Order> tempOrderList = new List<Order>();

        public static void DisplayHistoryOfOrders(Customer customer, List<Order> listOfOrders)
        {
            List<Order> orderList = listOfOrders;
            Console.WriteLine("The customer of the list of orders is: " + customer.Name);
            Console.WriteLine("The list of orders for the selected customer is:");
            foreach (var o in orderList)
            {
                Console.WriteLine(o.OrderNumber + ", " + o.OrderDate);
            }
        }

        public static void AddOrdersToList(Order order)
        {
            bool isEqual = false;

            if (order != null)
            {
                if (orderList.Count > 0)
                {
                    tempOrderList = orderList;
                    foreach (var o in tempOrderList)
                    {
                        if (o.OrderNumber.Equals(order.OrderNumber))
                        {
                            isEqual = true;
                            o.OrderDate = order.OrderDate;
                        }
                    }
                    if (!isEqual)
                    {
                        orderList.Add(order);
                    }
                }
                else
                {
                    orderList.Add(order);
                }
            }
            else
            {
                Console.WriteLine("The order cannot be empty! Please choose another one");
            }
       }
       
    }
}
