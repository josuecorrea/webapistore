using CWWebStore.Domain.Entities;
using CWWebStoreSharedKernel.Validation;
using System.Linq;

namespace CWWebStore.Domain.Scopes
{
    public static class OrderScopes
    {
        public static bool PlaceOrderScopeIsValid(this Order order)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(order.OrderItems.Count(), 0, "Nenhum produto foi adicionado ao pedido")
            );
        }
    }
}