using UnityEngine;
using UnityEngine.UI;

public class ObjectCollisionScript : MonoBehaviour
{
    public Text counterText;
    private int counter;

    private void Start()
    {
        counter = 10; // ����������� �������� ��������
        UpdateCounterText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        counter--; // ��������� ������� ��� ������������
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = "Counter: " + counter.ToString();
    }
}
