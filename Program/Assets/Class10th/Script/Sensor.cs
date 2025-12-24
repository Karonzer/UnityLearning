using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        if(other.TryGetComponent<IYadd>(out var component))
        {
            component.Set_Collision(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        if (other.TryGetComponent<IYadd>(out var component))
        {
            component.Set_Collision(false);
        }
    }
}

