using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour 
{
	//public AudioSource audio;
	public GameObject BurnerSound;
	public Transform BurnerObject;
	public GameObject Prefab;
	private Rigidbody rb;
	float startTemp = 160f;
	float currentEnvelopeTemp; 
	float burnAcc = 1000;
	float coolAcc = -500;
	float coolingRate =10;
	bool isBurnerBurning = false;




	// Use this for initialization
	void Start () 
	{
		
	
		AudioSource audio = GetComponent<AudioSource> ();

		rb = GetComponent<Rigidbody>();
		currentEnvelopeTemp = startTemp;

		//burnsound = GetComponent<AudioSource> ();
		//Fire.GetComponent<ParticleSystem>().enableEmission = true;
		//ps = GetComponent<ParticleSystem>();

	}
	void FixedUpdate() 
	{
		
		//burnersound.Pause();
		//var emmision = ps.emission;
		//emmision.enabled = moduleEnabled;
	}

	void BurnDelay()
	{

		float finalAcc = burnAcc;
		Vector3 movementy = new Vector3 (0,finalAcc,0);
		rb.AddForce(movementy);
	}

//	void OnGUI() 
//	{
//		moduleEnabled = GUI.Toggle (new Rect (25, 45, 100, 30), moduleEnabled, "Enabled");
//	}
	
	void OnTriggerEnter()
	{
		

		Debug.Log ("OnTriggerEnter");
		//Fire.GetComponent<ParticleSystem> ().enableEmission = true;
		//burner.rigidbody.GetComponent<ParticleSystem> ().enableEmission;
		//ParticleSystem ps = GetComponent<ParticleSystem>();
		//Destroy (burner.gameObject);	


		//Delay in lift reaction

		//fireflame

		//if (isBurnerBurning == true) 
		//{
		//playSound ();
		//}
		playSound ();
		//BurnDelay ();
		Invoke ("BurnDelay", 4.0f);
		startFlame ();
		//play sound
		//4 sec reaction

		//Instantiate(Prefab, BurnerObject.position, BurnerObject.rotation);
		//Invoke ("BurnDelay", 4.0f);
		//audio.Play ();

		//Start burner particle system



		 




		//Destroy (Prefab.gameObject, 3.0f);
		//burnsound.Stop ();


		//audio.Play;
			

	}

	void playSound()
	{	
	
		//audio.Play ();

	}

	void startFlame()
	{

		//yield return isBurnerBurning = true;
		Instantiate(Prefab, BurnerObject.position, BurnerObject.rotation);
	}





	void OnTriggerStay(Collider burner)
	{
		Debug.Log ("Hand is touching the burner");
	}

	void OnTriggerExit(Collider burner)
	{
		//Debug.Log ("Hand is not touching the burner anymore");
		//Destroy (pointlight);
		//burnersound.Stop();

	}


}
