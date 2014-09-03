using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using InitiateAPI.Models;
using Microsoft.Data.OData;
using Ultimus.WFServer;

namespace InitiateAPI.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using InitiateAPI.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Initiate>("Initiates");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class InitiatesController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        public Tasklist GetTaskInitiate(string userName)
        {
            string strErr = string.Empty;
            Tasklist oTl = new Tasklist();
            TasklistFilter oTlF = new TasklistFilter();
            oTl.LoadFilteredTasks(oTlF, out strErr);
            string[] usr = new string[] { userName };
            oTlF.strArrUserName = usr;
            oTlF.nFiltersMask = Filters.nFilter_Initiate;
            

            return oTl;
        }

        // GET: odata/Initiates
        public IHttpActionResult GetInitiates(ODataQueryOptions<Initiate> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            GetTaskInitiate("areyna2");
            // return Ok<IEnumerable<Initiate>>(initiates);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Initiates(5)
        public IHttpActionResult GetInitiate([FromODataUri] int key, ODataQueryOptions<Initiate> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Initiate>(initiate);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Initiates(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Initiate> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(initiate);

            // TODO: Save the patched entity.

            // return Updated(initiate);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Initiates
        public IHttpActionResult Post(Initiate initiate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(initiate);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Initiates(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Initiate> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(initiate);

            // TODO: Save the patched entity.

            // return Updated(initiate);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Initiates(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
