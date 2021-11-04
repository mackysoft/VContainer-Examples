using UnityEngine;
using VContainer;
using VContainer.Unity;

public class UniRxLifetimeScope : LifetimeScope {

	[SerializeField]
	UniRxView m_View;

	protected override void Configure (IContainerBuilder builder) {
		builder.RegisterEntryPoint<UniRxPresenter>();
		builder.Register<UniRxPlayerModel>(Lifetime.Singleton);
		builder.RegisterComponent(m_View);
	}
}