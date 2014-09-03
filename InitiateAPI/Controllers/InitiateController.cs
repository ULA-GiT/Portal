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
     * The WebApiConfig class may require additional changes to add a route for this controller.
     * Merge these statements into the Register method of the WebApiConfig class as applicable. 
     * Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using InitiateAPI.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Initiate>("Initiate");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class InitiateController : ODataController
    {
        public Tasklist GetTaskInitiate(string userName)
        {
            string strErr = string.Empty;
            Tasklist oTl = new Tasklist();
            TasklistFilter oTlF = new TasklistFilter();
            oTl.LoadFilteredTasks(oTlF, out strErr);
            string[] usr = new string[] {userName};
            oTlF.strArrUserName = usr;
            oTlF.nFiltersMask =  Filters.nFilter_Initiate;
        //    Tasklist oTl = new Tasklist();

        //    if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(processName))
        //    {
        //        string[] arrUser = new string[1];
        //        string[] arrStep = new string[1];
        //        arrUser[0] = userName;
        //        arrStep[0] = step;
        //        oTlF.strArrUserName = arrUser;
        //        oTlF.strProcessNameFilter = processName;
        //        oTlF.strArrStepLabelFilter = arrStep;
        //        oTlF.nFiltersMask = incident == 0 ? Filters.nFilter_Initiate : Filters.nFilter_Current;
        //        oTlF.nIncidentNo = incident;
        //        string strError = "";
        //        if (oTl.LoadFilteredTasks(oTlF, out strError))
        //        {
        //            if (oTl.GetTasksCount() == 1)
        //            {
        //                task = oTl.GetFirstTask();
        //                ret = FillIncidentInfoFromTask(task);
        //            }
        //        }
        //    }

        //    if (ret == null)
        //        throw new Exception("GetTaskByFilters Error");

            return oTl;
        }




        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        //// GET: odata/Initiate
        //public IHttpActionResult GetInitiate(ODataQueryOptions<Initiate> queryOptions)
        //{
        //    var t = new Tasklist();
        //    var t1 = new Ultimus.WFServer.TaskListFilter();
        //    t.LoadViewTasks("soce.int/alfresco",
        //    // validate the query.
        //    try
        //    {
        //        queryOptions.Validate(_validationSettings);
        //    }
        //    catch (ODataException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //    // return Ok<IEnumerable<Initiate>>(initiates);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// GET: odata/Initiate(5)
        //public IHttpActionResult GetInitiate([FromODataUri] int key, ODataQueryOptions<Initiate> queryOptions)
        //{
        //    // validate the query.
        //    try
        //    {
        //        queryOptions.Validate(_validationSettings);
        //    }
        //    catch (ODataException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //    // return Ok<Initiate>(initiate);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// PUT: odata/Initiate(5)
        //public IHttpActionResult Put([FromODataUri] int key, Delta<Initiate> delta)
        //{
        //    Validate(delta.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // TODO: Get the entity here.

        //    // delta.Put(initiate);

        //    // TODO: Save the patched entity.

        //    // return Updated(initiate);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// POST: odata/Initiate
        //public IHttpActionResult Post(Initiate initiate)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // TODO: Add create logic here.

        //    // return Created(initiate);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// PATCH: odata/Initiate(5)
        //[AcceptVerbs("PATCH", "MERGE")]
        //public IHttpActionResult Patch([FromODataUri] int key, Delta<Initiate> delta)
        //{
        //    Validate(delta.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // TODO: Get the entity here.

        //    // delta.Patch(initiate);

        //    // TODO: Save the patched entity.

        //    // return Updated(initiate);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// DELETE: odata/Initiate(5)
        //public IHttpActionResult Delete([FromODataUri] int key)
        //{
        //    // TODO: Add delete logic here.

        //    // return StatusCode(HttpStatusCode.NoContent);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}
    }
}
