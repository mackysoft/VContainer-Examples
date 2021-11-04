using VContainer;
using VContainer.Unity;
using MessagePipe;

public class MessagePipeLifetimeScope : LifetimeScope {
    protected override void Configure (IContainerBuilder builder) {
        var options = builder.RegisterMessagePipe();
        builder.RegisterBuildCallback(c => GlobalMessagePipe.SetProvider(c.AsServiceProvider()));
        builder.RegisterMessageBroker<PlayerAttackData>(options);

        builder.RegisterEntryPoint<Player>(Lifetime.Singleton);
        builder.RegisterEntryPoint<Enemy>(Lifetime.Singleton);
    }
}
