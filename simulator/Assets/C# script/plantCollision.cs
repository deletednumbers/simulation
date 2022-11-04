using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantCollision : MonoBehaviour
{
    public Vector3 plantScale = new Vector3(0,1,0);
    public Vector3 combinedScale;
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
        //subtract one height from tree
        if(other.gameObject.tag == "creature")
        {
        	if(gameObject.transform.localScale.y > new Vector3(0,0,0).y){
       		combinedScale = gameObject.transform.localScale - plantScale;
		gameObject.transform.localScale = combinedScale;
		}
	}
    }
}
