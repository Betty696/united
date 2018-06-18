using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour {

    public GameObject Fade;
    public GameObject Logo;
    public GameObject OOKAMI;
    public Sprite PL2;
    public Sprite PL2O;
    private float tim = 0;
    private bool flag = false;
    public GameObject next;
    // Use this for initialization
    void Start()
    {
        if (WinFlag.Instance.Win1P)
        {
            Logo.GetComponent<SpriteRenderer>().sprite = PL2;
            OOKAMI.GetComponent<SpriteRenderer>().sprite = PL2O;
        }
	}

	// Update is called once per frame
	void Update()
	{
        tim += Time.deltaTime;
        if(tim > 2.0f)
        {
            flag = true;
        }
        if (flag)
        {
            if(Input.touchCount > 0)
            {
                Fade.GetComponent<FadeIn>().Set();
                Invoke("NExt", 1.0f);
            }
        }
    }

    void NExt()
    {
        Instantiate(next);
    }
}
