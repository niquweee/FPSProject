using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	               }

    void Awake()
    {
     
    }
    // Update is called once per frame
    void FixedUpdate ()
    {
	    if(Input.GetMouseButton(0))
            {
            Shoot();
            }
    }

    public void Shoot()
        {
      
        }

}
