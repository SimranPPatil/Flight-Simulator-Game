using UnityEngine;
using System.Collections;

public class Simulation : MonoBehaviour {
    float speed, acc;
    public static float flag;
    // Use this for initialization
    void Start () {
        speed = 0.1F;
        acc = 0;
        flag = 0;
	}
	
	// Update is called once per frame
	void Update () {

        float pitch = Input.GetAxis("Pitch")*0.25F;
        transform.Rotate(pitch, 0, 0);
        float yaw_roll = Input.GetAxis("Yaw/Roll")*0.15F;
        transform.Rotate(0, yaw_roll, -yaw_roll);
        acc = Input.GetAxis("Acc/Dec")*0.5F;
        speed -= acc*Time.deltaTime;
        speed = Mathf.Max(speed, 0.1F);
        if (flag == 0)
            speed = 0;
      transform.Translate(0, 0, speed);
        //Debug.Log(speed);


    }
}
