using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class maintextscript : MonoBehaviour
{
    [SerializeField] public TMP_Text MainText;
    [SerializeField] public GameObject MainCamera;
    public TMP_Text Term;

    void Start()
    {
        MainText.text = " Okula Hazirim! ";
        Term = MainText;
    }

    void Update()
    {
        if (MainCamera.transform.position == new Vector3(-0.0399999991f, 3.20000005f, -10f))
        {
            MainText.text =  " Okula Hazirim! ";
        }
        else if (MainCamera.transform.position == new Vector3(-41.7999992f, 3.20000005f, -10f))
        {
            MainText.text = "  Hadi Okula Hazirlanalim!  ";
        }
        else if (MainCamera.transform.position == new Vector3(43.5999985f, 3.20000005f, -10f))
        {
            MainText.text = "  Evdeki Sorumluluklarim...  ";
        }
        else
        {
            MainText.text = Term.text;
        }
    }
}
