using UnityEngine;

public class Tent : Actor
{
    public override void Event_Fuction()
    {
        transform.Rotate(10f, 0f, 0f);
    }
}
