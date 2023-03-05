using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject balloon;
    public GameObject hedef;
    private float yukseklik;
    private TextMeshProUGUI text;
    private TextMeshProUGUI ileri;
    private TextMeshProUGUI geri;
    private TextMeshProUGUI sag;
    private TextMeshProUGUI sol;
    private int zMesafe;
    private int xMesafe;
    private float carpmaHizi;
    // Start is called before the first frame update
    void Start()
    {
        text = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        ileri = transform.Find("ileri").GetComponent<TextMeshProUGUI>();
        geri = transform.Find("geri").GetComponent<TextMeshProUGUI>();
        sag = transform.Find("sag").GetComponent<TextMeshProUGUI>();
        sol = transform.Find("sol").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    { 
        yukseklikHesapla();
        mesafeHessapla();
    }

    void yukseklikHesapla()
    {
        yukseklik = balloon.transform.position.y;
        text.SetText(((int)(yukseklik)).ToString());
        carpmaHizi = balloon.GetComponent<BallonnController>().carpmaHizi;
        if (carpmaHizi > 400)
        {
            text.color = Color.red;
        }
        else if (carpmaHizi < 400 && carpmaHizi > 100)
        {
            text.color = Color.yellow;
        }
        else
        {
            text.color = Color.green;
        }
    }

    void mesafeHessapla()
    {
        zMesafe = ((int)(hedef.transform.position.z - balloon.transform.position.z));
        xMesafe = ((int)(hedef.transform.position.x - balloon.transform.position.x));
        if ( zMesafe > 0)
        {
            ileri.SetText(zMesafe.ToString());
        }
        else if (hedef.transform.position.z - balloon.transform.position.z < 0)
        {
            geri.SetText(Mathf.Abs(zMesafe).ToString());
        }
        else
        {
            ileri.SetText(" ");
            geri.SetText(" ");
        }

        if (xMesafe > 0)
        {
            sag.SetText(xMesafe.ToString());
        }
        else if (xMesafe < 0)
        {
            sol.SetText(Mathf.Abs(xMesafe).ToString());
        }
        else
        {
            sag.SetText(" ");
            sol.SetText(" ");
        }
    }
}
