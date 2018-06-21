using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

    public List<GameObject> guns = new List<GameObject>();
    public int listIterator;

	// Use this for initialization
	void Awake ()
        {
        foreach (GameObject addObj in GameObject.FindGameObjectsWithTag("Gun"))
            {
                guns.Add(addObj);
            }
            listIterator = 0;
        }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("1"))
        {
            guns[0].SetActive(true);
            guns[1].SetActive(false);
        }
      

    }
}
