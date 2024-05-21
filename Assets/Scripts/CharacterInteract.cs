using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteract : MonoBehaviour
{
    [SerializeField] Transform pivot;
    [SerializeField] Vector3 interactAreaSize = Vector3.one;
public void Interact()
    {
        Collider[] colliders = Physics.OverlapBox(pivot.position, interactAreaSize);

        foreach (Collider colider in colliders)
        {
            Interactable interactable = colider.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact();
                break;
            }
        }
    }
}
