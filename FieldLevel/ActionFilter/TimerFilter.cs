using FieldLevel.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace FieldLevel.ActionFilter
{
    public class TimerFilter : IActionFilter
    {
        private readonly FieldLevelDbContext _db;

        public TimerFilter(FieldLevelDbContext db) => _db = db;

        /// <summary>
        /// On every request, determine whether 60 seconds has elapsed to continue fetching 3rd party data
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // determine whether a request time stamp exists
            var requestStamp = _db.RequestStamps.FirstOrDefault();
            if (requestStamp is null)
            {
                // timestamp did not exist, let's seed the database
                _db.RequestStamps.Add(new RequestStamp { RequestDate = DateTime.Now });
                _db.SaveChanges();
            }
            else
            {
                // timestamp exists, now determine whether 60 seconds has elapsed
                var elapsed = DateTime.Now.Subtract(requestStamp.RequestDate ?? DateTime.Now).TotalSeconds;
                if (elapsed < 60)
                {
                    // less than 60 seconds
                    context.Result = new BadRequestResult();
                }
                else
                {
                    // it's been 60 seconds since the last request, so let's reset the request timestamp
                    requestStamp.RequestDate = DateTime.Now;
                    _db.SaveChanges();
                }

                return;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}