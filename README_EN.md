# EZProjectSettings

[中文](README.md)

EZProjectSettings provides project settings extensions for the Unity Editor.

Minimum supported Unity version: `2020.3.x`.

Open the settings from `Edit > Project Settings > EZProjectSettings`.

## Settings

- `EZAssetImporterManager`: Asset importer Preset settings with automatic Preset application.
- `EZGraphicsSettings`: A convenient interface for managing Always Included Shaders in Graphics Settings.

### EZAssetImporterManager

Manages import settings for Model, Texture, and Audio importers. Default import options can be configured for each asset type, with Presets associated through filename Tags. During asset import, matching Presets are searched from the current directory toward its parent directories and applied automatically.

![EZAssetImporterManager](Documentation~/Images/EZAssetImporterManager.png)

### EZGraphicsSettings

Provides tools for managing Always Included Shaders, including searching project shaders and adding or removing them from the list.

![EZGraphicsSettings](Documentation~/Images/EZGraphicSettings.png)

## Directory Structure

```text
EZProjectSettings/
├── README.md — Chinese module documentation.
├── README_EN.md — English module documentation.
├── Documentation~/Images/ — README and sample images.
└── Editor/
    ├── EZProjectSettingsProviders.cs — Registers Project Settings providers.
    ├── EZhex1991.EZProjectSettings.Editor.asmdef — Defines the editor assembly.
    ├── Common/
    │   ├── EZEditorGUIUtility.cs — Common GUI helpers for settings inspectors.
    │   └── EZEditorUtility.cs — Editor resource query helpers for settings.
    └── ProjectSettings/
        ├── _EZProjectSettings.cs — Base implementation for loading and saving project settings singletons.
        ├── EZAssetImporterManager.cs — Asset importer Preset configuration.
        ├── EZAssetImporterManagerInspector.cs — Inspector for asset importer configuration.
        ├── EZAssetPostprocessor.cs — Automatically applies asset importer Presets.
        └── EZGraphicsSettings.cs — Graphics settings in Project Settings.
```
