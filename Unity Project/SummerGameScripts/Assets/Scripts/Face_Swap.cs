﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_Swap : MonoBehaviour
{
    public Material HeadMat;
    public Texture HappyCol, NormalCol, AngryCol;

    public void Happy()
    {
       HeadMat.SetTexture("_MainTex" , HappyCol);
    }

    public void Angry()
    {
        HeadMat.SetTexture("_MainTex" , AngryCol);
    }

    public void Normal()
    {
        HeadMat.SetTexture("_MainTex" , NormalCol);
    }
    
}