using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private Ray ray;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red,100f);
            if(Physics.Raycast(ray,out hit,100))
            {
                if(hit.transform.TryGetComponent<Actor>(out var _actor))
                {
                    _actor.Event_Fuction();
                }
            }
        }
    }
}
