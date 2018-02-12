using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeRelic : MonoBehaviour {

    // Use this for initialization

    public GameObject angel;
    public GameObject door;

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public GameObject wall6;
    public GameObject wall7;
    public GameObject wall8;
    public GameObject angelStatue1;
    public GameObject angelStatue2;

    public Texture newWallTexture;
    public Texture otherWallTexture;
    public Texture moreWallTexture;
    public Texture backWallTexture;
    public Texture newNewWallTexture;

    public Texture angelTexture;



	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerExit(Collider collide)
    {
        
        if(collide.gameObject.tag == "Angel")
        {

            door.SetActive(true);
            wall1.GetComponent<Renderer>().material.mainTexture = otherWallTexture;
            wall2.GetComponent<Renderer>().material.mainTexture = newNewWallTexture;
            wall3.GetComponent<Renderer>().material.mainTexture = moreWallTexture;
            wall4.GetComponent<Renderer>().material.mainTexture = newWallTexture;
            wall5.GetComponent<Renderer>().material.mainTexture = newWallTexture;
            wall6.GetComponent<Renderer>().material.mainTexture = newWallTexture;
            wall7.GetComponent<Renderer>().material.mainTexture = newWallTexture;
            wall8.GetComponent<Renderer>().material.mainTexture = backWallTexture;

            angelStatue1.GetComponent<Renderer>().material.mainTexture = angelTexture;
            angelStatue2.GetComponent<Renderer>().material.mainTexture = angelTexture;


        }


    }

}


