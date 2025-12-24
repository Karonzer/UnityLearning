using UnityEngine;

public interface IYadd
{
    public void Set_Collision(bool _value);
}

public class Ball : MonoBehaviour, IYadd
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
    [SerializeField] private bool isCollision;
    [SerializeField] private bool isJump;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        dir = Vector3.zero;
        force = ForceMode.Force;
        isCollision = false;
        isJump = false;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown("space"))
        {
            isJump = true;
        }

        dir = new Vector3(x, 0, z);
        dir.Normalize();
    }

    private void FixedUpdate()
    {
        Rigidbody.AddForce(dir*5,force);

        if (isCollision)
        {
            Rigidbody.AddForce(Vector3.up * 12, force);
        }

        if(isJump)
        {
            isJump = false;
            Rigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    public void Set_Collision(bool _value)
    {
        isCollision = _value;
    }


}
