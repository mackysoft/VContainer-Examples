using VContainer.Unity;
using MessagePipe;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : ITickable {

    readonly IPublisher<PlayerAttackData> m_OnAttack;

    public Player (IPublisher<PlayerAttackData> onAttack) {
        m_OnAttack = onAttack;
	}

	void ITickable.Tick () {
		if (Keyboard.current.spaceKey.wasPressedThisFrame) {
            Debug.Log("Attacked");
            m_OnAttack.Publish(new PlayerAttackData {
                Damage = 1
            });
		}
	}
}
