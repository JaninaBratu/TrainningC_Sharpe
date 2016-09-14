using System;
using System.Collections.Generic;


namespace TrainningNet.Lessons.Lesson_14
{
    public class OrderAction
    {

        public void DisplayHistoryOfOrders(Customer customer, List<Order> listOfOrders)
        {
            List<Order> orderList = listOfOrders;
            Console.WriteLine("The customer of the list of orders is: " + customer.Name);
            Console.WriteLine("The list of orders for the selected customer is:");
            foreach (var o in orderList)
            {
                Console.WriteLine(o.OrderNumber + ", " + o.OrderDate);
            }
        }

        public void AddOrdersToList(Order order)
        {
            List<Order> orderList = new List<Order>();
            string orderNumber = order.OrderNumber;

            if (order != null)
            {
                if (orderList.Count > 0)
                {
                    //var match = orderList.FirstOrDefault(orderNumber => order.OrderNumber.Contains(order.Or));
                    //if (match != null)
                    //{
                            
                    //}
                        //foreach(var o in orderList)
                        //{
                        //    if (o.OrderNumber.Equals(order.OrderNumber))
                        //    {
                        //        o.OrderNumber.Replace(o.OrderNumber, order.OrderNumber);
                        //    }
                        //}
                }
                orderList.Add(order);
            }
        }
    }
}
