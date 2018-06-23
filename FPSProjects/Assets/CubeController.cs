using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    public bool isOn;
    public GameObject destination;
    public GameObject enemyPrefab;
    public Vector3 destinationPos;
    public List <GameObject> patrolPoints = new List<GameObject>();
    public int moveSpeed;
    public int patrolLength;
    public int iterator;
    public int health = 10;
    public bool isDead;
    


    private void Awake()
    {

        foreach (GameObject addObj in GameObject.FindGameObjectsWithTag("PatrolStation"))
        patrolPoints.Add(addObj);
        patrolLength = patrolPoints.Count;
        iterator = 0;
    }
    // Use this for initialization
    void Start ()
        {
        Debug.Log(patrolLength);
        }
	
	// Update is called once per frame
	void Update () {

        if (health <= 0)
        {
            isDead = true;
           

        }
        Debug.Log(iterator);
        if (isOn)
        {
            movementEnemy();
        }

    }

   public void movementEnemy()
    {
       

          if (iterator <= patrolLength - 1)
                  {

                   transform.position = Vector3.MoveTowards(transform.position, patrolPoints[iterator].transform.position, moveSpeed * Time.deltaTime);
                   if (transform.position == patrolPoints[iterator].transform.position)
                       {

                       iterator++;
                       }
                  }
          else
            {
                iterator = 0;
            }


    }



    void OnTriggerEnter()
    {
        health -= 1;
    }


}
