using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sample.ApiCsv.Web.ViewModels;

namespace Sample.ApiCsv.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SitesController : ControllerBase
    {
        private readonly List<SiteViewModel> _sites;

        public SitesController()
        {
            _sites = new List<SiteViewModel>
            {
                new SiteViewModel { Id = 1, SiteName = "Customer 1", AddressPostcode = "TW9 1AJ" },
                new SiteViewModel { Id = 2, SiteName = "Customer 2", AddressPostcode = "BH17 7BX" },
                new SiteViewModel { Id = 3, SiteName = "Customer 3", AddressPostcode = "BH23 6EW" }
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<SiteViewModel>> Get()
        {
            return _sites;
        }

        [HttpGet("{id}")]
        public ActionResult<SiteViewModel> Get(int id)
        {
            var foundSite = _sites.FirstOrDefault(site => site.Id == id);
            if (foundSite == null)
                return NotFound();

            return foundSite;
        }
    }
}
