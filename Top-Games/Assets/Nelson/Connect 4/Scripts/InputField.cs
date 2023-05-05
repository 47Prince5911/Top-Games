using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputField : MonoBehaviour 
{
   public GameManager gm;


    public int column;
    void OnMouseDown()
    {  
      gm.SelectColumn(column);
        
    }
     void OnMouseOver()
    {
        gm.Hovercolumn(column);
    }

}
