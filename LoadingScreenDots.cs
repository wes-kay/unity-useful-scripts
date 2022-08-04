using TMPro;
using System.Collections;
using UnityEngine;

public class LoadingScreenDots : MonoBehaviour
{
    TMP_Text displayText;
    Coroutine coroutine;
    [SerializeField]
    string placeHolder;
    [SerializeField]
    float waitTime;
    
    string dots;
    bool active;

    void OnEnable()
    {
        displayText ??= GetComponent<TextMeshProUGUI>();
        displayText.text = placeHolder;
        coroutine = StartCoroutine(Cycle());
    }

    void OnDisable() => StopCoroutine(coroutine);

    IEnumerator Cycle()
    {
        for (; ; )
        {
            displayText.text = $"{placeHolder}{dots}";
            yield return new WaitForSeconds(waitTime);
            dots += ".";
        }
    }
}
