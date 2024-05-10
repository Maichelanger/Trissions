using System.Collections;
using UnityEngine;

public class LateDestroyBehaviour : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LateDestroy());
    }

    IEnumerator LateDestroy()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
