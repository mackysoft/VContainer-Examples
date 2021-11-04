using VContainer.Unity;

public class HelloWorldPresenter : IStartable {

	readonly HelloWorldService m_Service;
	readonly HelloWorldView m_View;

	public HelloWorldPresenter (HelloWorldService service,HelloWorldView view) {
		m_Service = service;
		m_View = view;
	}

	void IStartable.Start () {
		m_View.HelloButton.onClick.AddListener(() => m_Service.Hello());
	}
}