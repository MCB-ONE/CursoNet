using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Error;

namespace UniversityApiBE.Controllers
{
    [Route("errors")]
    public class ErrorController : BaseApIController
    {
        [HttpGet]
        public IActionResult GetError (int code)
        {
            return new ObjectResult(new CodeErrorResponse(code));
        }

        [HttpPost]
        public IActionResult PostError(int code)
        {
            return new ObjectResult(new CodeErrorResponse(code));
        }

        [HttpPut]
        public IActionResult PutError(int code)
        {
            return new ObjectResult(new CodeErrorResponse(code));
        }

        [HttpDelete]
        public IActionResult DeleteError(int code)
        {
            return new ObjectResult(new CodeErrorResponse(code));
        }
    }
}
