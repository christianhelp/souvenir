using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BlankFuseScript : MonoBehaviour
{
    public Material AllBlackMaterial;
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
        if (other.CompareTag(player.TAG_NAME) && player.hasFuse)
        {
            // change material of the blank fuse to all black
            Debug.Log("Player has entered the trigger");
            transform.GetComponent<Renderer>().material = AllBlackMaterial;
            StartCoroutine(WaitThenWin());
        }
    }
    IEnumerator WaitThenWin()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("WinScene");
    }
}
