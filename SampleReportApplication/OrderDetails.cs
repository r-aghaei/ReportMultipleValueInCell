using System.Collections.Generic;

namespace SampleReportApplication
{
    public class Order
    {
        public string CustomerName { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
    public class OrderBusiness
    {
        public static Order GetOrder()
        {
            return new Order()
            {
                CustomerName = "John Doe",
                OrderDetails = new List<OrderDetail>()
                {
                    new OrderDetail()
                    {
                        ProductName = "Foo",
                        UnitPrice = 100,
                        Quantity = 1,
                        Discount = 0
                    },
                    new OrderDetail()
                    {
                        ProductName = "Bar",
                        UnitPrice = 200,
                        Quantity = 2,
                        Discount = 50
                    },
                    new OrderDetail()
                    {
                        ProductName = "Baz",
                        UnitPrice = 50,
                        Quantity = 3,
                        Discount = 0
                    },
                }
            };
        }
    }
}
