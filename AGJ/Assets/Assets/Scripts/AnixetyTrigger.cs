using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class AnixetyTrigger : MonoBehaviour
{

    public GameObject enemy;
    public Volume volume;
    private ChromaticAberration chromaticAberration;
    public AK.Wwise.Event panicEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            AkSoundEngine.SetState("Game_State", "Anxiety");
            Debug.Log("Anxiety");
            panicEvent.Post(gameObject);


            VolumeProfile volumeProfile = volume.profile;
            if (volumeProfile.TryGet(out chromaticAberration))
            {
                // Modify the properties of ChromaticAberration as desired
                chromaticAberration.active = true; // Enable the effect
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
