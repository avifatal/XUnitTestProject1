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
        public object Any1(MyRequest2 request) => null;
        public object Any2(MyRequest3 request) => null;
        public object Any4(MyRequest4 request) => null;
        public object Any5(MyRequest5 request) => null;
        public object Any6(MyRequest6 request) => null;
        public object Any7(MyRequest7 request) => null;
        public object Any8(MyRequest8 request) => null;
        public object Any9(MyRequest9 request) => null;
        public object Any10(MyRequest10 request) => null;
        public object Any11(MyRequest11 request) => null;
    }
}
