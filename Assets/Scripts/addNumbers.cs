using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField num1_if;
    public InputField num2_if;
    public Text result;
    
    float num1;
    float num2;

    public void AddNumbersOnClick()
    {
        try
        {
            float num1 = float.Parse(num1_if.text);
        }
        catch (System.Exception)
        {
            num1_if.image.color = new Color32(255,0,0,100);
        }

        try
        {
            float num2 = float.Parse(num2_if.text);
        }
        catch (System.Exception)
        {
            num2_if.image.color = new Color32(255,0,0,100);
        }
        
        float addResult = num1 + num2;
        result.text = addResult.ToString();
    }
}
