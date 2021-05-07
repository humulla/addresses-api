using System.Collections.Generic;
using BaseApi.V1.Boundary;
using BaseApi.V1.Domain;

namespace BaseApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(RequestQueryParameter requestQueryParameter);
    }
}
