using UnityEngine;

public class Goblin : MonoBehaviour
{
    [SerializeField] private int strength  = 5;
    [SerializeField] public int dexterity = 1;
    [SerializeField] protected int wisdom = 0;

    private void Reset()
    {
        strength = 5;
        dexterity = 1;
        wisdom = 5;
    }

    void Start()
    {
        Debug.Log($"strength : {strength}, dexterity : {dexterity}, wisdom : {wisdom}");
        test();
    }

    public void test()
    {
        test_test();
    }

    public virtual void test_test()
    {

    }

}
