using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creature2Collision : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "Tree2")
        {
        creature2Behavior creature = gameObject.GetComponent(typeof(creature2Behavior)) as creature2Behavior;

	        if(creature.hunger <95)
		    {
            	creature.hunger += 5;
        	}
        }
        if(other.gameObject.tag == "Tree3")
        {
        creature2Behavior creature = gameObject.GetComponent(typeof(creature2Behavior)) as creature2Behavior;

	        if(creature.hunger <95)
		    {
            	creature.hunger += 5;
        	}
        }
        
        if(other.gameObject.tag == "predator2")
        {
            predator2Behavior predator = other.gameObject.GetComponent(typeof(predator2Behavior)) as predator2Behavior;

            if (predator.hunger<88)
            {
                Destroy(gameObject);
            }
            
        }
        if(other.gameObject.tag == "predator3")
        {
            predator3Behavior predator = other.gameObject.GetComponent(typeof(predator3Behavior)) as predator3Behavior;

            if (predator.hunger<88)
            {
                Destroy(gameObject);
            }
        }
    }
}
