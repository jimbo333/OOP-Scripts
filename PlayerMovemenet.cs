using UnityEngine;
using System.Collections;

public class PlayerMovemenet : MonoBehaviour {

	public float rotationSpeed = 4f;
	public float moveSpeed = 0.1f;
	Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) 
		{
			
			transform.Translate(Vector3.forward * moveSpeed);
			
		}
		
		if(Input.GetKey(KeyCode.S))
		{
			
			transform.Translate(-Vector3.forward * moveSpeed);
			
		}
		
		if(Input.GetKey(KeyCode.A))
		{
			
			transform.Rotate(-Vector3.up * rotationSpeed);
			
		}
		
		if(Input.GetKey(KeyCode.D))
		{
			
			transform.Rotate(Vector3.up * rotationSpeed);
			
		}
		
	}
	void FixedUpdate () {
		if(rb.velocity != Vector3.zero)//(0,0,0)
		{
			rb.velocity = Vector3.zero;
		}
		if(rb.angularVelocity != Vector3.zero)
		{
			rb.angularVelocity = Vector3.zero;
		}
	}
}
