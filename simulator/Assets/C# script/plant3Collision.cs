using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant3Collision : MonoBehaviour
{
    public Vector3 plantScale = new Vector3(0,1,0);
    public Vector3 combinedScale;

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnCollisionEnter(Collision other)
    {    
        //subtract one height from tree
        if(other.gameObject.tag == "creature3")
        {
            creature3Behavior creature = other.gameObject.GetComponent(typeof(creature3Behavior)) as creature3Behavior;

            if (creature.hunger<95)
            {
        	    if(gameObject.transform.localScale.y > new Vector3(0,0,0).y)
                {
       		        combinedScale = gameObject.transform.localScale - plantScale;
		            gameObject.transform.localScale = combinedScale;
                }
		    }
	    }
        /*
        if(other.gameObject.tag == "creature")
        {
            creatureBehavior creature = other.gameObject.GetComponent(typeof(creatureBehavior)) as creatureBehavior;

            if (creature.hunger<95)
            {
        	    if(gameObject.transform.localScale.y > new Vector3(0,0,0).y)
                {
       		        combinedScale = gameObject.transform.localScale - plantScale;
		            gameObject.transform.localScale = combinedScale;
                }
		    }
	    }
        */
    }
}