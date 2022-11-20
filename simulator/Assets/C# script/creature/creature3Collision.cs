using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creature3Collision : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "Tree3")
        {
        creature3Behavior creature = gameObject.GetComponent(typeof(creature3Behavior)) as creature3Behavior;

	        if(creature.hunger <95)
		    {
            	creature.hunger += 5;
        	}
        }
        if(other.gameObject.tag == "Tree")
        {
        creature3Behavior creature = gameObject.GetComponent(typeof(creature3Behavior)) as creature3Behavior;

	        if(creature.hunger <95)
		    {
            	creature.hunger += 5;
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
        if(other.gameObject.tag == "predator")
        {
            predatorBehavior predator = other.gameObject.GetComponent(typeof(predatorBehavior)) as predatorBehavior;

            if (predator.hunger<88)
            {
                Destroy(gameObject);
            }
        }
    }
}
