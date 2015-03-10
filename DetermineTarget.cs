using UnityEngine;
using System.Collections;

public class DetermineTarget : EnemyShoot {
	private Transform turret;

	public void CheckForPlayer()
	{
		Ray myRay = new Ray ();
		myRay.origin = turret.position;
		myRay.direction = turret.forward;
		
		RaycastHit hitInfo;
		
		//checken met behulp van een raycast of de player in zicht is
		if (Physics.Raycast (myRay, out hitInfo, shootingRange)) 
		{
			
			print(hitInfo.collider.gameObject.name);
			string hitObjectName = hitInfo.collider.gameObject.name;
		}
	}
}