using System.Linq;
using Amazon.DynamoDBv2;
using AutoFixture;
using BaseApi.V1.Boundary;
using BaseApi.V1.Boundary.Response;
using BaseApi.V1.Domain;
using BaseApi.V1.Factories;
using BaseApi.V1.Gateways;
using BaseApi.V1.UseCase;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace BaseApi.Tests.V1.UseCase
{
    public class GetAllUseCaseTests
    {
        private Mock<IExampleGateway> _mockGateway;
        private GetAllUseCase _classUnderTest;
        private Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _mockGateway = new Mock<IExampleGateway>();
            _classUnderTest = new GetAllUseCase(_mockGateway.Object);
            _fixture = new Fixture();
        }

        [Test]
        public void GetsAllFromTheGateway()
        {
            var stubbedEntities = _fixture.Create<Entity>();
            var parameter = _fixture.Create<RequestQueryParameter>();
            _mockGateway.Setup(x => x.GetEntityById(parameter)).Returns(stubbedEntities);

            var expectedResponse = new ResponseObject {};

            _classUnderTest.Execute(parameter).Should().BeEquivalentTo(expectedResponse);
        }

        //TODO: Add extra tests here for extra functionality added to the use case
    }
}
