using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // POLYMORPHISM
    protected override void UpdateShapeName()
    {
        ShapeName = "Sphere";
    }
}
