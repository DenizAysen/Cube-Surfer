using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData : singleton<playerData>
{
    public int _coinCount = 0;

    public int _moveSpeed = 15;
    public int _swipeSpeed = 8;
    private float _startDistance;
    public Transform  __finishColZ;
    public int _childCount;
    public bool _isFinished;
    public bool _stop;
    private void Awake()
    {
        base.Awake();
        maxmesafeHesapla();
        _childCount = transform.childCount;
        _isFinished = false;
        _stop = true;
    }
    public int getCoinCount()
    {
        return _coinCount;
    }

    public void setCoinCount(int _coinCount)
    {
        this._coinCount = _coinCount;
    }

    private void maxmesafeHesapla()
    {
        _startDistance = __finishColZ.position.z - transform.position.z;
    }


    public float Distance()

    {
        
        return ((_startDistance - (__finishColZ.position.z - transform.position.z)) / _startDistance);
    }
}
