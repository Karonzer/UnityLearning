using UnityEngine;
using System;

public class CampFire : Actor
{
    public event Action<Transform> onReset;

    private void OnEnable()
    {
        onReset += CheckTransformLocalScaleValue;
    }

    private void OnDisable()
    {
        onReset -= CheckTransformLocalScaleValue;
    }
    public override void Event_Fuction()
    {

        transform.localScale -= new Vector3(0.1f,0.1f,0.1f);
        onReset?.Invoke(transform);
    }

    public void CheckTransformLocalScaleValue(Transform _value)
    {
        if (_value.localScale.x <= 0)
        {
            _value.localScale = Vector3.one;
        }
    }
}
