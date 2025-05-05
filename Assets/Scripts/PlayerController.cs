using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // 좌우 입력 받기 (왼쪽: -1, 정지: 0, 오른쪽: 1)
        float move = Input.GetAxisRaw("Horizontal");

        // 좌우 이동
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        // 이동속도가 0보다 크다면 X축으로 스프라이트 반전
        if (move > 0) spriteRenderer.flipX = false;
        else if (move < 0) spriteRenderer.flipX = true;

        // 점프 입력 (스페이스바) & 땅에 있을 때만 가능
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // 애니메이션 전환
        UpdateAnimation();
    }

    // 상태에 따라 애니메이션 파라미터 전환
    void UpdateAnimation()
    {
        animator.SetBool("isJumping", !isGrounded);  // 점프 중 여부
    }

    // Ground태그와 충돌 → isGrounded = true
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Ground태그로 부터 벗어남 → isGrounded = false
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
