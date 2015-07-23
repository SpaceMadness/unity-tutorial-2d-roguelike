# 2D Roguelike made easy with Lunar

This is a modified version of [Unity 2D Roguelike Tutorial](https://unity3d.com/learn/tutorials/projects/2d-roguelike-tutorial) used in Lunar Plugin [presentation](http://www.meetup.com/Seattle-Unity3D/events/224052872/). Includes custom commands for days and food management.

**Requires Lunar v0.0.3b or later**

## Installation

Open project in Unity Editor and import [Lunar plugin](https://goo.gl/xo5IIf) from the Asset Store.

## Commands

**Days management:**  
* [day](https://github.com/SpaceMadness/unity-tutorial-2d-roguelike/blob/master/Assets/Editor/Commands.cs#L37-L44): starts Nth day.
* [restart](https://github.com/SpaceMadness/unity-tutorial-2d-roguelike/blob/master/Assets/Editor/Commands.cs#L10-L17): restarts current day.
* [prev](https://github.com/SpaceMadness/unity-tutorial-2d-roguelike/blob/master/Assets/Editor/Commands.cs#L28-L35): starts prev day.
* [next](https://github.com/SpaceMadness/unity-tutorial-2d-roguelike/blob/master/Assets/Editor/Commands.cs#L19-L26): starts next day.
  
**Food management:**  
* [food](https://github.com/SpaceMadness/unity-tutorial-2d-roguelike/blob/master/Assets/Editor/Commands.cs#L50-L65): overrides food amount.  
   
For more info check [Commands](https://github.com/SpaceMadness/lunar-unity-plugin/wiki/Commands) user guide.

## Key Bindings
`bind [ prev`  
`bind ] next`  
`bind r restart`  
  
For more info check [Keys Binding](https://github.com/SpaceMadness/lunar-unity-plugin/wiki/Key-Binding) user guide.  

## Project Tutorial
For more info, please, check the official project [tutorial](http://goo.gl/je1cpc).
