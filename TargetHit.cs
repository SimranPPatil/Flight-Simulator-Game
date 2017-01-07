using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TargetHit : MonoBehaviour {
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere0;
    public Text ScoreText;
    public float score;
    public float fps;
    // Use this for initialization
    void Start () {
        score = 0;
	}

    // Update is called once per frame
    void Update() {


        fps = 1.0f/Time.deltaTime;
       if (sphere3.GetComponent<SphereCollider>().enabled == false )
       {
            if (sphere3.GetComponent<MeshRenderer>().enabled == true)
                UpdateScore();
            sphere3.GetComponent<MeshRenderer>().enabled = false;
            sphere3.GetComponent<SphereCollider>().enabled = true;
            StartCoroutine(Disappear(sphere3));
        }
       else if (sphere2.GetComponent<SphereCollider>().enabled == false )
        {
            if (sphere2.GetComponent<MeshRenderer>().enabled == true)
                UpdateScore();
            sphere2.GetComponent<MeshRenderer>().enabled = false;
            sphere2.GetComponent<SphereCollider>().enabled = true;
            StartCoroutine(Disappear(sphere2));
        }
        else if (sphere1.GetComponent<SphereCollider>().enabled == false )
        {
            if (sphere1.GetComponent<MeshRenderer>().enabled == true)
                UpdateScore();
            sphere1.GetComponent<MeshRenderer>().enabled = false;
            sphere1.GetComponent<SphereCollider>().enabled = true;
            StartCoroutine(Disappear(sphere1));
        }
        else if (sphere0.GetComponent<SphereCollider>().enabled == false)
        {
            if (sphere0.GetComponent<MeshRenderer>().enabled == true)
                UpdateScore();
            sphere0.GetComponent<MeshRenderer>().enabled = false;
            sphere0.GetComponent<SphereCollider>().enabled = true;
            StartCoroutine(Disappear(sphere0));
        }

      AddScore(score);
    }

    IEnumerator Disappear(GameObject sphere)
    {
      //  UpdateScore();
        yield return new WaitForSeconds(5);
        sphere.GetComponent<MeshRenderer>().enabled = true;
      

    }
    void UpdateScore()
    {
        score += 1f;
    }

    void AddScore (float score)
    {
        ScoreText.text = "Score:" + score.ToString();
    }
}
