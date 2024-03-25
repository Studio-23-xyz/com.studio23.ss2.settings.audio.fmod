
# FMOD Audio Settings for Unity

This is an audio setting for FMOD. Used for in game sound and voice and music settings.

## Table of Contents

1. [Installation](#installation)
2. [Getting Started](#getting-started)
   - [Initialization](#initialization)
   - [Creating Graphics Configuration](#creating- URP Graphics Configuration)
3. [Use case](#How-to-use)


## Installation


### Install via Git URL
You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/com.studio23.ss2.settings.audio.fmod#upm
```

## Getting Started

### Initialization

Create An Empty GameObject and attach the FMODManager MonoBehaviour to it. Must have FMOD project assigned.

### Creating Audio Settings Data Configuration

Create audio settings data configuraion : Create -> Studio-23 -> Settings -> Audio -> BusAudioSettingsData. 
It has a field to assign default bus volume. 


## Use case

### How To Use

To use this package properly you have to install FMOD unity package and create proper FMOD project with dedicated buses and events.
Use AudioSettingsData MonoBehaviour class to assign bus name and BusAudioSettingsData with each UI slider.
Control all AudioSettingsData from a central AudioSettingsController and initialize AudioSettingsData class.

```csharp
using studio23.ss2.Settings.Video.Core;

public class YourGameManager : MonoBehaviour
{
    private void InitializeAudioSettingsData()
    {
		foreach (var data in _audioSettingsData)
		{
			data.Initialize(_audioSettingsDictionary[data],data.FmodBusSettings.GetDefaultVolume());
		}
    }
}
```

After that call UpdateVolume function when silder value changes

```csharp
using studio23.ss2.Settings.Video.Core;

public class YourGameManager : MonoBehaviour
{
    private void UpdateBusVolume(float volume)
    {
        AudioSettingsData.FMODBusSettings.UpdateVolume(volume);
    }
}
```

That's it! You now have the basic information you need to use the **Studio23.SS2.settings.audio.fmod** library in your Unity project. Explore the library's features and customize it according to your game's needs.