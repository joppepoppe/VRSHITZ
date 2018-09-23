using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakMe : MonoBehaviour {
    public GameObject window1;
    // Use this for initialization
    void Start () {
        window1 = GameObject.Find("Window");
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") // this string is your newly created tag
        {

            window1.GetComponent<BreakableWindow>().breakWindow();
            
        }
    }
}
