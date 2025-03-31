using UnityEngine;

public enum BloodType
{
    ColdBlooded,
    WarmBlooded
}

public class InheritancePractice : MonoBehaviour
{
    protected int health = 100;
    protected int energy = 100;

    protected BloodType bType;

    public virtual void Eat(int energyGained)
    {
        energy += energyGained;
    }
}
