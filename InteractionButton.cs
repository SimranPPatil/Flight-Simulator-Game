using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;
using UnityEngine.UI;

public class InteractionButton : MonoBehaviour {
    GameObject button;
    [SerializeField]
    private Button m_Button;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(m_Button.colors.normalColor == Color.green)
        { Debug.Log("green hai re baba"); }
	}
}
