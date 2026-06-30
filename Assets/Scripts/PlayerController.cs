using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	float MoveSpeed = 1.0f;//移動距離

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Application.targetFrameRate = 60;
    }

	// Update is called once per frame
	void Update()
	{
		//移動
		if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
		{
			transform.Translate(MoveSpeed * -1, 0, 0);
		}

		if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
		{
			transform.Translate(MoveSpeed, 0, 0);
		}

		//画面端に行ったときに画面外に行かない
		if(transform.position.x > 2)
		{
			transform.position = new Vector3(2,3,0);
		}

		if(transform.position.x < -2)
		{
			transform.position = new Vector3(-2,3,0);
		}

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//ぶつかった相手の	タグがObstanclesの場合ゲームオーバー
		if (collision.gameObject.CompareTag("obstancles"))
		{
			SceneManager.LoadScene("GAMEOVERscene");
		}
	}
}
