using UnityEngine;
using System.Collections;
using TMPro;
public class FinalChatController : MonoBehaviour
{
    public TMP_Text chatText;
    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BeginningChat());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BeginningChat(){
        player.canMove = false;
       chatText.text = "Woah...was it really all a dream?";
       yield return new WaitForSeconds(3f);
       chatText.text = "I am never eating at the Home Depot again.";
        yield return new WaitForSeconds(3f);
        chatText.text = "Objective: Go outside and enjoy the sun.";
        player.canMove = true;
    }
}
