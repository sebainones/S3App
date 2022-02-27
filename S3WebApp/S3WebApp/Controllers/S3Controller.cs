using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace S3WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class S3Controller : ControllerBase
    {
        private readonly ILogger<S3Controller> _logger;

        public S3Controller(ILogger<S3Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IAsyncResult Get()
        {
            throw new NotImplementedException();
        }

        // POST: S3Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBucket()
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, null);
            }
            return null;
        }

        // GET: S3Controller/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //POST: S3Controller/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, null);
            }
            return null;
        }

        // GET: S3Controller/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return null;
        }

        //// POST: S3Controller/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
