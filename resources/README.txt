* Yo, just do whatever applies to you * 

How my app folder will look like:
.
├── android
├── ios
├── unity
│   └── <Your Unity Project>    // Example: Cube
├── node_modules
├── package.json
├── README.md

Configure Player Settings
    - First Open Unity Project.

    - Click Menu: File => Build Settings => Player Settings

    - Change Product Name to Name of the Xcode project, You can find it follow ios/GrooVR_App.xcodeproj.

Add Unity Build Scripts and Export
    - Copy Build.cs and XCodePostBuild.cs to unity/<Your Unity Project>/Assets/Scripts/Editor/

    - Open your unity project in Unity Editor. Now you can export unity project with Build/Export Android or Build/Export IOS menu.

    - Android will export unity project to android/UnityExport.

    - IOS will export unity project to ios/UnityExport.

IOS Build
    - Open your react native project in XCode.

    - Copy File UnityConfig.xcconfig to ios/${XcodeProjectName}/.

    - Drag UnityConfig.xcconfig to XCode. Choose Create folder references.

    - Setting .xcconfig to project.

onMessage
    - Receive message from unity.

    - Please copy UnityMessageManager.cs to your unity project and rebuild first.

Example:

    - Send Message use C#.
    - UnityMessageManager.Instance.SendMessageToRN("click");

*Note: to send a message to UnityMessageManager, have to recopy the Manager script to unity project and rebuild first    