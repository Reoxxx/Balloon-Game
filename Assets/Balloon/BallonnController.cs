using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class BallonnController : MonoBehaviour
{
    private Rigidbody rb;
    public float carpmaHizi;
    public float hareketKuvveti;
    public float yukselmeKuvveti;
    public float maxHiz;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        if (Input.GetKey(KeyCode.Space))
        {
            rise();
        }
        carpmaHiziHesapla();
    }

    void move()
    {
        float xMove = Input.GetAxisRaw("Horizontal") * hareketKuvveti;
        float zMove = Input.GetAxisRaw("Vertical") * hareketKuvveti;
        rb.AddForce(transform.forward * zMove);
        rb.AddForce(transform.right * xMove);
        rb.velocity = new UnityEngine.Vector3(Mathf.Clamp(rb.velocity.x, -maxHiz, maxHiz), rb.velocity.y, Mathf.Clamp(rb.velocity.z, -maxHiz, maxHiz));
    }
    void rise()
    {     
            rb.AddForce(transform.up * yukselmeKuvveti);
    }
    
    
    void carpmaHiziHesapla()
    { 
        if(rb.velocity.y > 0)
        {
            carpmaHizi = 0;
        }
        else
        {
            carpmaHizi = Mathf.Pow(rb.velocity.y, 2) -   ((Physics.gravity.y * Time.fixedDeltaTime + yukselmeKuvveti) * 2f * rb.transform.position.y);
        }
    }

    
}
