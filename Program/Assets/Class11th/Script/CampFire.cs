using UnityEngine;

public class CampFire : Actor
{
    public override void Event_Fuction()
    {
        transform.localScale += new Vector3(0.1f,0.1f,0.1f);
    }
}
