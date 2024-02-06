using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    private float time = 1;
    private string text;
    public Slider slider;
    // public TMP_Text textArea;
    public GameObject panel;

    public void Start() {
        panel.SetActive(false);
        //text = textArea.text;
    }

    public void OnClickBasicButton() {
        StartCoroutine(Timer(time));
    }

    IEnumerator Timer(float time) {
        while(time > 0) {
            time -= Time.deltaTime;
            slider.value = time;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        time = 0;
        slider.value = time;
        yield return null;
        GameOver();
    }

    public void GameOver() {
        panel.SetActive(true);
    }
}
