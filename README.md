# VR-Camera-Follow
Unity3d camera follow for VR/Oculus

A tiny note; You cannot simply add a "camera follow' script and then set your Unity3d project to "Virtual Reality Supported".   To achieve the result you want:
1) Create an Empty Object (CTRL + SHIFT + N) 
2) Name this something, in my example I have named it "CameraPlatform" (see image within this project)
3) Place a Camera object as the child of the "CameraPlatform" (see left blue arrow)
4) Add CameraPlatform.cs to the "CameraPlatform"
5) Set the object you want the camera to follow in the Target field.
6) Adjust the "Smooth Speed" and "Rotation Damping" to your needs.


Note: I only gathered these functions and information together.   A number of YouTube, Unity Forum and Stackoverflow posts were gathered into a single codebase to give a simple and smooth example.

Notice that in the "Startup" function that there is a check for the "Target" object, and if it is not found it throws an error.   This is to avoid checking for a null value in "LastUpdate" over and over and over...   Small performace update, but every tiny bit can help.
