using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] menuObjs;
    public GameObject playerHitbox;
    public TerrainCreator terrainCreatorScript;
    // Start is called before the first frame update
    void Start()
    {
        terrainCreatorScript = GetComponent<TerrainCreator>();
    }

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowScreen(int menuobjIndex)
    {
        menuObjs[menuobjIndex].gameObject.SetActive(true); 

    }

    public void DisableScreen(int menuobjIndex)
    {
        menuObjs[menuobjIndex].gameObject.SetActive(false);
    }

    public void ReloadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void TimeScale(float timeScaleFloat)
    {
        Time.timeScale = timeScaleFloat;
    }
}
