using UnityEngine;
using System.Collections;

public class Shoot : DetermineTarget {
	public GameObject bulletPrefab;
	private GameObject turret;
	private GameObject nozzel;
	private float reloadTime;
	public float timeToReload;
	public float maxLifeTime;
	private float lifeTime;
	public float lightFade;
	private Light l;

	// Use this for initialization
	void Start () {
		Transform[] transforms = GetComponentsInChildren<Transform> ();
		foreach(Transform t in transforms) 
		{
			if(t.gameObject.name == "turret")
			{
				turret = t.gameObject;
			}
			if(t.gameObject.name == "nozzel")
			{
				nozzel = t.gameObject;
			}

			l = this.gameObject.GetComponent<Light> ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Fire1"))
		{
			Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.rotation.eulerAngles.y);

			Instantiate(bulletPrefab, nozzel.transform.position, rotation);

			reloadTime = 0;
		}
		reloadTime += Time.deltaTime;
		if(reloadTime >= timeToReload)
		{
			CheckForPlayer();
			
			
		}
		l.intensity -= lightFade;
		
		
		lifeTime += Time.deltaTime;
		if (lifeTime > maxLifeTime) 
		{
			Destroy(this.gameObject);		
		}
	}
}
