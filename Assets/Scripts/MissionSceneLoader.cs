using UnityEngine;

public class MissionSceneLoader : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    public void LoadMission()
    {
        Debug.Log("Mission loaded!");
    }
}
