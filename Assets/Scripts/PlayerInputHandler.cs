using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public Player player;
    public Transform cameraTransform;
    public Transform cameraPivotTransform; //rotate to look
    public float cameraPivotSpeed = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    // Do NOT use update for get component. Use start instead
    void Update()
    {

        Vector3 cameraForward = cameraTransform.forward;
        cameraForward.y = 0;

        Vector3 finalMovement = Vector3.zero;


        Vector3 cameraRight = cameraTransform.right;
        cameraRight.y = 0;


        if (Input.GetKey(KeyCode.W))
            finalMovement += cameraForward;

        if (Input.GetKey(KeyCode.S))
            finalMovement -= cameraForward;

        if (Input.GetKey(KeyCode.A))
            finalMovement -= cameraRight;

        if (Input.GetKey(KeyCode.D))
            finalMovement += cameraRight;


        // ensures that there is a magnitude of 1
        finalMovement.Normalize();
        player.MoveWithCC(finalMovement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            cameraPivotTransform.Rotate(Vector3.up, cameraPivotSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            cameraPivotTransform.Rotate(Vector3.up, cameraPivotSpeed * -Time.deltaTime);
        }
    }

}
