using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CollisonController : MonoBehaviour
{
    GameObject copy;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _boardGameobject;
    PlayerController PlayerController;
    // private Coin_Explosion coinExplosion;
    [SerializeField] private CoinCollect coinCollect;
    Vector3 _formerPosition;
    // Vector3 _distrance;
    bool up = true;
    
    private void Start()
    {
        PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        // coinExplosion = GameObject.FindGameObjectWithTag("Coin").GetComponent<Coin_Explosion>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            gameObject.transform.SetParent(collision.gameObject.transform);
            playerData.Instance._childCount = _playerTransform.childCount;
            if (playerData.Instance._isFinished != true && playerData.Instance._childCount == 0)
            {
                playerData.Instance._stop = true;
                UIManager.Instance.openLoseGameCanvas();
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BoardPart")
        {
            up = true;
            _formerPosition = transform.position;
            other.gameObject.SetActive(false);
            //  _playerTransform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y + 1.005f, _playerTransform.position.z);
            Up();
            copy = Instantiate(_boardGameobject, _formerPosition, Quaternion.identity);
            copy.transform.SetParent(_playerTransform);
            up = false;
            playerData.Instance._childCount = _playerTransform.childCount;
           
        }
        
        if(other.gameObject.tag == "Finish")
        {
            playerData.Instance._isFinished = true;
        }

    
        /*
      else if (other.gameObject.name == "2X")
        {
            
            if (playerData.Instance._childCount == 0)
            {
                playerData.Instance._stop = true;
            }
           // GameManager.Instance.WinGame();
           
        }

       else  if (other.gameObject.name == "3X")
        {
            if (playerData.Instance._childCount == 0)
            {
                playerData.Instance._stop = true;
            }
            
            playerData.Instance.setCoinCount(playerData.Instance._coinCount * 3);
        }*/
    }

    private void Up()
    {
        if (up)
        {
            _playerTransform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y + 1.005f, _playerTransform.position.z);
        }
       
    }

   
}
