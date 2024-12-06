using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundlayer;
    private float movementValue;
    private Rigidbody2D body;
    private BoxCollider2D boxCollider;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        movementValue = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(movementValue * speed, body.velocity.y);
    }
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundlayer);
        return raycastHit.collider != null;
    }
}
