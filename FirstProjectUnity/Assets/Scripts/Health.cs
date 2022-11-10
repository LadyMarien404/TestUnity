using UnityEngine;
public class Health : MonoBehaviour
{
    protected int myHealth;

    public Health()
    {
        myHealth = 10;
    }

    public Health(int inHealth)
    {
        myHealth = inHealth;
    }

    void ReduceHealth(int amount)
    {
        myHealth = myHealth - amount;
    }

}