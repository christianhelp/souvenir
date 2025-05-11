using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System.Linq;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 15f;
    public float gravity = -9.81f;
    public float jumpSpeed = 10f;

    [Header("Tag")]

    [Header("MetaData")]


    public List<string> inventory;

    public bool canMove = true;


    public CharacterController characterController;
    public TextMeshProUGUI chatText;
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        inventory = new List<string>();
    }

    void Start()
    {
    }

    void Update()
    {
        ApplyGravityWithCC();

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

    public void MoveWithCC(Vector3 direction)
    {
        if (!canMove)
        {
            return;
        }
        characterController.Move(speed * Time.deltaTime * direction);
        transform.LookAt(transform.position + direction);
    }
    Vector3 gravityVelocity = Vector3.zero; // how fast we are moving due to gravity
    public void ApplyGravityWithCC()
    {
        if (characterController.isGrounded && gravityVelocity.y < 0)
        {
            gravityVelocity = Vector3.zero;
            return;
        }
        gravityVelocity.y += gravity * Time.deltaTime;
        characterController.Move(gravityVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (characterController.isGrounded)
        {
            gravityVelocity.y = jumpSpeed;
        }
    }

    public void UpdateInventory(string item)
    {
        inventory.Add(item);
        string inventoryString = string.Join(", ", inventory);
        chatText.text = $"Inventory: {inventoryString}";
    }

}


