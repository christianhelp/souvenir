using UnityEngine;

public class FuseScript : MonoBehaviour
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
            Debug.Log("Player has entered the trigger");
            player.UpdateInventory(ProjectConstants.FUSE_TAG_NAME);
            Destroy(gameObject);
        }
    }
}
