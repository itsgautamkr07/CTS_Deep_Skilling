using Moq;
using NUnit.Framework;

[TestFixture]
public class DataServiceTests
{
    [Test]
    public void FetchData_ReturnsMockedData()
    {
        var mockApi = new Mock<IExternalApi>();

        mockApi.Setup(x => x.GetData())
               .Returns("Mock Data");

        var service = new DataService(mockApi.Object);

        Assert.AreEqual("Mock Data", service.FetchData());
    }
}
