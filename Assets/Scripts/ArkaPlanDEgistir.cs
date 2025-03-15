using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ArkaPlanDEgistir : MonoBehaviour
{
    public Sprite gece;
    public Sprite gunduz;
    public Image Background;
    void Start()
    {
        DateTime customDate = DateTime.Now;

        if (customDate.Hour >= 19)
        {
            Background.sprite = gece;
        }
        else Background.sprite = gunduz;

    }
    
}
