using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent<PlayerCharacter> onIteract;

    public void Interact(PlayerCharacter playerCharacter)
    {
        onIteract?.Invoke(playerCharacter);
    }
}
