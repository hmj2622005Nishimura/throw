using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	float MoveSpeed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Application.targetFrameRate = 60;
    }

	// Update is called once per frame
	void Update()
	{
		if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
		{
			transform.Translate(MoveSpeed * -1, 0, 0);
		}

		if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
		{
			transform.Translate(MoveSpeed, 0, 0);
		}

		if(transform.position.x > 2)
		{
			transform.position = new Vector3(2,4,0);
		}

		if(transform.position.x < -2)
		{
			transform.position = new Vector3(-2,4,0);
		}
	}
}
