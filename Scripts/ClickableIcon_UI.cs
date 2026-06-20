using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace RAXY.UI
{
    public class ClickableIcon_UI : MonoBehaviour
    {
        [TitleGroup("UI Ref")]
        public Button button;

        [TitleGroup("UI Ref")]
        public Image iconImg;

        private Action _onClick;

        public void Setup(ClickableIcon_SetupRequest req)
        {
            button.onClick.RemoveAllListeners();

            iconImg.sprite = req.iconSprite;
            _onClick = req.onClick;
            
            button.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            _onClick?.Invoke();
        }
    }

    [Serializable]
    public class ClickableIcon_SetupRequest
    {
        public Sprite iconSprite;
        public Action onClick;
    }
}
