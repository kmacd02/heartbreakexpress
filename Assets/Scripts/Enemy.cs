using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed;

    void Start() {
        speed = 2.0f;
    }

    void OnTriggerExit2D(Collider2D col) {
        Debug.Log("triggere;");
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.position += Vector3.right * speed * Time.fixedDeltaTime;
    }
}
