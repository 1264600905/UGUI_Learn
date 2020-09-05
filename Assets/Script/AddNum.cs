using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNum : MonoBehaviour {

    public int HP = 255;
    private void Update()
    {
        Text Hp = this.GetComponent<Text>();
        Hp.text = HP.ToString();
    }
    public void  OnButtonClick()
    {
        HP++;
    }
}
