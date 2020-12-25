using AutoMapper;
using ExampleApp.Entities;

namespace ExampleApp.Data
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
