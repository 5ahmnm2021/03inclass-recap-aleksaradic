using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AddNumbers : MonoBehaviour
{
    public InputField num1_if;
    public InputField num2_if;
    
    public Text result;
    
    bool bool1;
    bool bool2;

    public void AddNumbersOnClick()
    {        
        float num1 = 0;
        float num2 = 0;

        //----------first Try and Catch----------

        try
        {
            num1 = float.Parse(num1_if.text);
            bool1 = true;
        }
        catch (System.Exception)
        {
            num1_if.image.color = new Color32(255,0,0,100);
            bool1 = false;
            StartCoroutine(BackToNormal());
        }

        //----------second Try and Catch----------

        try
        {
            num2 = float.Parse(num2_if.text);
            bool2 = true;
        }
        catch (System.Exception)
        {
            num2_if.image.color = new Color32(255,0,0,100);
            bool2 = false;
            StartCoroutine(BackToNormal());
        }

        //----------ifStatement and Result Addition----------

        if (bool1 && bool2)
        {
            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }
        else
        {
            result.text = "Ohje";
        }
        
        //----------Coroutine which changes everything back to normal----------
        
        IEnumerator BackToNormal()
        {
        yield return new WaitForSeconds(2);

        num2_if.image.color = new Color32(255,255,255,100);
        num1_if.image.color = new Color32(255,255,255,100);

        result.text = "...";
        num1_if.text = "";
        num2_if.text = "";
        }
    }
}