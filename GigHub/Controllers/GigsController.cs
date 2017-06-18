using GigHub.Models;
using GigHub.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Create()
        {
            var viewModel = new GigViewModel();
            viewModel.Genres = _context.Genres.ToList();

            return View(viewModel);
        }
    }
}