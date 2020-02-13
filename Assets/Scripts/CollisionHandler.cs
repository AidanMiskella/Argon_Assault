﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")] [SerializeField] GameObject deathFX;

    private void OnTriggerEnter(Collider other) {

        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadLevelScene", levelLoadDelay);
    }

    private void StartDeathSequence() {

        SendMessage("OnPlayerDeath");
    }

    private void ReloadLevelScene() {

        SceneManager.LoadScene(1);
    }
}
