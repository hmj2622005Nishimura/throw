using UnityEngine;

public class CloudGenerater : MonoBehaviour
{
	[SerializeField] GameObject Cloud;
	float span = 5.0f;
	float Ctime = 0;
	float CSpeed = 0;

	// Update is called once per frame
	void Update()
	{
		Ctime += Time.deltaTime;//Ctime‚ÉŒo‰ßŽžŠÔ‚ð‘«‚µ‚Ä‚¢‚é
		if (Ctime > span)
		{
			Ctime = 0;
			GameObject Ccloud = Instantiate(Cloud);
			CSpeed = 500;
			float x = Random.Range(-2, 2);
			Ccloud.transform.position = new Vector3(x, -5, 0);
			Ccloud.GetComponent<cloudController>().Shoot(new Vector2(0, CSpeed));
		}

	}
}
