using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject[] wheels;

    [SerializeField] private float time = 10;
    [SerializeField] private float currentTime;
    [SerializeField] private bool show;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[0].color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    }

    private void OnEnable()
    {
        show = true;
        time = 3;
        currentTime  = time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0)
        {
            show = !show;
            currentTime = time;
            for (int i = 0; i < wheels.Length;i++)
            {
                Debug.Log(wheels[i].name);
                wheels[i].gameObject.SetActive(show);
            }
        }
    }
}
