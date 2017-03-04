using Autofac;
using GoMaps.Gallery;

namespace GoMaps.Container {
    public static class AutofacConfig {
        public static IContainer Container { get; private set; } 
        public static void ConfigurateContainer() {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new GalleryManager()).As<IGalleryManager>();
            Container = builder.Build();
        }
    }
}