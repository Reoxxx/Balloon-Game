using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeylekMovement : MonoBehaviour
{
    public float speed;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed);
    }
}
