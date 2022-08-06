using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlapp.Models;
using sqlapp.Services;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        private readonly IProductService _producService;

        public IndexModel(IProductService productService)
        {
            _producService = productService;
        }

        public void OnGet()
        {
            Products = _producService.GetProducts();

        }
    }
}