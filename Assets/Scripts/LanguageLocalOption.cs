using UnityEngine;
using UnityEngine.Localization;

namespace ShirayuriMeshibe
{
    public sealed class LanguageLocalOption : MonoBehaviour
    {
        [SerializeField] Locale _locale = null;

        public Locale Locale => _locale;
    }
}
