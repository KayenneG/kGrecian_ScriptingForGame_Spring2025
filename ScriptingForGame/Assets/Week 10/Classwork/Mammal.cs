using UnityEngine;

public class Mammal : InheritancePractice
{
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }

    public override void Eat(int energyGained)
    {
        Debug.Log("Chome Chomp. Eating with mah mouth");
        base.Eat(energyGained);
    }

    public virtual void GiveBirth()
    {
        Debug.Log("Giving birth to a mammal");
    }
}
