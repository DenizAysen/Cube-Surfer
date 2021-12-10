using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public float speed;

    public Transform target;
    //public Transform intial;
    public GameObject CoinPrefab;
    public Camera cam;


    void Start()
    {
        if(cam == null)
        {
            cam = Camera.main;
        }
    }
    public void StartCoinMove(Vector3 _intial)
    {
       // Vector3 intialpos = cam.ScreenToWorldPoint(new Vector3(_intial.x, _intial.y, cam.transform.position.z * -1));
        Vector3 targetpos = cam.ScreenToWorldPoint(new Vector3(target.position.x, target.position.y, cam.transform.position.z * -1));
        GameObject coin = Instantiate(CoinPrefab, transform);
        StartCoroutine(MoveCoin(coin.transform, _intial, targetpos ));
    }
    IEnumerator MoveCoin(Transform obj,Vector3 startPos, Vector3 endPos )
    {
        float time = 0f;
        while(time < 1)
        {
            time += speed * Time.deltaTime;
            obj.position = Vector3.Lerp(startPos, endPos, time);
            obj.transform.SetParent(target.transform);
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
   
}
