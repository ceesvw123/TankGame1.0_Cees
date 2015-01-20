using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {
	public float speed;
	public float maxLivetime;
	private float liveTime = 0f;
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float delta = Time.deltaTime;
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		liveTime += delta;
		if (liveTime > maxLivetime) 
		{
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision coll)
	{
		Instantiate (explosionPrefab, this.transform.position, this.transform.rotation);

		Destroy(this.gameObject);
	}
}
