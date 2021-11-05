using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer.Unity;

public class CubeInstantiater : IAsyncStartable {
	async UniTask IAsyncStartable.StartAsync (CancellationToken cancellation) {
		var prefab = await Resources.LoadAsync("Cube").ToUniTask(cancellationToken: cancellation);
		Debug.Log("Loaded");

		await UniTask.Delay(1000,cancellationToken: cancellation);

		UnityEngine.Object.Instantiate(prefab);
		Debug.Log("Instantiated");
	}
}