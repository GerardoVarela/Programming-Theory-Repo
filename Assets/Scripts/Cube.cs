using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // POLYMORPHISM
    protected override void UpdateShapeName()
    {
        ShapeName = "Cube";
    }
}
