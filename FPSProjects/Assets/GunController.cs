using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject bulletEmpty;
    public Transform bulletSpawn;
    public bool isFired;
    public float gunFireRate = 1.0f;


     void Start()
    {
        gameObject.SetActive(false);
        bulletSpawn = bulletEmpty.GetComponent<Transform>();
    }

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            StartCoroutine(Fire(gunFireRate));
        }

    }

    IEnumerator Fire(float fireRate)
    {
        // Create the Bullet from the Bullet Prefab
       
        
            GameObject clone;
        if (!isFired)
        {

            clone = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * 2000);
            isFired = true;
            yield return new WaitForSeconds(fireRate);
           Destroy(clone, 1.0f);
            isFired = false;

        }
       
        


    }
}

