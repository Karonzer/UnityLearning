using UnityEngine;

public class State : MonoBehaviour
{

    private void Awake()
    {
        //클래스가 생성되는 시점에 단 한번만 호출되면 호출되며, 클래스가 비활성화 되어 있어도 호출되는 이벤트 함수
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // 게임 오브젝트가 활성화될 때마마 호출되는 이벤트 함수입니다.
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // 게임 오브젝트가 생성되었을 때 단 한번만 호출되면, 클래스가 비활성화 되었을 땐 호출 되지 않은 이벤트 함수입니다.
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        //time step에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        // 매 프레임 마다 호출 되는 이벤트 함수입니다.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // Update 함수가 호출된 후에 호출되는 이벤트 함수
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // 게임 오브젝트가 비활성화 될 때마 호출되는 이벤트 함수
    }

    private void OnDestroy()
    {
        // 게임 오브젝트가 삭제되면 호출되는 이벤트 함수입니다.
    }
}

