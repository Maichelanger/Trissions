using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectiblesController : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshProUGUI collectiblesText;

    private int collectiblesCount = 0;

    private void Awake()
    {
        collectiblesCount = transform.childCount;
        collectiblesText.text = collectiblesCount.ToString();
        winPanel.SetActive(false);
    }

    public void CollectibleCollected()
    {
        collectiblesCount--;
        collectiblesText.text = collectiblesCount.ToString();

        if (collectiblesCount == 0)
        {
            StartCoroutine(GameOver());
        }
    }

    private IEnumerator GameOver()
    {
        winPanel.SetActive(true);

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
