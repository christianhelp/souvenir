using UnityEngine;
using TMPro;
using System.Collections;

public class RoomKeyCard : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI chatText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        StartCoroutine(RunDialogue());
        
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
            player.UpdateInventory(ProjectConstants.USER_DOOR_KEYCARD);
            chatText.text = "Great! I can finally get some rest.";
            Destroy(gameObject);
            
        }
    }

    IEnumerator RunDialogue()
    {
        player.canMove = false;
        chatText.text = "Man what a weird encounter.";
        yield return new WaitForSeconds(2f);
        chatText.text = "I should head to bed before it gets weirder.";
        yield return new WaitForSeconds(2.5f);
        chatText.text = "Wait where's my keycard?";
        yield return new WaitForSeconds(2f);
        chatText.text = "Objective: Find the keycard.";
        player.canMove = true;
    }
}
