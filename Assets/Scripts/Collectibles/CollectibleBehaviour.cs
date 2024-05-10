using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour
{
    [SerializeField] GameObject soundEffectPrefab;

    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vehicle") && !collected)
        {
            collected = true;
            GameObject soundInstance = Instantiate(soundEffectPrefab, transform.position, Quaternion.identity);
            soundInstance.transform.parent = null;
            GetComponentInParent<CollectiblesController>().CollectibleCollected();
            Destroy(gameObject);
        }
    }
}
