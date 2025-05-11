using UnityEngine;
using UnityEngine.SceneManagement;
public class WaterScript : MonoBehaviour
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
        if (other.CompareTag(ProjectConstants.TAG_NAME))
        {
            SceneManager.LoadScene("IslandEncounter");
        }
    }
}
