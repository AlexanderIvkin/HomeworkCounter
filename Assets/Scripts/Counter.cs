using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private float _delay = 0.5f;
    private int _count = 0;
    private bool _isPressed = false;

    private void AddCount()
    {
        _count++;
    }

    public void ButtonIsPressed()
    {
        _isPressed = !_isPressed;

        if (_isPressed)
        {
            StartCoroutine(AddValue());
        }
    }

    private IEnumerator AddValue()
    {
        var wait = new WaitForSeconds(_delay);

        while (_isPressed)
        {
            AddCount();
            DisplayText();

            yield return wait;
        }

        yield return null;
    }

    private void DisplayText()
    {
        _text.text = _count.ToString("");
    }
}
