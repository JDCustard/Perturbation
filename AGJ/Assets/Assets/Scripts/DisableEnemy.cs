using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject trigger;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            trigger.SetActive(false);
            enemy.SetActive(false);

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
