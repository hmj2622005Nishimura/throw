using UnityEngine;

public class cloudController : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Application.targetFrameRate = 60;
	}

	public void Shoot(Vector2 dir)
	{
		GetComponent<Rigidbody2D>().AddForce(dir);
	}
}
