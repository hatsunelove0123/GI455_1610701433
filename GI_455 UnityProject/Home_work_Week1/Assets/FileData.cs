using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileData : MonoBehaviour
{
    public string[] _ResearchObject;

    public Text _FindObject;
    public Text _ShowObject;

    public void Box()
    {
        for (int _BOXBOX = 0; _BOXBOX <= 5; _BOXBOX++)
        {
            if (_FindObject.text == _ResearchObject[_BOXBOX])
            {
                _ShowObject.text = "<color=green>" + _FindObject.text + "</color>" + " is found in BOX";
                print(" is found object");
                return;
            }

            else if (_FindObject.text != _ResearchObject[_BOXBOX] && _BOXBOX == 5)
            {
                _ShowObject.text = "<color=green>" + _FindObject.text + "</color>" + " is not found in BOX";
                print(" is not found object");
                return;
            }
        }
    }
}