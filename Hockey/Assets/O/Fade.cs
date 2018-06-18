using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    enum FADE_MODE
    {
        FADE_IN,
        FADE_OUT,
        FADE_IN_FINISH,
        FADE_OUT_FINISH,
        FADE_NONE
    }

    private FADE_MODE mode = FADE_MODE.FADE_NONE;
    private float alpha = 1.0f;

    public float FADE_RATE = 0.01f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mode == FADE_MODE.FADE_IN)
        {
            //アルファ値を減らしていく
            alpha -= FADE_RATE;

            if (alpha <= 0.0f)
            {
                alpha = 0.0f;
                mode = FADE_MODE.FADE_IN_FINISH;
            }

            //実際の色を変更
            Image img = GetComponent<Image>();
            Color col = img.color;
            col.a = alpha;
            img.color = col;
        }
        else if (mode == FADE_MODE.FADE_OUT)
        {
            //アルファ値を増やしていく
            alpha += FADE_RATE;

            if (alpha >= 1.0f)
            {
                alpha = 1.0f;
                mode = FADE_MODE.FADE_OUT_FINISH;
            }

            //実際の色を変更
            Image img = GetComponent<Image>();
            Color col = img.color;
            col.a = alpha;
            img.color = col;
        }
    }

    //-------------------------------------------------------------------------
    // フェードイン開始
    //-------------------------------------------------------------------------
    public void FadeIn()
    {
        mode = FADE_MODE.FADE_IN;
    }

    //-------------------------------------------------------------------------
    // フェードアウト開始
    //-------------------------------------------------------------------------
    public void FadeOut()
    {
        mode = FADE_MODE.FADE_OUT;
    }

    //-------------------------------------------------------------------------
    // フェードインが終わったか
    //-------------------------------------------------------------------------
    public bool isFinishedFadeIn()
    {
        return mode == FADE_MODE.FADE_IN_FINISH;
    }

    //-------------------------------------------------------------------------
    // フェードアウトが終わったか
    //-------------------------------------------------------------------------
    public bool isFinishedFadeOut()
    {
        return mode == FADE_MODE.FADE_OUT_FINISH;
    }
}
