using VContainer;
using VContainer.Unity;

public class UniTaskLifetimeScope : LifetimeScope {
    protected override void Configure (IContainerBuilder builder) {
		builder.RegisterEntryPoint<CubeInstantiater>(Lifetime.Singleton);
    }
}
