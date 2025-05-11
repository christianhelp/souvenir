using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MainMenuHandler : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        // Quit the game
        Debug.Log("Quit the game");
        Application.Quit();
    }

    public void RestartGame()
    {
        string previousScene = PlayerPrefs.GetString("SceneName", "IslandEncounter");
        // Restart the game
        SceneManager.LoadScene(previousScene);
    }

    public void LoadOptionsMenu()
    {
        // Load the options menu
        SceneManager.LoadScene("OptionsMenu");
    }
}
