using UnityEngine;
using UnityEngine.UI;

public class HelloWorldView : MonoBehaviour {

	[SerializeField]
	Button m_HelloButton;

	public Button HelloButton => m_HelloButton;

}