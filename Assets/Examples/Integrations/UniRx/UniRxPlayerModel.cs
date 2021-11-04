using UniRx;

public class UniRxPlayerModel {

	public IReactiveProperty<int> Health { get; } = new ReactiveProperty<int>(3);

}