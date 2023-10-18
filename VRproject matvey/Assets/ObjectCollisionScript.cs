using UnityEngine;
using UnityEngine.UI;

public class ObjectCollisionScript : MonoBehaviour
{
    public Text counterText;
    private int counter;

    private void Start()
    {
        counter = 10; // Изначальное значение счетчика
        UpdateCounterText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        counter--; // Уменьшаем счетчик при столкновении
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = "Counter: " + counter.ToString();
    }
}
