using UnityEngine;

public class aircontroller : MonoBehaviour
{
	public void OnTriggerStay2D(Collider2D collision)
	{
		if(collision.gameObject)
		{
			GetComponent<BoxCollider2D>();
			Destroy(collision.gameObject);
		}
	}
}
