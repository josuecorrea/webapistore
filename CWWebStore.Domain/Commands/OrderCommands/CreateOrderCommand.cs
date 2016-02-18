using System.Collections.Generic;

namespace CWWebStore.Domain.Commands.OrderCommands
{
    public class CreateOrderCommand
    {

        public CreateOrderCommand(IList<CreateOrderItemCommand> orderItems)
        {
            this.OrderItems = orderItems;
        }

        public IList<CreateOrderItemCommand> OrderItems { get; set; }

    }
}