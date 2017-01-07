using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FPS : MonoBehaviour {

    // Use this for initialization
    Rect fpsRect;
    GUIStyle style;
    float fps;

	void Start () {
        fpsRect = new Rect(100, 100, 400, 100);
        style = new GUIStyle();
        style.fontSize = 30;
        StartCoroutine(RecalculateFPS());
	}
	
    private IEnumerator RecalculateFPS()
    {
        while(true)
        {
            fps = 1 / Time.deltaTime;
            yield return new WaitForSeconds(1);
        }
    }

    void OnGUI()
    {
        GUI.Label(fpsRect, "FPS: " + fps, style);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
