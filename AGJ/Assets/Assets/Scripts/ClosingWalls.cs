using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK;
using AK.Wwise;



public class ClosingWalls : MonoBehaviour
{
    Animator _Anim;

    CharacterController cc;

    [SerializeField]
    private GameObject _playerlight;

    [SerializeField]
    private GameObject _roomlight;

    [SerializeField]
    private GameObject _PlayerCapsule;

    public AK.Wwise.Event ClosingWallsEvent;
    public AK.Wwise.Event ClosingWallsStopEvent;

    private void TeleportPlayer()
    {
        cc.enabled = false;
        _PlayerCapsule.transform.position = new Vector3(29, 0, 6);
        cc.enabled = true;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(9);
        _playerlight.SetActive(false);
        _roomlight.SetActive(false);
        yield return new WaitForSeconds(1);
        TeleportPlayer();
        yield return new WaitForSeconds(3);
        _playerlight.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        _Anim.SetBool("Play", true);
        ClosingWallsEvent.Post(gameObject);
        StartCoroutine(waiter());
    }

    private void OnTriggerExit(Collider other)
    {

        ClosingWallsStopEvent.Post(gameObject);
        // AKSoundEngine.ExecuteActionOnEvent(ClosingWallsEvent.Id, AkActionOnEventType.AkActionOnEventType_Stop, gameObject, fadeOutDuration * 1000, AkCurveInterpolation.AkCurveInterpolation_Sine);

    }

    // Start is called before the first frame update
    void Start()
    {
        _Anim = this.transform.parent.GetComponent<Animator>();
        cc = _PlayerCapsule.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
