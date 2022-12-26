using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHeader : MonoBehaviour
{
    [SerializeField] private GameObject[] _historyPanels;

    private void Update()
    {
        CloseHeaderOnSmartphoneBtn();
    }

    private void CloseHeaderOnSmartphoneBtn()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            foreach(GameObject h in _historyPanels)
            {
                h.SetActive(false);
            }
        }
    }

    public void CloseHeaderOnBtnClick(GameObject panel)
    {
        panel.SetActive(false);
    }
}
