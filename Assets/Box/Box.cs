using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    [SerializeField] public int size = 1;
	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(size, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {


    }
}
