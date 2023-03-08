using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    static public UIController UI;

    [SerializeField]
    GameObject pressF;

    private void Awake()
    {
        UI = GetComponent<UIController>();
    }

    public void PressF(bool b)
    {
        pressF.SetActive(b);
    }
}
