using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public Player player;
    public MonsterAI monster;

    
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
        Debug.Log("Trigger Entered");
        if (other.CompareTag(ProjectConstants.TAG_NAME) && player.inventory.Contains(ProjectConstants.CROWBAR))
        {
            Debug.Log("Player has entered the trigger");
            monster.MoveInMonster(10f);
            Destroy(gameObject);
            
        }
    }
}
