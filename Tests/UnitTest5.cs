using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace Tests
{

    [TestFixture]
    public class UnitTest5
    {
        [Test]
        public void TestMethod1()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod2()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod3()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod4()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod5()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod6()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod7()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod8()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod9()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void TestMethod10()
        {
            var browser = new Browser(BootstrapConfigurator.DefaultBootstrap);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
