using ListPostRepro.ODataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace ListPostRepro.ODataService.Controllers
{
    public class ListTestController : ODataController
    {
        [HttpPost, ODataRoute("CreateListIndex")]
        public async Task<IHttpActionResult> ListCreate([FromBody]CreateList createList)
        {
            CreateList internalList = createList;

            return Created(internalList);
        }

        [HttpPost, ODataRoute("CreateListIndexValue")]
        public async Task<IHttpActionResult> ListCreateValue([FromBody]CreateListValue createList)
        {
            if (createList == null || createList.ListValues == null) { return BadRequest("Invalid List Data."); }

            CreateListValue internalList = createList;

            return Created(internalList);
        }

    }
}