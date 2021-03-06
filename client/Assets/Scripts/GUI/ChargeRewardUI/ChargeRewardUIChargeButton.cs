﻿using UnityEngine;
using System.Collections;
using Mogo.Util;

public class ChargeRewardUIChargeButton : MonoBehaviour
{
    void OnPress(bool isOver)
    {
        if (isOver)
        {
        }
        else
        {
            Camera camera = GameObject.Find("MogoMainUI").transform.GetChild(0).GetComponentInChildren<Camera>();
            BoxCollider bc = transform.GetComponentInChildren<BoxCollider>();

            RaycastHit hit = new RaycastHit();

            if (bc.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit, 10000.0f))
            {
                if (StrenthUIDict.ButtonTypeToEventUp[transform.name] == null)
                {
                    Debug.LogError("No ButtonTypeToEventUp Info");
                    return;
                }

                StrenthUIDict.ButtonTypeToEventUp[transform.name]();
            }
        }
    }
}
