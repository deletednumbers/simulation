using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantTallBehavior : MonoBehaviour
{
    public float whatTime;
    public float growTime;
    public float seedTime;
    public Vector3 plantScale = new Vector3(0,1,0);
    public Vector3 combinedScale;
    public int generationLimit = 5;
    public int maxNeighbors = 5;
    public int countNeighbors = 0;
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        whatTime = Time.deltaTime;
        growTime = whatTime + 20f;
        seedTime = whatTime + 10f;
    }

    // Update is called once per frame
    void Update()
    {
	    whatTime += Time.deltaTime;
	
	    if (growTime <= whatTime)
	    {
		    if(gameObject.transform.localScale.y < new Vector3(0,12,0).y )
		    {
		        combinedScale = gameObject.transform.localScale + plantScale;
		        gameObject.transform.localScale = combinedScale;
		        growTime = whatTime + 20f;
		    }
	    }
	
	    if (whatTime >= 60f)
	    {
		    whatTime = Time.deltaTime;
		    growTime = whatTime + 20f;
		    seedTime = whatTime + 10f;
	    }
	

		// Instantiate at position (0, 0, 0) and zero rotation.
		//Instantiate(myPrefab, new Vector3(20, 2, 0), Quaternion.identity);

    }
}
