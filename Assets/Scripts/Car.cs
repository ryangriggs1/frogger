using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    public float speedModifier = 0.01f;

    private void Start()
    {
        SpeedUpdate();
        speed = Random.Range(minSpeed * speedModifier, maxSpeed * speedModifier);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);   
    }

    void SpeedUpdate()
    {
        speedModifier = GameSpeed.additionalSpeed;
    }
}
