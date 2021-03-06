﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace UnityVRScripts {
    public class LightsOff : MonoBehaviour {
        public bool LightsOn = false;

        void Start() {
            new Thread(() => {
                Thread.Sleep(10000);
                LightsOn = true;
            }).Start();
        }

        void Update() {
            if (LightsOn) {
                GameObject[] allLights = GameObject.FindGameObjectsWithTag("TurnOff");
                foreach (GameObject i in allLights) {
                    i.SetActive(false);
                }
            }
        }
    }
}