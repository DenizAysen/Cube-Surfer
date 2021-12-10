using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : singleton<UIManager>
{
    [SerializeField] private Image _levelProgressImage;
    [SerializeField] private TextMeshProUGUI _coinText;
    [SerializeField] private playerData _pData;
    public Canvas PreGameCanvas;
    public GameObject LoseGameCanvas;
    public GameObject WinGameCanvas;
    private void levelProggres()
    {
          _levelProgressImage.fillAmount = _pData.Distance();
        _coinText.text = _pData._coinCount + "";
    }

   

    public void openLoseGameCanvas()
    {
        LoseGameCanvas.SetActive(true);
    }
    
    public void openWinGamecanvas()
    {
        WinGameCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        levelProggres();   
    }
}
