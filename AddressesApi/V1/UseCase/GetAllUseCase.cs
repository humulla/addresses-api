using BaseApi.V1.Boundary;
using BaseApi.V1.Boundary.Response;
using BaseApi.V1.Factories;
using BaseApi.V1.Gateways;
using BaseApi.V1.UseCase.Interfaces;

namespace BaseApi.V1.UseCase
{
    //TODO: Rename class name and interface name to reflect the entity they are representing eg. GetAllClaimantsUseCase
    public class GetAllUseCase : IGetAllUseCase
    {
        private readonly IExampleGateway _gateway;
        public GetAllUseCase(IExampleGateway gateway)
        {
            _gateway = gateway;
        }

        public ResponseObject Execute(RequestQueryParameter requestQueryParameter)
        {
            return _gateway.GetEntityById(requestQueryParameter).ToResponse();
        }
    }
}
