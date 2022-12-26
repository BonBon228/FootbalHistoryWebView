using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryPanelUIOrientation : MonoBehaviour
{
    [SerializeField] private GameObject _historyPanelContent;
    [SerializeField] private float _bottomSizeLandscape;
    [SerializeField] private float _bottomSizePortrait;
    private bool _canLandscape;
    private bool _canPortrait;

    private void Start()
    {
        if(Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            _canLandscape = false;
            _canPortrait = true;
        }

        else if(Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            _canLandscape = true;
            _canPortrait = false;
        }
    }

    private void Update()
    {
        if(_canLandscape && Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            LandscapeOrientated();
        }
        
        else if(_canPortrait && Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            PortraitOrientated();
        }
    }

    private void LandscapeOrientated()
    {
        _historyPanelContent.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        _historyPanelContent.GetComponent<RectTransform>().offsetMin = new Vector2(0, _bottomSizeLandscape);
        _canLandscape = false;
        _canPortrait = true;
    }

    private void PortraitOrientated()
    {
        _historyPanelContent.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        _historyPanelContent.GetComponent<RectTransform>().offsetMin = new Vector2(0, _bottomSizePortrait);
        _canLandscape = true;
        _canPortrait = false;
    }
}
