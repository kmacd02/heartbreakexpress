using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Gun : MonoBehaviour {

    public Vector3 mousePosition;
    public float angle;
    public Vector2 direction;

    public Ray ray;
    public RaycastHit2D hit;

    [SerializeField] Transform rotationPoint;

    [SerializeField] GameObject Envelope;   // prefab of envelope to be shot
    GameObject shotEnvelope;    // the envelope that was shot
    Rigidbody2D envelopeRb;
    [SerializeField] Vector3 envSpawnOffset;
    [SerializeField] float fireSpeed = 15;
    Quaternion envRotation = Quaternion.identity;

    public Vector2 target;
    public Vector2 fireDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        
        // Rotate the gun around a point to face the mouse
        mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = mousePosition - transform.position;
        angle = Vector2.SignedAngle(transform.up, direction);
        transform.RotateAround(rotationPoint.position, new Vector3(0, 0, 1), angle);

    }

    void OnShoot(InputValue value) {
        Debug.Log("Shoot");
        
        // to get game object of thing hit if smth is hit
        ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        
        // I'm not sure this section is needed but it might make the animations look better, I'm not sure I haven't tested it on a moving truck yet
        if (hit.collider != null && hit.collider.gameObject.CompareTag("Person")) {
            Debug.Log(hit.collider.gameObject.name);
            target = hit.collider.gameObject.transform.position;
            
            // personHit offset if needed to make animations look better?
        } else {
            Debug.Log("hit something else");
            target = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        }
        
        // target acquired, shoot envelope
        fireDirection = target - new Vector2(transform.position.x, transform.position.y);
        fireDirection.Normalize();
        shotEnvelope = Instantiate(Envelope, rotationPoint.position, envRotation);
        envelopeRb = shotEnvelope.GetComponent<Rigidbody2D>();
        envelopeRb.velocity = fireDirection * fireSpeed;

    }
}
