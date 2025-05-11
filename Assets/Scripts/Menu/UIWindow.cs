using UnityEngine;

public class UIWindow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenWindow(){
        Debug.Log("Opening window");
        GetComponent<Canvas>().enabled = true;
    }
    public void CloseWindow(){
        Debug.Log("Closing window");
        GetComponent<Canvas>().enabled = false;
    }
}
