using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runanim : MonoBehaviour {
    public Transform[] target;
    public float speed;
    public GameObject pika;
    public Rigidbody rb;
    private int current;

        void Update()
        {
            if (transform.position != target[current].position)
            {
                Vector2 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                rb.MovePosition(pos);
                Debug.Log(pos);
            }
            else
            {
                current = (current + 1) % target.Length;
            }
        }

	
}
