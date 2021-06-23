using ApiLoterias.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoterias.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultsController : Controller
    {

        [HttpGet]
        public string Get(string game)
        {
            var json = ReadFile.ReadJsonFile(game);
            return json;
        }

    }
}
