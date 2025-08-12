using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public TextMeshProUGUI ShapeText;

    private string m_Name = "";
    public string ShapeName
    {
        get { return m_Name; }
        set
        {
            if (value.Length == 0)
            {
                Debug.LogError("Name can not be empty");
            }
            else if (value.Length > 10)
            {
                Debug.LogError("Name length can not be greater than 10");
            }
            else
            {
                m_Name = value;
            }
        }
    }

    void Start()
    {
        UpdateShapeName();
    }

    void OnMouseDown()
    {
        DisplayText();    
    }

    protected abstract void UpdateShapeName();

    public void DisplayText()
    {
        ShapeText.text = "¡You've clicked the " + m_Name + "!";
        Renderer renderer = GetComponent<Renderer>();
        ShapeText.color = renderer.material.color;
    }
}
