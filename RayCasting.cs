using UnityEngine;
using System.Collections;

public class RayCasting : MonoBehaviour {
  // public GameObject temp;
    public float timer = 0;
   

    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray targetRay = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward*50000);
        float fired = Input.GetAxis("Shoot");
       // Debug.Log(fired);
        if (Input.GetButton("Shoot"))
       {
       //     Debug.Log("shot");
           if(Physics.Raycast(targetRay, out hit))
           {
                
                if (hit.collider.tag == "Target")
                {
                   hit.collider.enabled = false;
                    Debug.Log("hit");
                   // score += 10;
                 
                }
            }
        }
	}

    
}
