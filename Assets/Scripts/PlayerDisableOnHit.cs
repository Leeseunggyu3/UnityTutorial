using UnityEngine;

public class PlayerDisableOnHit : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D col;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            SoundManager.Instance?.PlayDead();
            rb.velocity = Vector2.zero;
            col.enabled = false;
      
        }
    }
}
