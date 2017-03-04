using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GoMaps.Container;
using GoMaps.Gallery;
namespace GoMaps.Tests {
    [TestFixture]
    public class TestContainer {
        [Test]
        public void TestMethod() {
            AutofacConfig.ConfigurateContainer();
            IGalleryManager manager;
            using (var scope = AutofacConfig.Container.BeginLifetimeScope()) {
                manager = AutofacConfig.Container.Resolve<IGalleryManager>();
            }
            Assert.IsInstanceOf<GalleryManager>(manager);
        }
    }
}
