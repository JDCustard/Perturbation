using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class SetGameState : MonoBehaviour
{
    public Volume volume;
    private ChromaticAberration chromaticAberration;
    private LensDistortion lensDistortion;

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

            if (volume.profile.TryGet(out chromaticAberration))
            {
                Debug.Log("CA-off");
                chromaticAberration.active = false; // Enable the effect
            }

            if (volume.profile.TryGet(out lensDistortion))
            {
                Debug.Log("LD-off");
                lensDistortion.active = false; // Enable the effect
            }

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

