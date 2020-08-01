﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkButton : MonoBehaviour
{
    public GameObject Button;
    public GameObject talkUI;
    void Start()
    {
       Button.SetActive(false);
       talkUI.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
        talkUI.SetActive(false);
    }

    private void Update()
    {
        if (Button.activeSelf )
        {
            talkUI.SetActive(true);
        }
    }

}
