using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour {

    public float AliveTime;

	// Use this for initialization
	void Awake () {
        Destroy(gameObject, AliveTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
