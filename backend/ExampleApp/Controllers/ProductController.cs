using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ExampleApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves all the available products.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var products = _context.Products;
            var productDTOs = _mapper.ProjectTo<ProductDTO>(products);
            return await productDTOs.ToListAsync();
        }

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDTO>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return _mapper.Map<ProductDTO>(product);
        }
    }
}
