using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predatorCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "creature")
        {
        predatorBehavior predator = gameObject.GetComponent(typeof(predatorBehavior)) as predatorBehavior;

	if(predator.hunger <90)
		{
        	predator.hunger += 10;
        	}
        } 
        
        if(other.gameObject.tag == "apex")
        {
    		Destroy(gameObject);
        }   
    }
}


