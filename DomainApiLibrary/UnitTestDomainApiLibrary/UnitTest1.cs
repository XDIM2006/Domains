using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainApiLibrary;

namespace UnitTestDomainApiLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var manager = new ManagerOfApi();

            var plugin = manager.StartPlugin("DomainApiLibrary", "DomainApiLibrary.Plugin", "Plugin1");
            var plugin2 = manager.StartPlugin("DomainApiLibrary", "DomainApiLibrary.Plugin", "Plugin2");
            Console.WriteLine(plugin.GetDomainName());
            Console.WriteLine(plugin2.GetDomainName());
            Console.WriteLine(manager.StopPlugin(plugin));
            Console.WriteLine(manager.StopPlugin(plugin2));
        }
    }
}
