using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool Flag1P = false;
    public GameObject Wolf;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D c)
    {
        WinFlag.Instance.Win1P = Flag1P;
        Destroy(c.gameObject);
        Instantiate(Wolf);
    }
}
