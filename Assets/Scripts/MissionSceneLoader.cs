using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSceneLoader : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    public void LoadMission()
    {
        StartCoroutine(LateLoadMission());
    }

    IEnumerator LateLoadMission()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneIndex);
    }
}
