using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DigitalRuby.PyroParticles;


//master
public class PlayerController : MonoBehaviour {
   public Transform burner;
    

	private Rigidbody rb;
    private Text text;
    private FireBaseScript fbs;
    Vector3 xzV;
    private GameObject preFab;
    //private ParticleSystem burner;
    //private GameObject flamethrower;

    //private ParticleSystem ps;
    //  public ParticleSystem partsys;
    //private fireBaseScript;

    //private Brick burner;


    //float startTemp = 160f;
    public float currentEnvelopeTemp; 
	//float burnAcc = 0;
	//float coolingRate =10
    float moveHorizontal;
    float moveVertical;
    public float burn = .5f;
    float burnLift = 500;
    bool trigger;
    bool trigger2;
    bool burnTrue;
   // float currentUpVelocity;
   

    float burnV;
    float lift = 39300; //unit is Energy m*a




	void Start()
	{
       
		rb = GetComponent<Rigidbody>();
        text = GetComponent<Text>();
        fbs = new FireBaseScript();

        //fbs = GetComponent<FireBaseScript>();
        //fbs = GetComponent<>
        //burner = get;
        //burner.SetParent(parent);
        //Instantiate(burner, transform.position, Quaternion.identity);
        //FixedJoint flamhrower = GetComponent<FixedJoint>();
        //flamethrower = GetComponent<GameObject>();
        //burner = ParticleSystem.Instantiate("FlamethrowerFire");
        // burner.GetComponent<ParticleSystem>().Play;
        //ps = ParticleSystem.Instantiate("fl")
        // Debug.Log(burner.ToString());
        //Fire();


        //burner = GetComponent<FireBaseScript()>();
        //burner = GetComponent<GameObject>();

        //burner = GetComponentsInChildren<ParticleSystem.Instantiate<FlareLayer>>()
        //Invoke ("FixedUpdate", 5.0f);

        //



        //currentEnvelopeTemp = startTemp;
    }
    private void Update()
    {
        
        

        //GameObject burner  = Instantiate(flamethrower);
    }
    void FixedUpdate ()
	{
        //text.text = "" + lift;
        //InvokeRepeating("cooling", 2.0f, 0.3f);
        //while (lift > 0)
        //{
        //Debug.Log(lift);


        Cooling();
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");

        //Input.GetAxis("Burn") ;

            trigger = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger);
            trigger2 = OVRInput.Get(OVRInput.Button.PrimaryTouchpad);
            burnTrue = Input.GetButton("Burn");

           

            Vector3 movementx = new Vector3(0, 0, 500);
            Vector3 movementz = new Vector3(.05f, 0, 0);
            Vector3 angtiG = new Vector3(0, lift, 0);
            //Vector3 burnliftV = new Vector3(0, lift, 0);
            Vector3 liftBurnVector = new Vector3(0, burnLift, 0);

        rb.AddForce(angtiG); // adds constant force to the heat bubble

          //  Debug.Log("Current lift force = " + lift/9.8f);

            

            if (trigger2 == true)
            {
                rb.AddForce(movementx);
            }

        if (trigger == true || burnTrue)// || Input.GetKeyDown(KeyCode.Space))
            {
            //Instantiate(flamethrower);
            // burner = Instantiate(GameObject.Find("FlamethrowerFire"));

            // burner.P

            Invoke("BurnDelay", 3.0f);
            Fire();

        }
           // currentUpVelocity = 0;



       // text.text = "Lifting force" + lift;

    }
        //Debug.Log("deflated");


   // }
	float BurnDelay()
	{
		
        
        Vector3 movementy = new Vector3(0, burn, 0);


		rb.AddForce(movementy);
        
        lift = lift + burn;
        return lift;


       
	}

	void TopOpen ()
	{
		float topOpen = Input.GetAxis ("TopOpen");
	}

    public float Cooling(){

        lift= lift - .1f; //cooling rate
       // Debug.Log("cooling at " + lift);

        return lift;
    }

    public float CurrentUpAcc() {
        return lift;
    }

    void Fire() 
    {
        //fbs.StartParticleSystems();
        fbs.Starting.Equals(true);
        // Instantiate(burner, transform.position, Quaternion.identity);
        //Debug.Log(fbs.Starting);
        //fbs = GameObject.Instantiate(preFab);
        //fbs.Starting = true;
        // fbs.
        //fbs.StartParticleSystems();
        //Instantiate(fbs.Starting.Equals(true), transform.position, Quaternion.identity);
    }




}
//