using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    [SerializeField]
    private GameObject EndingTrigger;

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
        EndingTrigger.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        _Anim.SetBool("Play", true);
        StartCoroutine(waiter());
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
