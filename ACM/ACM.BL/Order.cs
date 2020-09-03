using System;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public Order Retrieve(int OrderId)
        {
            //Code that retrieves the defined order

            return new Order();
        }

        public bool Save()
        {
            //Code that saves the defined order

            return true;
        }
        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
