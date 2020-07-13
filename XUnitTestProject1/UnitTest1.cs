using Funq;
using ServiceStack;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Licensing.RegisterLicense(@"...");

            TestAppHostInitializer test = new TestAppHostInitializer();
            test.Init().Start("http://localhost:2000");
        }
    }

    public class TestAppHostInitializer : AppSelfHostBase
    {
        public TestAppHostInitializer() : base("EYEZ", typeof(UnitTest1).Assembly) { }

        public override void Configure(Container container)
        {
            
        }
    }
    public class MyRequest1 : IReturnVoid
    {

    }
    public class MyRequest2 : IReturnVoid
    {

    }
    public class MyRequest3 : IReturnVoid
    {

    }
    public class MyRequest4 : IReturnVoid
    {

    }
    public class MyRequest5 : IReturnVoid
    {

    }
    public class MyRequest6 : IReturnVoid
    {

    }

    public class MyRequest7 : IReturnVoid
    {

    }
    public class MyRequest8 : IReturnVoid
    {

    }
    public class MyRequest9 : IReturnVoid
    {

    }
    public class MyRequest10 : IReturnVoid
    {

    }
    public class MyRequest11 : IReturnVoid
    {

    }
    public class MyServices : Service
    {
        public object Any (MyRequest1 request) => null;
        public object Any(MyRequest2 request) => null;
        public object Any(MyRequest3 request) => null;
        public object Any(MyRequest4 request) => null;
        public object Any(MyRequest5 request) => null;
        public object Any(MyRequest6 request) => null;
        public object Any(MyRequest7 request) => null;
        public object Any(MyRequest8 request) => null;
        public object Any(MyRequest9 request) => null;
        public object Any(MyRequest10 request) => null;
        public object Any(MyRequest11 request) => null;
    }
}
