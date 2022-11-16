using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatureCollision : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "Tree")
        {
        creatureBehavior creature = gameObject.GetComponent(typeof(creatureBehavior)) as creatureBehavior;

	        if(creature.hunger <96)
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
