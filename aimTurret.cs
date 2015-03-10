using UnityEngine;
using System.Collections;

public class aimTurret : BaseRotateTurret {
	private Transform[] transforms;//naar baseclass
	protected Transform turret;//naar baseclass
	protected Transform nozzel;
	protected Vector3 targetPos;
	public Camera camera;

	virtual protected void Start () {
		//naar baseclass
		bool turretFound = false;
		
		
		transforms = gameObject.GetComponentsInChildren<Transform>();
		
		foreach(Transform t in transforms)
		{
			if(t.gameObject.name == "turret")
			{
				turret = t;
				turretFound = true;
			}
			if(t.gameObject.name == "nozzel")
			{
				
				nozzel = t;
				
			}
		}
		if(!turretFound)
		{
			print ("No turret was found in the gameObject");
		}
		
	}
	protected virtual void Update () {
		
		turret.LookAt ( targetPos );
	}
	override protected void Update () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = camera.transform.position.y - turret.transform.position.y;
		
		Vector3 worldPos = camera.ScreenToWorldPoint (mousePos);
		
		targetPos = worldPos;
		
		base.Update ();
}
