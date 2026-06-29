using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	float moveX;

	const int MoveSpeed = 4;

	[SerializeField] string leftKey;
	[SerializeField] string rightKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Application.targetFrameRate = 60;
		moveX = 0;  
    }

	// Update is called once per frame
	void Update()
	{
		moveX = 0;
		
	}	
}
