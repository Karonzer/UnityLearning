using UnityEngine;

public class Tent : Actor
{
    public override void Event_Fuction()
    {
        transform.Rotate(0f, 0f, 10f);
    }
}
