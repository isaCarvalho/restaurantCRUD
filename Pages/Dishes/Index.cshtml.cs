using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using restaurantCRUD.Data;
using restaurantCRUD.Models;

namespace restaurantCRUD.Pages.Dishes
{
    public class IndexModel : PageModel
    {
        private readonly restaurantCRUD.Data.RestaurantCrudContext _context;

        public IndexModel(restaurantCRUD.Data.RestaurantCrudContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dish.ToListAsync();
        }
    }
}
