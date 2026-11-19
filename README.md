# EZProjectSettings

[English](README_EN.md)

EZProjectSettings 是 Unity 编辑器的项目设置扩展。

最低支持 Unity 版本：`2020.3.x`。

设置面板位于 `Edit > Project Settings > EZProjectSettings`。

## 设置

- `EZEditorSettings`：编辑器设置和 Hierarchy 扩展。
- `EZScriptSettings`：脚本模板和文件头处理设置。
- `EZAssetImporterManager`：资源导入器 Preset 设置，并支持自动应用 Preset。
- `EZGraphicsSettings`：提供更加方便的界面管理 Graphics Settings 中的 Always Included Shaders。

## 目录结构

```text
EZProjectSettings/
├── README.md — 模块说明文档。
├── README_EN.md — English module documentation.
└── Editor/
    ├── EZProjectSettingsProviders.cs — 注册 Project Settings Providers。
    ├── EZhex1991.EZProjectSettings.Editor.asmdef — 定义编辑器程序集。
    ├── Common/
    │   ├── EZEditorGUIUtility.cs — 提供设置 Inspector 使用的通用 GUI 辅助方法。
    │   └── EZEditorUtility.cs — 提供设置 Inspector 使用的编辑器资源查询方法。
    └── ProjectSettings/
        ├── _EZProjectSettings.cs — 项目设置单例的加载和保存基础实现。
        ├── EZEditorSettings.cs — 编辑器设置和 Hierarchy 扩展。
        ├── EZScriptSettings.cs — 脚本模板和文件头替换设置。
        ├── EZScriptSettingsEditor.cs — 脚本设置 Inspector。
        ├── EZScriptProcessor.cs — 脚本创建时的文件头处理器。
        ├── EZAssetImporterManager.cs — 资源导入器 Preset 配置。
        ├── EZAssetImporterManagerInspector.cs — 资源导入器配置 Inspector。
        ├── EZAssetPostprocessor.cs — 自动应用资源导入 Preset。
        └── EZGraphicsSettings.cs — Project Settings 中的 Graphics 设置。
```
