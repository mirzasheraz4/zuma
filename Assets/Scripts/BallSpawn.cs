using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    
    public GameObject[] BallArray;
    List<int> BallsList;
    void Start()
    {
        InvokeRepeating("SpawnBalls",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnBalls()
    {
        int index = Random.Range(0, BallArray.Length);
        Instantiate(BallArray[index], transform.position, transform.rotation);
        //BallsList.Add(index);
    }
}
