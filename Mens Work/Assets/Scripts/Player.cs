using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rb;
    public float walk = 5f;
    public float walkAnimationThresh = 0;
    public float DashSpeed = 20f;
    public bool Dashing = false;
    public float DashTime = 1f;

    Vector2 input;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        input.Normalize();

        Vector3 moveDirection = new Vector3(input.x * walk, Rb.linearVelocity.y, input.y * walk);
        Rb.linearVelocity = moveDirection;
    }
}
