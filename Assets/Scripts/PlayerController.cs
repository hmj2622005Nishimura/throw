using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	const int MoveSpeed = 1;

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
	}
}
