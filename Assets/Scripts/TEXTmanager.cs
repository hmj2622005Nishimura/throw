using UnityEngine;
using TMPro;

public class TEXTmanager : MonoBehaviour
{
	int distance = 0;
	[SerializeField] GameObject TEXT;
	// Update is called once per frame
	private void Start()
	{
		Application.targetFrameRate = 60;
	}
	void Update()
    {
		distance++;
		TEXT.GetComponent<TextMeshProUGUI>().text = "DISTANCE" +  distance.ToString("F1");
    }
}
