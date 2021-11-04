using UnityEngine;
using VContainer;
using VContainer.Unity;

public class HelloWorldLifetimeScope : LifetimeScope {

    [SerializeField]
    HelloWorldView m_View;

    protected override void Configure (IContainerBuilder builder) {
        builder.Register<HelloWorldService>(Lifetime.Singleton);
        builder.RegisterEntryPoint<HelloWorldPresenter>();
        builder.RegisterComponent(m_View);
    }
}