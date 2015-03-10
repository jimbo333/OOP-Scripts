using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

	private Transform[] transforms;//naar baseclass
	protected Transform turret;//naar baseclass
	protected Transform nozzel;
	protected Vector3 targetPos;

	// Use this for initialization
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
	
	// Update is called once per frame
	protected virtual void Update () {

		turret.LookAt ( targetPos );
	}
}
