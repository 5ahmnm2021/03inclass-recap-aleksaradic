using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField num1_if;
    public InputField num2_if;
    
    public float num1;
    public float num2;
    
    public Text result;
    
    bool bool1 = false;
    bool bool2 = false;

    public void AddNumbersOnClick()
    {
     try
        {
            num1 = float.Parse(num1_if.text);
            bool1 = true;
        }
        catch (System.Exception)
        {
            num1_if.image.color = new Color32(255,0,0,100);
            bool1 = false;
        }

        try
        {
            num2 = float.Parse(num2_if.text);
            bool2 = true;
        }
        catch (System.Exception)
        {
            num2_if.image.color = new Color32(255,0,0,100);
            bool2 = false;
        }
        
        if (bool1 == true | bool2 == true)
        {
            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }
        else
        {
            result.text = "Ohjee";
        }
    }
}