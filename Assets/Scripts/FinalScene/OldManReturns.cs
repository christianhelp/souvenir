using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
public class OldManReturns : MonoBehaviour
{
    public TMP_Text chatText;
    public Player player;
    public AudioSource audioSource;
    public AudioClip scarySound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartInteraction()
    {
        player.canMove = false;
        player.transform.LookAt(transform.position);
        audioSource.resource = scarySound;
        audioSource.Play();
        StartCoroutine(OldManChat());
    }

    IEnumerator OldManChat()
    {
        chatText.text = "";
        yield return new WaitForSeconds(1f);
        chatText.text = "Hello. You have something that I need back.";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("WinScene");
    }
}
