using BaseApi.V1.Boundary;
using BaseApi.V1.Boundary.Response;

namespace BaseApi.V1.UseCase.Interfaces
{
    public interface IGetAllUseCase
    {
        ResponseObject Execute(RequestQueryParameter requestQueryParameter);
    }
}
