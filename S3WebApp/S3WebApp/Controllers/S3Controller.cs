using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace S3WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class S3Controller : ControllerBase
    {
        private readonly ILogger<S3Controller> _logger;
        private readonly AmazonS3Client _client;

        public IAmazonS3 S3Client { get; set; }
        public S3Controller(ILogger<S3Controller> logger, IAmazonS3 s3Client)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            if (s3Client is null)
            {
                throw new ArgumentNullException(nameof(s3Client));
            }
            _client = (s3Client as AmazonS3Client);
        }

        [HttpGet("/api/s3", Name = "GetAllBuckets")]
        public async Task<IActionResult> GetAllBucketsAsync()
        {
            try
            {
                // Issue call                
                ListBucketsResponse response = await _client.ListBucketsAsync(default);

                // Issue call

                // View response data
                Console.WriteLine("Buckets owner - {0}", response.Owner.DisplayName);
                foreach (S3Bucket bucket in response.Buckets)
                {
                    Console.WriteLine("Bucket {0}, Created on {1}", bucket.BucketName, bucket.CreationDate);
                }

                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, null);
            }
            return null;
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
