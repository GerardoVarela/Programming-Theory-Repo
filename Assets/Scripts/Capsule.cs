using UnityEngine;

// INHERITANCE
public class Capsule : Shape
{
    // POLYMORPHISM
    protected override void UpdateShapeName()
    {
        ShapeName = "Capsule";
    }

}
