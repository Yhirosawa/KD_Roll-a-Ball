﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassTest : MonoBehaviour
{

    [SerializeField] Image image;
    [SerializeField] Transform player;
    [SerializeField] Text text;
    [SerializeField] float angleOfflet = 0f;

    RectTransform rt;
    Quaternion q;
    Quaternion offset;

    // Start is called before the first frame update
    void Start()
    {
        rt = image.rectTransform;
        offset = Quaternion.AngleAxis(angleOfflet, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        q = player.rotation * offset;
        q.z = -q.y;
        q.y = 0f;

        text.text = q + "";

        rt.rotation = q;
    }
}
