using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predator2Collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "creature2")
        {
            predator2Behavior predator = gameObject.GetComponent(typeof(predator2Behavior)) as predator2Behavior;

	        if(predator.hunger <88)
		    {
          	predator.hunger += 12;
        	}
        } 
        /*
        if(other.gameObject.tag == "creature")
        {
          predatorBehavior predator = gameObject.GetComponent(typeof(predatorBehavior)) as predatorBehavior;

	        if(predator.hunger <88)
		      {
          	predator.hunger += 12;
        	}
        } 
        */
        if(other.gameObject.tag == "apex")
        {
            apexBehavior apex = other.gameObject.GetComponent(typeof(apexBehavior)) as apexBehavior;
    	    Debug.Log(apex.hunger);
            if (apex.hunger<97)
            {
                Destroy(gameObject);
                Debug.Log("MAIN COURSE");
            }
        }   
    }
}


