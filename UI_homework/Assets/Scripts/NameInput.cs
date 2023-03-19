using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameInput : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void SetName(string name)
    {
        _text.text = name;
    }
}
