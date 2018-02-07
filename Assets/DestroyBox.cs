using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour {

    // Use this for initialization

    
    public GameObject axe;
    public int boxHealth;

	void Start () {

        
        PlayerPrefs.SetInt("boxHealth", boxHealth);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "pickaxe")
        {


            PlayerPrefs.SetInt("boxHealth", PlayerPrefs.GetInt("boxHealth") - 2);


        }

    }

}
