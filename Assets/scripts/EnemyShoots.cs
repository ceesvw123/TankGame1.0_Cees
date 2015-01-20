using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
	private float reloadTime;
	public float timeToReload;
	public GameObject bulletPrefab;
	public float shootingRange;
	private Transform Turret;
	private Transform nozzle;
	
	// Use this for initialization
	void Start () {
		reloadTime = 0;
		
		Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms) 
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
	void Update () {
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeToReload) 
		{
			CheckForPlayer();
			
			
		}
	}
	private void CheckForPlayer()
	{
		
		Ray myRay = new Ray ();
		myRay.origin = Turret.position;
		myRay.direction = Turret.forward;
		
		RaycastHit hitInfo;
		
		
		if (Physics.Raycast (myRay, out hitInfo, shootingRange)) 
		{
			
			
			//hitInfo.collider.gameObject.name;
			string hitObjectName = hitInfo.collider.gameObject.name;
			
			print ("ik rAAk iets");
			print ("ik raak "+ hitObjectName);
			if(hitObjectName == "Tank")
			{
				
				Instantiate(bulletPrefab, nozzle.position, nozzle.rotation);
				
				reloadTime = 0f;
			}
			
		}
	}
}
