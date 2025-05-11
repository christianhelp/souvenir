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
        if (other.CompareTag(ProjectConstants.TAG_NAME) && player.inventory.Contains(ProjectConstants.FUSE_TAG_NAME))
        {
            // change material of the blank fuse to all black
            Debug.Log("Player has entered the trigger");
            transform.GetComponent<Renderer>().material = AllBlackMaterial;
            StartCoroutine(WaitThenWin());
        }
    }
    IEnumerator WaitThenWin()
    {
        PlayerPrefs.SetString("SceneName", "EndScene");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("EndScene");
    }
}
