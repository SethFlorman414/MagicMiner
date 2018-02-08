using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingHealth : MonoBehaviour {

    // Use this for initialization

    public int toxins;
    public GameObject pillBottle;
    public GameObject particleHealth;
    

	void Start () {

        PlayerPrefs.SetInt("Toxins", toxins);

	}
	
	// Update is called once per frame
	void Update () {

        toxins = PlayerPrefs.GetInt("Toxins");

	}


   public void OnControllerColliderHit(ControllerColliderHit collision)
    {
        
        if(collision.gameObject.tag == "health")
        {
            
            PlayerPrefs.SetInt("Toxins", PlayerPrefs.GetInt("Toxins") - 15);
            Debug.Log(toxins);
            Destroy(pillBottle);
            Destroy(particleHealth);
            

        }



    }

}
