using UnityEngine;
using TMPro;
public class Crowbar : MonoBehaviour
{
    public Player player;
    public AudioClip pickupSound;
    public AudioSource audioSource;
    public TextMeshProUGUI chatText;
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
            chatText.text = "Great! Now I can break down the wall!";    
            player.UpdateInventory(ProjectConstants.CROWBAR);
            audioSource.resource = pickupSound;
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
