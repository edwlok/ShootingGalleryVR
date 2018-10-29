using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour {

    public GameObject score;
    public bool gameOver = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        if (!gameOver)
        {
            if (other.gameObject.tag == "Bullet")
            {
                                
                //this.gameObject.SetActive(false);

                this.gameObject.GetComponent<BoxCollider>().enabled = false;

                for (int i = 0; i < 5; i++)
                {
                    this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
                }

                score.GetComponent<ScoreKeeper>().updateScore();

                StartCoroutine(yieldThreeSec());

            }
        }
    }

    IEnumerator yieldThreeSec()
    {
        yield return new WaitForSeconds(7);

        for (int i = 0; i < 5; i++)
        {
            this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }

        this.gameObject.GetComponent<BoxCollider>().enabled = true;

    }
}
