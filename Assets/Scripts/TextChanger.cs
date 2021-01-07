using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;

    public void ChangeText(float value)
    {
        _textMesh.text = Convert.ToString(value);
    }
}
