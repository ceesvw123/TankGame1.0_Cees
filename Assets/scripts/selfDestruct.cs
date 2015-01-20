using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {
	public float maxLivetime;
	private float liveTime;
	public float lightFade;
	private Light light;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		light.intensity -= lightFade;

		liveTime += Time.deltaTime;
		if (liveTime > maxLivetime) 
		{
			Destroy(this.gameObject);
		}
	}
}
