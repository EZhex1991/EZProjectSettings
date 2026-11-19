# EZProjectSettings

[中文](README.md)

EZProjectSettings provides project settings extensions for the Unity Editor.

Minimum supported Unity version: `2020.3.x`.

## Settings

- `EZEditorSettings`: Editor settings and Hierarchy extensions.
- `EZScriptSettings`: Script templates and file header processing settings.
- `EZAssetImporterManager`: Asset importer Preset settings.
- `EZGraphicsSettings`: Project Graphics settings.

## Directory Structure

```text
EZProjectSettings/
├── README.md — Chinese module documentation.
├── README_EN.md — English module documentation.
└── Editor/
    ├── EZProjectSettingsProviders.cs — Registers Project Settings providers.
    ├── EZhex1991.EZProjectSettings.Editor.asmdef — Defines the editor assembly.
    ├── Common/
    │   ├── EZEditorGUIUtility.cs — Common GUI helpers for settings inspectors.
    │   └── EZEditorUtility.cs — Editor resource query helpers for settings.
    └── ProjectSettings/
        ├── _EZProjectSettings.cs — Base implementation for loading and saving project settings singletons.
        ├── EZEditorSettings.cs — Editor settings and Hierarchy extensions.
        ├── EZScriptSettings.cs — Script templates and file header replacement settings.
        ├── EZScriptSettingsEditor.cs — Inspector for script settings.
        ├── EZScriptProcessor.cs — Processes file headers when scripts are created.
        ├── EZAssetImporterManager.cs — Asset importer Preset configuration.
        ├── EZAssetImporterManagerInspector.cs — Inspector for asset importer configuration.
        ├── EZAssetPostprocessor.cs — Automatically applies asset importer Presets.
        └── EZGraphicsSettings.cs — Graphics settings in Project Settings.
```
