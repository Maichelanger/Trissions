using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vehicle"))
        {
            GetComponentInParent<CollectiblesController>().CollectibleCollected();
            Destroy(gameObject);
        }
    }
}
