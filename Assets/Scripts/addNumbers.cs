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

    bool bool_if1;
    bool bool_if2;

    public void AddNumbersOnClick()
    {
        try
        {
            float num1 = float.Parse(num1_if.text);
            bool bool_if1 = true;
            //Debug.Log("Try1 geht");
        }
        catch (System.Exception)
        {
            num1_if.image.color = new Color32(255,0,0,100);
            bool bool_if1 = false;
            //Debug.Log("Catch1 geht");
        }

        try
        {
            float num2 = float.Parse(num2_if.text);
            bool bool_if2 = true;
            //Debug.Log("Try2 geht");
        }
        catch (System.Exception)
        {
            num2_if.image.color = new Color32(255,0,0,100);
            bool bool_if2 = false;
            //Debug.Log("Catch1 geht");
        }
        
        if (bool_if1 == true | bool_if2 == true)
        {
            float addResult = num1 + num2;
            result.text = addResult.ToString();
            //Debug.Log("Beide Stimmen");
        }
        else
        {
            result.text = "Ohje";
            //Debug.Log("Ohje kommt");
        }
    }
}