using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuHandler : MonoBehaviour
{// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        // Load the scene
        SceneManager.LoadScene("ExplorationStart");
    }

    public void QuitGame()
    {
        // Quit the game
        Debug.Log("Quit the game");
        Application.Quit();
    }

    public void RestartGame()
    {
        // Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
