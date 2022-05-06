using Microsoft.AspNetCore.Mvc;
using PflegeboxAPI.DataAccess;

namespace PflegeboxAPI.Controllers
{
    public class PflegeboxController : ControllerBase
    {
        private readonly DataModelContext _dataModelContext;
        public PflegeboxController(DataModelContext context)
        {
            _dataModelContext = context;
        }

        [HttpGet]
        [Route("{id}")]
        public PflegeboxAntrag GetPflegeboxAntrag(int id)
        {
            return new PflegeboxAntrag();
        }
    }
}
