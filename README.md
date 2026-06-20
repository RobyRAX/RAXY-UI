# RAXY UI

RAXY UI provides reusable Unity UI components for text, layout, scrolling, and icon buttons.

## Features

- **AutoResizeTMP** — dynamically resize TextMeshProUGUI width and/or height to fit content
- **TextTyper** — typewriter effect for TMP text with skip support
- **KeepSquare** — keep a RectTransform square using several fit modes
- **ScrollRectNoMouseScroll** — ScrollRect that ignores mouse wheel input
- **ClickableIcon_UI** — icon button setup helper with sprite and callback

## Setup

Add the components you need directly to UI prefabs. Most components work out of the box with inspector configuration.

## Dependencies

- **Unity UGUI** (`com.unity.ugui`) — `UnityEngine.UI`, TextMeshPro
- **Odin Inspector** (project plugin) — editor attributes on several components; runtime works without Odin if attributes are stripped

## Notes

Game-specific UI widgets (inventory rows, rarity colors, menus) should live in your project, not in this package.
