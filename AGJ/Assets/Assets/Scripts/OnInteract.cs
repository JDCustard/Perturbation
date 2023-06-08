using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnInteract : MonoBehaviour, IInteractable
{
    public float MaxRange { get { return maxRange; } }

    private const float maxRange = 100f;
    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private GameObject interactPanel;
    [SerializeField] private TextMeshProUGUI headingText;
    [SerializeField] private TextMeshProUGUI bodyText;
    [SerializeField] private string heading;
    [SerializeField] private string body;

    private bool IsPanelShowing = false;
    public void OnStartHover()
    {
        Debug.Log($"Show UI for {gameObject.name}");
        interactPanel.SetActive(true);
    }

    public void OnItemInteract()
    {
        Debug.Log($"Trigger interact function for {gameObject.name}");
        if (IsPanelShowing == false)
        {
            headingText.text = heading;
            bodyText.text = body;
            IsPanelShowing = true;
            dialogPanel.SetActive(true);
        }
        else
        {
            IsPanelShowing = false;
            dialogPanel.SetActive(false);
        }
    }

    public void OnEndHover()
    {
        Debug.Log($"Hide UI for {gameObject.name}");
        interactPanel.SetActive(false);
        if (IsPanelShowing == true)
        {
            IsPanelShowing = false;
            dialogPanel.SetActive(false);
        }
    }
}
