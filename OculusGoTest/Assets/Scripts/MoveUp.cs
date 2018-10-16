using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)){
            this.transform.Translate(Vector3.up * 5, Space.World);
        }
	}
}
