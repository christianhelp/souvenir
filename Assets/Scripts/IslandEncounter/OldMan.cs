using TMPro;
using UnityEngine;
using System.Collections;

public class OldMan : MonoBehaviour
{
  public Player player;
  public TextMeshProUGUI chatText;
  public AudioSource audioSource;
  public AudioClip scarySound;
  
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {

  }

  // Update is called once per frame
  void Update(){

  }
  

  public void StartInteraction(){
    audioSource.resource = scarySound;
    audioSource.Play();
    player.canMove = false;
    // Vector3 direction = (player.transform.position - transform.position).normalized;
    // Vector3 newPosition = transform.position + direction * 2f;
    transform.position = player.transform.position;
    transform.position += new Vector3(0, 0, 2f);
    // transform.LookAt(player.transform.position);
    player.transform.LookAt(transform.position);
    StartCoroutine(RunInteraction(2f));
  }

  IEnumerator RunInteraction(float delayTime)
  {
    chatText.text = "I have something for you.";
    yield return new WaitForSeconds(delayTime);
    chatText.text = "Take this souvenir.";
    
    player.UpdateInventory(ProjectConstants.SOUVENIR_NAME);
    yield return new WaitForSeconds(delayTime);
    chatText.text = "I trust this with you.";
    yield return new WaitForSeconds(delayTime);
    // disable capsule collider and mesh renderer
    CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
    MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
    if (capsuleCollider != null)
    {
      capsuleCollider.enabled = false;
    }
    if (meshRenderer != null)
    {
      meshRenderer.enabled = false;
    }
    player.canMove = true;
    chatText.text = "Man that was weird. I should get out of here.";
    yield return new WaitForSeconds(delayTime);
    chatText.text = "Objective: Head back to the boat.";
    Destroy(gameObject);
  }

}
