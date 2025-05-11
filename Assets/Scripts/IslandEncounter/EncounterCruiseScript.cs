using UnityEngine;

public class EncounterCruiseScript : MonoBehaviour
{
    public Player player;
    public OldMan oldMan;
    bool hasStartedInteraction = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceDiff = Vector3.Distance(transform.position, player.transform.position);
        if (distanceDiff < 60f && !hasStartedInteraction)
        {
            hasStartedInteraction = true;
            oldMan.StartInteraction();
        }
        
    }
}
