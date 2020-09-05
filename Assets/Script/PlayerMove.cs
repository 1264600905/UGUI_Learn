using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public Camera MainCamera;
   // public GameObject Emeny;
    private float X;
    private float Y;
    private Rigidbody Player;
    public float Speed=3;

    public Vector3 Instance { get; private set; }

    // Use this for initialization
    void Start () {
        Player = this.GetComponent<Rigidbody>();
         Instance = MainCamera.transform.position - Player.position;
	}
	
	// Update is called once per frame
	void Update () {
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");
        Vector3 MoveDe = new Vector3(X*Speed,0, Y*Speed);
        Player.AddForce(MoveDe,ForceMode.Force);
        Vector3 Pos1 = MainCamera.transform.position;
        MainCamera.transform.position = Player.position + Instance;
	}
}
