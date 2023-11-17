using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadScript2 : MonoBehaviour
{
    public Quaternion HeadRotation = Quaternion.Euler(0, 0, 30);
    public double HeaderTime = 0.1;
    private float HeadTimer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = HeadRotation;
            HeadTimer = Time.time;
        }
        if (Time.time - HeadTimer > HeaderTime)
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
