using UnityEngine;

public class MaterialFloatChanger : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private string floatName;
    [SerializeField] private float floatValue;

    private void Update()
    {
        material.SetFloat(floatName, floatValue);
    }
}


