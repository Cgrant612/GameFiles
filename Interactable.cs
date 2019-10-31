using UnityEngine;

[RequireComponent(typeof(Collider))]

public class Interactable : MonoBehaviour
{
    public void Interact(GameObject fromObject)
    {
        Debug.Debug.LogFormat("Got me!", fromObject);
    }
}
