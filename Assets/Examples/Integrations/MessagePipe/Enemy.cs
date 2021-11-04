using VContainer.Unity;
using MessagePipe;
using UnityEngine;
using System;

public class Enemy : IStartable, IDisposable {

    public int Health = 3;

    readonly ISubscriber<PlayerAttackData> m_OnAttacked;
    readonly SingleAssignmentDisposable m_Disposable = new SingleAssignmentDisposable();

    public Enemy (ISubscriber<PlayerAttackData> onAttacked) {
        m_OnAttacked = onAttacked;
	}

	void IStartable.Start () {
        m_Disposable.Disposable = m_OnAttacked.Subscribe(attack => {
            Health = Mathf.Max(0,Health - attack.Damage);
            Debug.Log("Damaged");
            if (Health == 0) {
                Debug.Log("Dead");
			}
        });
	}

    void IDisposable.Dispose () => m_Disposable.Dispose();

}