using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAI : MonoBehaviour
{
    public Player player;
    public float speed = 8f;
    public CharacterController characterController;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        // transform.rotation = Quaternion.Euler(-90f,-90f,0f);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        MoveTowardsFollowCreature();
    }

    public void MoveTowardsFollowCreature()
    {

        Vector3 direction = player.transform.position - transform.position;
        direction.y = 0;
        direction.Normalize();
        Move(direction);

    }

    public void Move(Vector3 direction)
    {
        transform.position += speed * Time.deltaTime * direction;
        if (direction == Vector3.zero)
        {
            return;
        }

        transform.LookAt(transform.position + direction);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(player.TAG_NAME))
        {
            SceneManager.LoadScene("LoserMenu");
        }
    }
}
