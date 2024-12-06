using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    private Rigidbody2D body;
    private Vector2 movement;
    [Header("Parameters")]
    public float rotationSpeed = 0.02f;
    private BoxCollider2D boxCollider;
    [Header("Component")]
    [SerializeField] AudioSource footstepAudioSource;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private float speed = 2f;

    private void Awake()
    {
        Debug.Log("nguoi choi co the di chuyen dc");
        if (footstepAudioSource == null)
        {
            footstepAudioSource = GetComponent<AudioSource>();
        }
        body = GetComponent<Rigidbody2D>();
        body.freezeRotation = true;
    }
    private void Update()
    {
       

        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (movement != Vector2.zero && !footstepAudioSource.isPlaying)
        {
            footstepAudioSource.Play(); 
        }
        else if (movement == Vector2.zero && footstepAudioSource.isPlaying)
        {
            footstepAudioSource.Pause(); 
        }
        if (movement != Vector2.zero)
        {
            Debug.Log("oke");
            float targetAngle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg - 90f;
            float currentAngle = body.rotation;
            float smoothedAngle = Mathf.LerpAngle(currentAngle, targetAngle, rotationSpeed * Time.fixedDeltaTime);
            body.rotation = smoothedAngle;
          

        }


    }
    private void FixedUpdate()
    {
        body.velocity = movement * speed;
    }
    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }
}
