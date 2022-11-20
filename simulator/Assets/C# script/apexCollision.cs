using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apexCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "predator")
        {
            apexBehavior apex = gameObject.GetComponent(typeof(apexBehavior)) as apexBehavior;

	        if(apex.hunger <97)
		        {
        	        apex.hunger += 3;
        	    }
        }    
        if(other.gameObject.tag == "predator2")
        {
            apexBehavior apex = gameObject.GetComponent(typeof(apexBehavior)) as apexBehavior;

	        if(apex.hunger <97)
		        {
        	        apex.hunger += 3;
        	    }
        }    
        if(other.gameObject.tag == "predator3")
        {
            apexBehavior apex = gameObject.GetComponent(typeof(apexBehavior)) as apexBehavior;

	        if(apex.hunger <97)
		        {
        	        apex.hunger += 3;
        	    }
        }    
    }
}
