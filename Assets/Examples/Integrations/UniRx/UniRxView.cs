using UnityEngine;
using UnityEngine.UI;

public class UniRxView : MonoBehaviour {

	[SerializeField]
	Text m_Text;

	[SerializeField]
	Button m_Button;

	public Button Button => m_Button;

	public Text Text => m_Text;

	public void SetHealth (int health) {
		m_Text.text = health > 0 ? health.ToString() : "GameOver";
	}

}