using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayButton : MonoBehaviour
{
    public string sceneName;
    public TMP_Text startGameText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneName = PlayerPrefs.GetString("SceneName", "IslandEncounter");
        if (sceneName == "IslandEncounter")
        {
            startGameText.text = "Play";
        }
        else
        {
            startGameText.text = "Continue";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        // Load the scene
        SceneManager.LoadScene(sceneName);
    }
}
