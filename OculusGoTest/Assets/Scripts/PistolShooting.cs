using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform spawnPos;
    public float force = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnPos.position, spawnPos.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * force);

            Destroy(bullet, 3f);
        }
	}
}
