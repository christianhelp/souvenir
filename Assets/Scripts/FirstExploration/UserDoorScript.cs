using UnityEngine;
using UnityEngine.SceneManagement;

public class UserDoor : MonoBehaviour
{
    public Player player;
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
        Debug.Log("Trigger Entered");
        if (other.CompareTag(ProjectConstants.TAG_NAME) && player.inventory.Contains(ProjectConstants.USER_DOOR_KEYCARD))
        {
            Debug.Log("Player has entered the trigger");
            PlayerPrefs.SetString("SceneName", "StealthScene");
            SceneManager.LoadScene("StealthScene");

            // we would probably want to play a sound after this
            // Destroy(gameObject);
        }
    }
}
