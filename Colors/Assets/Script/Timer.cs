﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public Color col, defCol;
    public GameObject mCube;
    private Color lastCol;

	// Use this for initialization
	void Start () {
        lastCol = mCube.GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (mCube.GetComponent<Renderer>().material.color != lastCol)
        {
            lastCol = mCube.GetComponent<Renderer>().material.color;
            transform.position = new Vector3(0, transform.position.y, 0);
            GetComponent<Renderer>().material.color = defCol;
        }
        if (!mCube.GetComponent<GameCntrl>().lose)
        {
            if (transform.position.x < -6.85f)
                Destroy(gameObject);
            if (transform.position.x < -1.5f)
                GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, col, Time.deltaTime);
            transform.position -= new Vector3(0.03f, 0, 0);
        }
	}
    void OnDestroy()
    {
        if (mCube)
            mCube.GetComponent<GameCntrl>().lose = true;
    }
}
