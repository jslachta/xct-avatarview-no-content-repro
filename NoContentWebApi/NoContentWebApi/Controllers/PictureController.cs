using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NoContentWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PictureController : ControllerBase
    {
        private readonly ILogger<PictureController> _logger;

        public PictureController(ILogger<PictureController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetNoContent")]
        public IActionResult GetNoContent()
        {
            return NoContent();
        }

        [HttpGet]
        [Route("GetContent")]
        public IActionResult GetContent()
        {
            using var stream = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("NoContentWebApi.EmbeddedResources.xamarin.png");
            using MemoryStream ms = new MemoryStream();

            stream.CopyTo(ms);

            return File(ms.ToArray(), "image/png");
        }
    }
}
