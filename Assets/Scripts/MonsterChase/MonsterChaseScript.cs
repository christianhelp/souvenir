using UnityEngine;
using TMPro;
using System.Collections;
public class MonsterChaseScript : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI textMeshPro;
    public AudioClip scarySound;
    public AudioSource audioSource;
    public MonsterAI monster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.canMove = false;
        StartCoroutine(InitialChat());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InitialChat(){
        textMeshPro.text = "I am seriously getting tired of this.";
        yield return new WaitForSeconds(3f);
        textMeshPro.text = "Old Man: Hello there! Listen to my voice and you will be safe.";
        yield return new WaitForSeconds(3f);
        textMeshPro.text = "Old Man: You are not alone! A monster is chasing you!";
        yield return new WaitForSeconds(3f);
        textMeshPro.text = "Old Man: You need to get out of there! Find the fuse and return it to the blank spot!";
        yield return new WaitForSeconds(3f);
        textMeshPro.text = "What are you talking about?? What monster what fus-";
        yield return new WaitForSeconds(3f);
        textMeshPro.text = "Objetive: Find the fuse and return it to the blank spot!";
        audioSource.resource = scarySound;
        monster.MoveInMonster(10f);
        audioSource.Play();
        player.canMove = true;

    }
}
