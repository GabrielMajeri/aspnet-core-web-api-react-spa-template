using AutoMapper;
using ExampleApp.Data;
using ExampleApp.Entities;
using Xunit;

namespace ExampleApp.Tests
{
    public class MappingTests
    {
        private readonly MapperConfiguration _configuration;
        private readonly IMapper _mapper;

        public MappingTests()
        {
            _configuration = new MapperConfiguration(c => c.AddProfile<ProductProfile>());
            _mapper = _configuration.CreateMapper();
        }

        [Fact]
        public void Configuration_IsValid()
        {
            _configuration.AssertConfigurationIsValid();
        }

        [Fact]
        public void Product_MapsTo_ProductDTO()
        {
            var product = new Product();
            var productDto = _mapper.Map<ProductDTO>(product);
            Assert.NotNull(productDto);
        }

        // NOTE: This test would fail, since this template explicitly
        // does not implement the conversion from product DTO to product entity:
        // [Fact]
        // public void ProductDTO_MapsTo_Product()
        // {
        //     var productDto = new ProductDTO();
        //     var product = _mapper.Map<Product>(productDto);
        //     Assert.NotNull(product);
        // }
    }
}
