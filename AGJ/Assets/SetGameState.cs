using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AkSoundEngine.SetState("Game_State", "Calm");
            Debug.Log("Calm");
         
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AkSoundEngine.SetState("Game_State", "Normal");

            Debug.Log("Normal");
        }
    }
}

