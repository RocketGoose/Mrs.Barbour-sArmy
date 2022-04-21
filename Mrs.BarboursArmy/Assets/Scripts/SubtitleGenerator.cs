using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubtitleGenerator : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI subtitleText = default;

    public static SubtitleGenerator instance;

    private void  Awake() 
    {
        instance = this;
    }

    public void SetSubtitle(string subtitle)
    {
        subtitleText.text = subtitle;
    }
}

