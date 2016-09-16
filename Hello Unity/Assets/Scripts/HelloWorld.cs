using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {
    int myUpdateNumber = 0;
	// Use this for initialization
	void Start () {
        int myNumber = 7;
        Debug.Log(myNumber + "This is my Original Number;");
        myNumber = myNumber + 2;
        Debug.Log(myNumber + "This is my Final Number");
        Debug.Log("Hello World.");
        Debug.Log(myNumber + "This is my Final Number");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(myUpdateNumber + "This is my Original Number;");
        myUpdateNumber = myUpdateNumber + 1;
        Debug.Log(myUpdateNumber + "This is my Final Number");
    }
}
