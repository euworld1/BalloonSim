using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour {

	public Transform Fire;

	// Use this for initialization
	void Start () {
		Fire.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		ContactPoint contact = collision.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		Instantiate(Fire, pos, rot);
		Destroy(Fire);
	}

}
