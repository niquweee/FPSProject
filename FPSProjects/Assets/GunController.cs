using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour {

    public GameObject bullet;
    public Rigidbody rbBullet;
    public int bulletSpeed;
    public Transform playerTransform;
    public GameObject player;
	// Use this for initialization
	void Start () {
        rbBullet = bullet.GetComponent<Rigidbody>();
        bulletSpeed = 2;
	               }

    void Awake()
    {
        bullet = GameObject.Find("Bullet");
        player = GameObject.Find("Player");
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
        rbBullet.AddForce(this.transform.forward * bulletSpeed);
        Debug.Log("peng");
        }

}
