using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace ShirayuriMeshibe
{
    public class LanguageSelector : MonoBehaviour
    {
        [SerializeField] ToggleGroup _toggleGroup = null;

        void Start()
        {
            var toggles = gameObject.GetComponentsInChildren<Toggle>(true);
            foreach(var toggle in toggles)
            {
                if(toggle.TryGetComponent(out LanguageLocalOption option))
                {
                    toggle.onValueChanged.AddListener(isOn => ChagedLanguageOption(isOn, option.Locale));
                }
            }
            var activeToggle = _toggleGroup.ActiveToggles().First();
            if (activeToggle.TryGetComponent(out LanguageLocalOption option2))
            {
                ChagedLanguageOption(true, option2.Locale);
            }
        }

        void ChagedLanguageOption(bool isOn, Locale locale)
        {
            if(isOn)
            {
                LocalizationSettings.Instance.SetSelectedLocale(locale);
            }
        }
    }
}
