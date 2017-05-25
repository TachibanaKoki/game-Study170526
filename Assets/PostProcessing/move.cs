using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    [SerializeField]
    float m_Speed = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float speed = Time.deltaTime * m_Speed;
        transform.Rotate(speed, 0, speed);
	}
}
