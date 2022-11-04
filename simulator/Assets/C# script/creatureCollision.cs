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

	if(creature.hunger <98)
		{
        	creature.hunger += 2;
        	}
        }
        
        if(other.gameObject.tag == "predator")
        {
    	Destroy(gameObject);
        }
        //subtract one height from tree
        
    }
}
