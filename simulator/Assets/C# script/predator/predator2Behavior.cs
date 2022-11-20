using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predator2Behavior : MonoBehaviour
{
	Rigidbody m_Rigidbody;
    public float m_Thrust = 200f;
    public float rightTime;
    public float forwardTime;
    public float whatTime;
    public float hungerTime;
    public int hunger;
    public GameObject myPrefab;
    public int whichway;

    // Start is called before the first frame update
    void Start()
    {
    //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        whatTime = Time.deltaTime;
	rightTime = whatTime + 3.0f;
        forwardTime = whatTime + 4.0f;
        hungerTime = whatTime + 1.0f;
        hunger = 50;
        
    //Apply a force to this Rigidbody in direction of this GameObjects up axis

    }
	
    // Update is called once per frame
    void Update()
    {
	whichway = Random.Range(0,2);

	whatTime += Time.deltaTime;

	if (rightTime <= whatTime)
	{
		if(whichway == 0){m_Rigidbody.AddRelativeForce(transform.right * m_Thrust);
		rightTime = whatTime + 6.0f;}
		if(whichway == 1){m_Rigidbody.AddRelativeForce(-transform.right * m_Thrust);
		rightTime = whatTime + 6.0f;}
	}
	
	if (forwardTime <= whatTime)
	{
		if(whichway == 0){m_Rigidbody.AddRelativeForce(transform.forward * m_Thrust);
		forwardTime = whatTime + 8.0f;}
		if(whichway == 1){m_Rigidbody.AddRelativeForce(-transform.forward * m_Thrust);
		forwardTime = whatTime + 8.0f;}
	}
	
	if (hungerTime <= whatTime)
	{
	hunger -= 1;
	hungerTime = whatTime + 1.0f;
	}
	
	if (whatTime >= 12f)
	{
	hunger -= 1;
	whatTime = Time.deltaTime;
	forwardTime = whatTime + 8.0f;
	rightTime = whatTime + 6.0f;
	hungerTime = whatTime + 1.0f;
		if(hunger >= 60)
    	{
			// Instantiate at position (0, 0, 0) and zero rotation.
			Vector3 here = gameObject.transform.position;
			//Instantiate(myPrefab, new Vector3(20, 2, 0), Quaternion.identity);
			Instantiate(myPrefab, here, Quaternion.identity);
			myPrefab.name = "predator2";
		}
	}
	
	//creature starves and is destroyed
	if(hunger <= 0)
    	{
    	Destroy(gameObject);
    	}


	
    }
}
