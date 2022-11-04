using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosiveJump : MonoBehaviour
{
	Rigidbody m_Rigidbody;
    public float whatTime;
    public float jumpTime;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        whatTime = Time.deltaTime;
        jumpTime = whatTime + 1f;
    }

    // Update is called once per frame
    void Update()
    {
    	whatTime += Time.deltaTime;
    
        if (jumpTime <= whatTime)
	{

	m_Rigidbody.AddRelativeForce(new Vector3(0,1,1) * 100);
//	m_Rigidbody.AddTorque(new Vector3(1,0,0) * 1);
	jumpTime = whatTime + 0.2f;
	}
	
	if (whatTime >= 12f)
	{
	whatTime = Time.deltaTime;
        jumpTime = whatTime + 1f;
	}
    }
}
