using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatureCollision : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "Tree")
        {
        creatureBehavior creature = gameObject.GetComponent(typeof(creatureBehavior)) as creatureBehavior;

	        if(creature.hunger <95)
		    {
            	creature.hunger += 5;
        	}
        }
        if(other.gameObject.tag == "Tree2")
        {
        creatureBehavior creature = gameObject.GetComponent(typeof(creatureBehavior)) as creatureBehavior;

	        if(creature.hunger <95)
		    {
            	creature.hunger += 5;
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
        if(other.gameObject.tag == "predator2")
        {
            predator2Behavior predator = other.gameObject.GetComponent(typeof(predator2Behavior)) as predator2Behavior;

            if (predator.hunger<88)
            {
                Destroy(gameObject);
            }
        }
    }
}
