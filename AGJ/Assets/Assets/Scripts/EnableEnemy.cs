using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemy : MonoBehaviour
{
    public GameObject enemy;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enemy.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
