using UnityEngine;
using UnityEngine.UI;

public class ResizeWidth : MonoBehaviour
{
    public Scrollbar scrollbar;

    public float minWidth = 500f;
    public float maxWidth = 600f;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        if (scrollbar != null)
        {
            scrollbar.onValueChanged.AddListener(UpdateWidth);
            UpdateWidth(scrollbar.value);
        }
    }

    void UpdateWidth(float value)
    {
        float newWidth = Mathf.Lerp(minWidth, maxWidth, value);
        rectTransform.sizeDelta = new Vector2(newWidth, rectTransform.sizeDelta.y);
    }
}
