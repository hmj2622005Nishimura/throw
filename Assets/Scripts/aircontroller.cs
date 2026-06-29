using UnityEngine;

public class aircontroller : MonoBehaviour
{
	public void OnTriggerStay2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("PLAYER"))
		{
			GetComponent<BoxCollider2D>();
		}
	}
}
