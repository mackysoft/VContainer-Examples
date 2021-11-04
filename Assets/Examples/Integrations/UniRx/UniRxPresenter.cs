using System;
using UniRx;
using VContainer.Unity;

public class UniRxPresenter : IStartable, IDisposable {

	readonly UniRxPlayerModel m_Model;
	readonly UniRxView m_View;
	readonly CompositeDisposable m_Disposables = new CompositeDisposable();

	public UniRxPresenter (UniRxPlayerModel model,UniRxView view) {
		m_Model = model;
		m_View = view;
	}

	void IStartable.Start () {
		m_View.Button.OnClickAsObservable()
			.Where(_ => m_Model.Health.Value > 0)
			.Subscribe(_ => m_Model.Health.Value--)
			.AddTo(m_Disposables);

		m_Model.Health
			.Subscribe(health => m_View.SetHealth(health))
			.AddTo(m_Disposables);
	}

	void IDisposable.Dispose () => m_Disposables.Dispose();

}