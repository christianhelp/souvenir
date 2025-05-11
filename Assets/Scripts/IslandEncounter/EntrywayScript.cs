using UnityEngine;
using UnityEngine.SceneManagement;
public class EntrywayScript : MonoBehaviour
{
    public Player player;
    public AudioSource audioSource;
    public AudioClip entrySound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has entered the trigger");
        if (other.CompareTag(ProjectConstants.TAG_NAME) && player.inventory.Contains(ProjectConstants.SOUVENIR_NAME))
        {
            // change material of the blank fuse to all black
            Debug.Log("Player has entered the trigger");
            PlayerPrefs.SetString("SceneName", "FirstExploration");
            audioSource.resource = entrySound;
            audioSource.Play();
            // load into the next scene 
            SceneManager.LoadScene("FirstExploration");
        }
    }
}
