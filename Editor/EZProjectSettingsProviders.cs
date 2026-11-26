/* Author:          ezhex1991@outlook.com
 * CreateTime:      2026-11-18
 * Organization:    #ORGANIZATION#
 * Description:     Project Settings providers for EZProjectSettings.
 */
using UnityEditor;
using UnityEngine;

namespace EZhex1991.EZProjectSettings
{
    internal static class EZProjectSettingsProviders
    {
        private const string SettingsRoot = "Project/EZProjectSettings";

        private static SettingsProvider CreateProjectSettingsProvider<T>(string name, T instance) where T : EZProjectSettingsSingleton<T>
        {
            AssetSettingsProvider provider = AssetSettingsProvider.CreateProviderFromObject(SettingsRoot + "/" + name, instance);
            provider.guiHandler += searchContext =>
            {
                if (GUI.changed) instance.Save();
            };
            return provider;
        }

        [SettingsProvider]
        private static SettingsProvider CreateEZAssetImporterProvider()
        {
            return CreateProjectSettingsProvider(nameof(EZAssetImporterManager), EZAssetImporterManager.Instance);
        }

        [SettingsProvider]
        private static SettingsProvider CreateEZGraphicsSettingsProvider()
        {
            return new EZGraphicsSettings(SettingsRoot + "/" + nameof(EZGraphicsSettings), SettingsScope.Project);
        }
    }
}
