using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 startPos;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;

    private void Start()
    {
        startPos = transform.position;
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("obstacle"))
        {
            Die();
        }
    }

    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }

    IEnumerator Respawn(float duration)
    {
        rb.linearVelocity = new Vector2(0, 0);
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        spriteRenderer.enabled = true;

    }

}
