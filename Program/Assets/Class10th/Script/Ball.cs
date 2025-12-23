using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody Rigidbody;
    //addForce(방향,FocceMode)
    //: Force : 힘을 지속적으로 누적합니다
    // 무게 (0)

    //Acceleration : 질양과 관계없이 가속도만 적용합니다.

    //impulse : 한번의 순간적인 힘을 적용합니다

    //velocityChange : 질량과 영향 없이 즉각적으로 속도의 변화를 줍니다.


    [SerializeField] private Vector3 dir;
    [SerializeField] private ForceMode force;


    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        dir = Vector3.zero;
        force = ForceMode.Force;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        dir =  new Vector3 (x,0,y);
        dir.Normalize();
    }

    private void FixedUpdate()
    {
        Rigidbody.AddForce(dir * 5, force);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
}
