using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    [SerializeField] private Button endBtn;
    [SerializeField] private Button settingBtn;

    private void Awake()
    {
        
    }

    public void Click_Btn(string _text)
    {
        Debug.Log(_text);
    }
}
