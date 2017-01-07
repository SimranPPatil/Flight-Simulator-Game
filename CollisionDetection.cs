using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour {
    Vector3 init_pos;
    Quaternion init_rot;
	// Use this for initialization
	void Start () {
        init_pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        init_rot = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        Debug.Log("satart col");
    }
	
	
	void  OnCollisionEnter(Collision col) {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name ==  "Terrain")
        {
            Debug.Log("inside col");
            SceneManager.LoadScene("withInstructions");
            transform.Translate(0, 0, 0);
            transform.Rotate(0, 0, 0);
            StartCoroutine(restart());
        }

	  }
    IEnumerator restart()
    {
        yield return new WaitForSeconds(3);
        transform.position = init_pos;
        transform.rotation = init_rot;
        transform.Translate(0,0,0.2f);
    }
}
