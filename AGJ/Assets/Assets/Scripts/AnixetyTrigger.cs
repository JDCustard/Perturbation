using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class AnixetyTrigger : MonoBehaviour
{

    public GameObject enemy;
    public Volume volume;
    private ChromaticAberration chromaticAberration;
    private LensDistortion lensDistortion;
    public AK.Wwise.Event panicEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            AkSoundEngine.SetState("Game_State", "Anxiety");
            Debug.Log("Anxiety");
            panicEvent.Post(gameObject);



            if(volume.profile.TryGet(out chromaticAberration))
            {
                Debug.Log("CATriggered");
                chromaticAberration.active = true; // Enable the effect
            }

            if (volume.profile.TryGet(out lensDistortion))
            {
                Debug.Log("Triggered");
                lensDistortion.active = true; // Enable the effect
            }

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
