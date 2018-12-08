# GrooVR (pre-release v0.1)
## SJSU Senior Project Group 11 (Spring 2018 - Fall 2018)
### A. Belamide, N. Frangos, T. Le

#### Overview
GrooVR is an open-source VR application. Its primary goal is to make access to expensive equipment such as a drumset readily available to everyone. Miminal hardware is used to keep the startup cost low and all development tools used are free.

#### Requirements
Hardware:
- Android device (API Level >24)
- Google Daydream controller
- VR Viewer (Preferrably Daydream viewer)

Software:
- Android OS 7.0 or later
- Google VR Services
- React Native 0.57
- NPM 5.5.1

#### App Setup
React Native Intallation:  
- Make sure node is installed which can be verified in a shell by entering
  - `node -v`
  - `npm -v`
- After the package manager is setup, download React Native:
  - `npm install -g react-native-cli`
- Clone this repository
  - `git clone https://github.com/TimothyLe/grooVR.git`
  - `cd ./grooVR`
- Check if you have the correct repo then switch to the correct branch 
  - `git remote -v`
  - `git fetch`  
  - `git checkout dev`
- Now you can run the application on your device (_STILL IN BETA_)  
  - `react-native run-ios`
  - `react-native run-android`

Snack Method:
- Go to the Snack Expo website [http://snack.expo.io]
- Click search and type `GrooVR`
- Click 'Run'
- Download the expo app on your device
- Find your device id and enter it on the website
- Refresh the projects page and it should appear!

Manual Installation:
- Pull master branch of the GrooVR GitHub repository [https://github.com/TimothyLe/grooVR/tree/master]
- Navigate to the APKs folder inside the parent directory
- Transfer grooVR.apk to your Android device
- Locate grooVR.apk on your Android device and install it. This step requires permissions to install untrusted apps and varies between devices
- GrooVR app icon should appear on your device. Tap it to run the application

#### Unity3d [https://unity3d.com/]
Unity3d is a cross-platform, real-time game engine on which GrooVR is built off of. It supports Android and iPhone app development, however GrooVR is only officially supported on Android.

#### React Native [https://facebook.github.io/react-native/]
React Native is a framework for building native mobile apps using JavaScript and React. Using React Native perform real time compiling alongside your project to develop quickly and test development issues. Another key feature is the native compatibility with iOS and Android devices thanks to binaries generated for both devices. 

#### Node [https://nodejs.org/]
Node is a Javascript runtime environment used in backend operations in the form of data requests and posts. Node also comes with NPM, which stands for Node Package Manager, that allows for projects like ours to be configured with multiple dependencies for modularity and reusability with GrooVR. 

#### Snack [http://snack.expo.io]
Snack is a web browser built-in IDE specialized for React Native applications. Snack provides real time simulations of iOS and Android devices alongside a text editor in a browser and also provides a development server to load the application onto the user's phone. It comes in handy during the rapid application development process. 

#### Modifying Source
Modifying the source code is encouraged! Reactive Native makes rapid development easier. NOTE: We are not responsible for any licensing/legal issues you may encounter while developing with GrooVR.

#### Credits
Special thanks to:
- Ahmed Banafa (Project Advisor)
- Robert Bruce (Project Mentor)
- Rod Fatoohi  (CmpE Associate Chair)
- Sevastian Marevoy (Unity Assets) [https://assetstore.unity.com/publishers/26980]  
- Jiulong Wang (React Assets) [https://www.npmjs.com/package/react-native-unity-view]

