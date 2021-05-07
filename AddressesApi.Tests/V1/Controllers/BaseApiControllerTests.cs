using BaseApi.V1.Controllers;
using BaseApi.V1.UseCase;
using BaseApi.V1.UseCase.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.Tests.V1.Controllers
{
    [TestFixture]
    public class BaseApiControllerTests
    {
        private Mock<IGetAllUseCase> _getAllUseCase;
        private BaseApiController _classUnderTest;

        [SetUp]
        public void SetUp(GetAllUseCase getAllUseCase)
        {
            _getAllUseCase = new Mock<IGetAllUseCase>();
            _classUnderTest = new BaseApiController(_getAllUseCase.Object);
        }
    }
}
