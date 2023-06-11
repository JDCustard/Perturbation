using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    [SerializeField]
    private GameObject TextPanel;
    [SerializeField]
    private TextMeshProUGUI bodytext;
    [SerializeField]
    private string text;
    [SerializeField]
    private GameObject volume;


    IEnumerator waiter()
    {
        bodytext.text = text;
        TextPanel.SetActive(true);
        yield return new WaitForSeconds(10);
        TextPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(waiter());
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
