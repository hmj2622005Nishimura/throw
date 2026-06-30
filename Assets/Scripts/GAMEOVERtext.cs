using TMPro;
using UnityEngine;

public class GAMEOVERtext : MonoBehaviour
{
	[SerializeField] GameObject Te;
	
	void Update()
    {

		Te.GetComponent<TextMeshProUGUI>().text = "Press the ESC key to start.";
	}
}
