using ProjectName.Data.Enums;
using ProjectName.Extensions.Helper;
using Xunit;
using Xunit.Abstractions;
namespace ProjectName.Tests.Worker
{
    using Helper;

    public class ProjectNameWorkerTests
    {

        private bool _logActive = true;
        private readonly ITestOutputHelper _testOutputHelper;
        public ProjectNameWorkerTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            Logs.Initialize(_testOutputHelper,_logActive);
        }

        private class TestClass
        {
            public string Name { get; set; } = "default";

            public string Path { get; set; } = "test/path";

        }

        [Fact]
        public void Test_TestClass()
        {
            Logs.Log("Test1", new TestClass());
        }
    }



}
