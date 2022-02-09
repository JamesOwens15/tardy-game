using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    private AssetBundle opennname;
    private string[] scenePaths;
    public float LevelCntdn = 15.0f;
    Text text;
    RectTransform rectTransform;
    
    
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        rectTransform = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
       float Timereduction = Time.deltaTime;
        LevelCntdn -= Timereduction;
        text.text = "Time Remaining: "+string.Format("{0:N2}", LevelCntdn);
        if (LevelCntdn <= 0)
        {
            text.text = "Time Remaining: 00.00";
            rectTransform.localPosition = new Vector3(0, 0, 0);
            rectTransform.sizeDelta = new Vector2(600, 200);
            text.fontSize = 48;
            text.text = "Time's Up!";
            //SwitchScreen();
            Invoke("SwitchScreen", 2);
            
        }
    }
    void SwitchScreen()
    {
        SceneManager.LoadScene("Opening Screen");
    }
}
