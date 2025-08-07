using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyBird : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float jumpForce = 1.5f;
    [SerializeField] private float tiltFactor = 5f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ใช้ Input System ตรวจสอบการคลิกซ้าย
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ตีขึ้น
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        // หมุนตัวนกตามความเร็วแนวตั้ง (ใช้ Quaternion.Euler ของ Unity)
        float angle = Mathf.Clamp(rb.velocity.y * tiltFactor, -60f, 30f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // แจ้ง GameManager ว่า Game Over
        if (GameManager.instance != null)
            GameManager.instance.GameOver();
    }
}