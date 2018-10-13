using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadlevel : MonoBehaviour {

    public void PlayLevel(int level)
    {
        Application.LoadLevel(level);
    }
}
