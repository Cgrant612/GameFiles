using UnityEngine;

public class Interacting : MonoBehaviour
{
    [SerializeField] KeyCode interactionKey = KeyCode.E;

    [SerializeField] float interactingRange = 2;

    void Update()
    {
        if (Input.GetKeyDown(InteractionKey))
        {
            AttemptInteraction();
        }
    }
    void AttemptInteraction()
    {
        var ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        var everythingExceptPlayers = ~(1 << LayerMask.NameToLayer("Player"));

        var layerMask = Physics.DefaultRaycastlayers & everythingExceptPlayers;

        if (Physics.Raycast(ray, out hit, interactingRange, layerMask))
        {
            var interactable = hit.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact(this.gameObject);
            }
        }
    }
}