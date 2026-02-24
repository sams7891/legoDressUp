using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandlerd : MonoBehaviour
{
    public Image chracterImage;
    public Sprite[] imageOptions;
    public TMP_Dropdown myDropdown;

    void Start()
    {
        myDropdown.onValueChanged.AddListener(OnDropdownChanged);
        OnDropdownChanged(myDropdown.value);

    }
    void OnDropdownChanged(int index)
    {
        chracterImage.sprite = imageOptions[index];
    }

}
