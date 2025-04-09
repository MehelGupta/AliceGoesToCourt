using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject onClickPopup;

    public void Click()
    {
        onClickPopup.SetActive(true);
    }
}
