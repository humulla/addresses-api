using BaseApi.V1.Boundary;
using BaseApi.V1.Boundary.Response;
using BaseApi.V1.UseCase.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseApi.V1.Controllers
{
    [ApiController]
    //TODO: Rename to match the APIs endpoint
    [Route("api/v1/addresses")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    //TODO: rename class to match the API name
    public class BaseApiController : BaseController
    {
        private readonly IGetAllUseCase _getAllUseCase;
        public BaseApiController(IGetAllUseCase getAllUseCase)
        {
            _getAllUseCase = getAllUseCase;
        }

        //TODO: add xml comments containing information that will be included in the auto generated swagger docs (https://github.com/LBHackney-IT/lbh-base-api/wiki/Controllers-and-Response-Objects)
        /// <summary>
        /// ...
        /// </summary>
        /// <response code="200">...</response>
        /// <response code="400">Invalid Query Parameter.</response>
        [ProducesResponseType(typeof(ResponseObjectList), StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult ListContacts(RequestQueryParameter requestQueryParameter)
        {
            return Ok(_getAllUseCase.Execute(requestQueryParameter));
        }

       
    }
}
