﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    GamePlayManager gm;
    void Awake()
    {
        gm = FindObjectOfType<GamePlayManager>();
    }
    void OnTriggerEnter(Collider collider)
    {
        gm.AddScore();
    }
}
