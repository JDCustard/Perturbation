using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWall : MonoBehaviour
{
    [SerializeField]
    private GameObject rmwall;
    [SerializeField]
    private GameObject addwall;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rmwall.SetActive(false);
            addwall.SetActive(true);
        }
    }
}
