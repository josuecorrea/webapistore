using CWWebStore.Domain.Commands.ProductCommands;
using CWWebStore.Domain.Entities;
using System.Collections.Generic;

namespace CWWebStore.Domain.Services
{
    public interface IProductApplicationService
    {
        List<Product> Get();
        List<Product> Get(int skip, int take);
        List<Product> GetOutOfStock();
        Product Get(int id);
        Product Create(CreateProductCommand command);
        Product UpdateBasicInformation(UpdateProductInfoCommand command);
        Product Delete(int id);
    }
}