using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour {

    public GameObject cube;
    public List<GameObject> enemies;
    public GameObject enemyPrefab;
    public bool isDead;



    private void Start()
    {
        enemies = cube.GetComponent<CubeController>().patrolPoints;

    }


    void Update()
    {
        if (cube != null)
        {
            isDead = cube.GetComponent<CubeController>().isDead;
        }

        if (isDead && cube!=null)

           
        StartCoroutine(Respawn());      
                }

    IEnumerator Respawn()
    {

        Destroy(cube);
        yield return new WaitForSeconds(1.0f);
        Instantiate(enemyPrefab, enemies[4].transform.position, enemies[4].transform.rotation);
        cube = GameObject.Find("Enemy(Clone)");


    }

}





