using UnityEngine;

public class obstanclesGenerater : MonoBehaviour
{
	[SerializeField]GameObject SeaUrchin;
	float span = 1.0f;
	float delta = 0;
	float MoveSpeed = 0;

    // Update is called once per frame
    void Update()
    {
		delta += Time.deltaTime;//delta‚ÉŒo‰ßŽžŠÔ‚ð‘«‚µ‚Ä‚¢‚é
		if (delta > span)
		{
			delta = 0;
			GameObject obstancles1 = Instantiate(SeaUrchin);
			MoveSpeed = 200;
			float x = Random.Range(-2, 2);
			obstancles1.transform.position = new Vector3(x, -5, 0);
			obstancles1.GetComponent<obstanclesContoroller>().Shoot(new Vector2(0, MoveSpeed));
		}
    }
}
