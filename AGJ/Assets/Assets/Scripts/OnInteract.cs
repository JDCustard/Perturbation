using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteract : MonoBehaviour, IInteractable
{
    public float MaxRange { get { return maxRange; } }

    private const float maxRange = 100f;

    public void OnStartHover()
    {
        Debug.Log($"Show UI for {gameObject.name}");
    }

    public void OnItemInteract()
    {
        Debug.Log($"Trigger interact function for {gameObject.name}");
    }

    public void OnEndHover()
    {
        Debug.Log($"Hide UI for {gameObject.name}");
    }
}
