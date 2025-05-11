using UnityEngine;
using TMPro;
using System.Collections;
public class DialogueStealth : MonoBehaviour
{
    public TMP_Text dialogueText;
    public AudioSource audioSource;
    public AudioClip scarySound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(RunDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RunDialogue()
    {
        dialogueText.text = "What now??";
        yield return new WaitForSeconds(2f);
        dialogueText.text = "I need to find a way out of here. I do not feel like I am alone.";
        yield return new WaitForSeconds(3f);
        dialogueText.text = "Looks like the elevator area is blocked, but doesn't look too sturdy.";
        yield return new WaitForSeconds(3.5f);
        dialogueText.text = "I need to explore to find something to break it up with.";
        yield return new WaitForSeconds(3f);
        dialogueText.text = "Objective: Find a tool to break the wall.";
    }

    public void PlayScarySound()
    {
        audioSource.resource = scarySound;
        audioSource.Play();
    }
}
