using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	float moveX;
	Rigidbody2D rbody;

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
		if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
		{
			moveX = -1;
		}
		if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
		{
			moveX = 1;
		}

	}
	private void FixedUpdate()
	{
		rbody = new Vector2(moveX * MoveSpeed, rbody.y);
	}
}
