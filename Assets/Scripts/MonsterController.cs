using UnityEngine;

public class MonsterFollow : MonoBehaviour
{

    private Rigidbody2D rb;

    [Header("Player Object")]
    public Transform target;

    [Header("Move Speed")]
    public float moveSpeed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target == null) return;

        // X축 위치만 따라가고, Y는 고정된 값으로 유지
        Vector3 targetPosition = new Vector3(target.position.x, rb.velocity.y, 0);

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );
    }
}
