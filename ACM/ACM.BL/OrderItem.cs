using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem  Retrieve(int orderItemId)
        {
            //Code that retrieves the defined order item

            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined order item

            return true;
        }


        public bool Validate()
        {
            var isvalid = true;

            if (Quantity <= 0) isvalid = false;
            if (ProductId <= 0) isvalid = false;
            if (PurchasePrice == null) isvalid = false;

            return isvalid;
        }
    }
}
