using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.InputSystem;

public class obstanclesContoroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Application.targetFrameRate = 60;
    }

    public void Shoot(Vector2 dir)
	{
		GetComponent<Rigidbody2D>().AddForce (dir);
		Debug.Log("Ç–ÇÂÇßÇ¢ÅI");
	}
}
