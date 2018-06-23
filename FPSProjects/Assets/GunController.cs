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
    public int bulltesMag;
    public bool isReloading;
    public Animator anim;
     void Start()
    {
        gameObject.SetActive(false);
        bulletSpawn = bulletEmpty.GetComponent<Transform>();
        bulltesMag = 10;
    }

    void Update()
    {

        if (Input.GetMouseButton(0) && !isReloading)
        {
            StartCoroutine(Fire(gunFireRate));
        }

        if (bulltesMag <= 0)
        {
            StartCoroutine(ReloadGun());
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
            bulltesMag--;
            yield return new WaitForSeconds(fireRate);
            Destroy(clone, 1.0f);
            isFired = false;
            

        }
       
       
        


    }
    IEnumerator ReloadGun()
    {
        isReloading = true;
        anim.SetBool("isAnimReloading", true);
        yield return new WaitForSeconds(2.5f);
        anim.SetBool("isAnimReloading", false);
        isReloading = false;
        bulltesMag = 10;

    }
}

