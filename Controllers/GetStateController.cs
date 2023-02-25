using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using Malaysia_states.Model;
using Microsoft.AspNetCore.Cors;

namespace Malaysia_states.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetStateController : ControllerBase
    {
        [Obsolete]
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public GetStateController(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment= hostingEnvironment;
        }

        [EnableCors]
        [Obsolete]
        [HttpGet]
        public rootStateDetails? GetState()
        {
            var rootPath = _hostingEnvironment.ContentRootPath;
            var fullPath = Path.Combine(rootPath, "Data/All.json");

            var jsonData = System.IO.File.ReadAllText(fullPath);

            if (string.IsNullOrEmpty(jsonData)) 
                return null;

            rootStateDetails datalist = JsonConvert.DeserializeObject<rootStateDetails>(
                value: jsonData);

            if (datalist==null)
            {
                return null;
            }
            else
            {
                return datalist;
            }

            

          

            
        }
    }
}
