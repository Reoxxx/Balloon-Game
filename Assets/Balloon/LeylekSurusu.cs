using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeylekSurusu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject leylek;
    public GameObject sol;
    public GameObject sag;
    public GameObject on;
    private float timer;
    void Start()
    {
        timer = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            int rand = Random.Range(1, 3);
            if(rand == 1)
            {
                spawnSol();
            }
            else if(rand == 2)
            {
                spawnSag();
            }
            else 
            {
                spawnOn();
            }
            timer = 10;
        }
    }

    void spawnSol()
    {
        int adet = Random.Range(5, 12);
        for(int i = 0; i < adet; i++)
        {
            float x = Random.Range((float)(sol.transform.position.x - 10), (float)(sol.transform.position.x + 10));
            float y = Random.Range((float)(sol.transform.position.y - 20), (float)(sol.transform.position.y + 20));
            float z = Random.Range((float)(sol.transform.position.z - 20), (float)(sol.transform.position.z + 200));
            Vector3 position = new Vector3(x, y, z);
            Quaternion rotation = Quaternion.Euler(0, 45, 0);
            Instantiate(leylek, position, rotation);
        }
    }

    void spawnSag()
    {
        int adet = Random.Range(5, 12);
        for (int i = 0; i < adet; i++)
        {
            float x = Random.Range((float)(sag.transform.position.x - 10), (float)(sag.transform.position.x + 10));
            float y = Random.Range((float)(sag.transform.position.y - 20), (float)(sag.transform.position.y + 20));
            float z = Random.Range((float)(sag.transform.position.z - 20), (float)(sag.transform.position.z + 20));
            Vector3 position = new Vector3(x, y, z);
            Quaternion rotation = Quaternion.Euler(0, -45, 0);
            Instantiate(leylek, position, rotation);
        }
    }

    void spawnOn()
    {
        int adet = Random.Range(5, 12);
        for (int i = 0; i < adet; i++)
        {
            float x = Random.Range((float)(on.transform.position.x - 20), (float)(on.transform.position.x + 20));
            float y = Random.Range((float)(on.transform.position.y - 20), (float)(on.transform.position.y + 20));
            float z = Random.Range((float)(on.transform.position.z - 20), (float)(on.transform.position.z + 20));
            Vector3 position = new Vector3(x, y, z);
            Quaternion rotation = Quaternion.Euler(0, 90, 0);
            Instantiate(leylek, position, rotation);
        }
    }
}
