using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingCreatureCollision : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "Tree")
        {
        flyingCreatureBehavior creature = gameObject.GetComponent(typeof(flyingCreatureBehavior)) as flyingCreatureBehavior;

		    {
            	creature.hunger += 4;
        	}
        }
        
        if(other.gameObject.tag == "predator")
        {
            predatorBehavior predator = other.gameObject.GetComponent(typeof(predatorBehavior)) as predatorBehavior;
    	    Debug.Log(predator.hunger);
            if (predator.hunger<88)
            {
                Destroy(gameObject);
                Debug.Log("destroyed");
            }
            
        }
        //subtract one height from tree
        
    }
}
