using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10;
    private float Speed; 
	// Use this for initialization
	void Start () {
        Speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up*Time.deltaTime*Speed);
	}
    public void OnSorrllChange(float X)
    {
        
        Speed = X *speed*5;
    }
}
