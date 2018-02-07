using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingHealth : MonoBehaviour {

    // Use this for initialization

    public int toxins;
    public GameObject pillBottle;
    

	void Start () {

        PlayerPrefs.SetInt("Toxins", toxins);

	}
	
	// Update is called once per frame
	void Update () {
		


	}


   public void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "health")
        {

            PlayerPrefs.SetInt("Toxins", PlayerPrefs.GetInt("Toxins") - 15);
            Destroy(pillBottle);
            

        }



    }

}
