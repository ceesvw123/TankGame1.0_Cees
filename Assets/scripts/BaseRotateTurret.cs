using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {
	private Transform[] transforms;
	protected Transform Turret;
	protected Vector3 targetPos;
	protected Transform nozzle;




	// Use this for initialization
	protected virtual void Start () {

		transforms = gameObject.GetComponentsInChildren<Transform>();
		foreach(Transform t in transforms)
		{
			if(t.gameObject.name == "Turret")
			{
				Turret = t;
			}
			if(t.gameObject.name == "nozzle")
			{
				nozzle = t;
			}
		}
	}
	
	// Update is called once per frame
	protected virtual void Update () {

		Turret.LookAt(targetPos);
	
	}
}
