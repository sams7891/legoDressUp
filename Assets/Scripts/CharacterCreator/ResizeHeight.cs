using UnityEngine;
using UnityEngine.UI;

public class ResizeHeight : MonoBehaviour
{
    public Scrollbar scrollbar;

    public float minHeight = 100f;
    public float maxHeight = 500f;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        if (scrollbar != null)
        {
            scrollbar.onValueChanged.AddListener(UpdateHeight);
            UpdateHeight(scrollbar.value);
        }
    }

    void UpdateHeight(float value)
    {
        float newHeight = Mathf.Lerp(minHeight, maxHeight, value);
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, newHeight);
    }
}
