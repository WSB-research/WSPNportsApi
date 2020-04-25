using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using WSBNports.Infrastructure;

namespace WSBNports.Controllers
{
    [Route("api/[controller]")]
    [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
    [ApiController]
    public class NportsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nport>>> Get(CancellationToken cancellationToken)
        {
            var all = await NportRepository<Nport>.GetItemsAsync(d => d != null, cancellationToken);
            return Ok(all);
        }
    }
}
