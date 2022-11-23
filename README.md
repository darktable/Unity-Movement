# Unity-Movement
Unity-Movement is a package that uses OpenXR’s tracking layer APIs to expose Meta Quest Pro’s Body Tracking (BT), Eye Tracking (ET), and Face Tracking (FT) capabilities. With this package, developers can leverage tracking to populate VR environments with custom avatars that bring the expressiveness of users into the virtual environments that they create.

### Requirements
- Unity 2020.3.34f1 (2020 LTS) or newer installed
- v46.0 or newer of the Oculus Integration SDK with OVRPlugin set to use OpenXR as backend. Make sure to include the VR and Interaction folders when importing into your project.
- A project set up with these [configuration settings](https://developer.oculus.com/documentation/unity/unity-conf-settings/)

### Licenses
The Unity-Movement package is released under the [Oculus License](https://github.com/oculus-samples/Unity-Movement/blob/main/LICENSE). The MIT License applies to only certain, clearly marked documents. If an individual file does not indicate which license it is subject to, then the Oculus License applies.

## Getting Started
First, ensure that all of the [requirements](#requirements) are met.

Then, bring this package into the project.
- In Package Manager, click on the add button below the window title and select **Add package from git URL…**, using this URL: https://github.com/oculus-samples/Unity-Movement.git
- To grab a specific version of the package, append the version number with a # to the git URL (i.e. https://github.com/oculus-samples/Unity-Movement.git#1.2.0)
- Alternatively, in package manager, click on the add button below the window title and select **Add package from disk...**, using the package.json located after unzipping one of the releases here: https://github.com/oculus-samples/Unity-Movement/releases

The sample scenes are located under the **Samples/../Scenes** folders.

## Unity Setup

If the new scene or an existing scene doesn’t have a GameObject with the OVRCameraRig component, follow the steps:
1. From the Hierarchy tab, look for a Main Camera GameObject.
2. If the Main Camera GameObject is present, right-click Main Camera and click Delete.
3. In the Project tab, expand the Assets > Oculus > VR > Prefab folder and drag and drop the OVRCameraRig prefab into the scene. You can also drag and drop it into the Hierarchy tab.
4. On the Inspector tab, go to OVR Manager > Quest Features.
5. In the General tab, there are options to enable body, face, and eye tracking support. Select Supported or Required for the type of tracking support you wish to add.
6. The Character (layer index 10), the MirroredCharacter (layer index 11), and HiddenMesh layers must be present in the project.

TextMeshPro is required.

## Rendering Quality
Navigate to your Project Settings (Edit->Project Settings...) and click on
the "Quality" section. If your project uses URP,
then some of these settings might be part the rendering pipeline asset currently
in use. The pipeline picked will be shown in the Quality menu.

The following settings are recommended:
1. Four bones for Skin Weights.
2. 2x Multi Sampling Anti Aliasing.
3. Full resolution textures.
4. Shadow settings:
  1. Hard and soft shadows.
  2. Very high shadow resolution.
  3. Stable fit.
  4. Shadow distance of 3 meters with cascades. This will allow viewing shadows
nearby without experiencing poor quality.
5. At least one pixel light.

## Samples
The project contains several sample scenes. For more information about the samples, read [Aura Sample](https://developer.oculus.com/documentation/unity/move-sample-aura/), [Hip Pinning Sample](https://developer.oculus.com/documentation/unity/move-sample-hip-pinning/), and [High Fidelity Sample](https://developer.oculus.com/documentation/unity/move-high-fidelity/).

## Documentation
The documentation for this package can be found [here](https://developer.oculus.com/documentation/unity/move-overview/).
The API reference for this package can be found [here](https://oculus-samples.github.io/Unity-Movement/).
