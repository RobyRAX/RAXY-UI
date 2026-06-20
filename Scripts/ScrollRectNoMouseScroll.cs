using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace RAXY.UI
{
    public class ScrollRectNoMouseScroll : ScrollRect
    {
        public override void OnScroll(PointerEventData data)
        {
        }
    }
}