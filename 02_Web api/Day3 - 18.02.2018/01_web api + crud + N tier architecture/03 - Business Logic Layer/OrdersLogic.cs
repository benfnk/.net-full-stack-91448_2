using System.Collections.Generic;
using System.Linq;

namespace JohnBryce
{
    public class OrdersLogic : BaseLogic
    {
        // Get all orders: 
        public List<OrderModel> GetAllOrders()
        {
            return DB.Orders.Select(o => 
                new OrderModel { id = o.OrderID, custID = o.CustomerID,
                    date = o.OrderDate, ship = o.ShipName }).ToList();
        }

        // Get one order: 
        public OrderModel GetOneOrder(int orderID)
        {
            var query = from o in DB.Orders
                        where o.OrderID == orderID
                        select new OrderModel {
                            id = o.OrderID,
                            custID = o.CustomerID,
                            date = o.OrderDate,
                            ship = o.ShipName
                        };

            return query.SingleOrDefault();

            //return DB.Orders.Where(o => o.OrderID == orderID).SingleOrDefault();
        }

        // Add new order: 
        public OrderModel AddOrder(OrderModel orderModel)
        {
            Order order = new Order
            {
                CustomerID = orderModel.custID,
                OrderDate = orderModel.date,
                ShipName = orderModel.ship
            };

            DB.Orders.Add(order);
            DB.SaveChanges();
            orderModel.id = order.OrderID; // Setting the new created id in our model.
            return orderModel; // Return the added order with all its fields.
        }

        // Update complete order: 
        public OrderModel UpdateOrder(OrderModel orderModel)
        {
            var query = from o in DB.Orders
                        where o.OrderID == orderModel.id
                        select o;

            Order order = query.SingleOrDefault();
            if (order == null)
                return null;

            order.CustomerID = orderModel.custID;
            order.OrderDate = orderModel.date;
            order.ShipName = orderModel.ship;

            DB.SaveChanges();

            return orderModel; // Return the updated model.
        }

        // Update partial order - only the order date: 
        public OrderModel UpdateOrderDate(OrderModel orderModel)
        {
            var query = from o in DB.Orders
                        where o.OrderID == orderModel.id
                        select o;

            Order order = query.SingleOrDefault();
            if (order == null)
                return null;

            order.OrderDate = orderModel.date;

            DB.SaveChanges();

            return orderModel; // Return the updated model.
        }

        // Delete order:
        public void DeleteOrder(int orderID)
        {
            var query = from o in DB.Orders
                        where o.OrderID == orderID
                        select o;

            Order order = query.SingleOrDefault();
            if (order == null)
                return;

            DB.Orders.Remove(order);
            DB.SaveChanges();
        }
    }
}
