using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    private float time;
    private TextMeshProUGUI timeText;
    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "Time: " + time;
    }
}
