using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour {

    public float pong;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(-Mathf.PingPong(Time.time, pong), transform.position.y, transform.position.z);
    }
}
