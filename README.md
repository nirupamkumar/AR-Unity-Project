# AR Unity Project — Image Tracking

> **Project Status: University Coursework — Not Actively Maintained**

## Overview

This repository contains an augmented reality (AR) application developed using Unity and Vuforia Engine as part of a university course assignment.

The project demonstrates image-based tracking, where virtual vehicles appear when the application recognizes predefined image targets.

Users can interact with and control the vehicles using keyboard inputs or on-screen Android joystick controls.

The project explores foundational concepts of augmented reality, image recognition, virtual object placement, and user interaction.

## Features

### Image Target Tracking

- Image-based tracking using Vuforia Engine
- Detection of predefined image targets
- Placement and display of virtual vehicles associated with tracked targets

### Vehicle Controls

- Keyboard controls using W, A, S, and D
- Android on-screen joystick controls
- Interaction with vehicles displayed in the AR environment

### Project Management

- Git LFS (Large File Storage) used for managing large project assets

## Technology Stack

| Component | Technology |
|---|---|
| Game Engine | Unity |
| Programming Language | C# |
| AR SDK | Vuforia Engine |
| Tracking Method | Image Target Tracking |
| Input | Keyboard and Android Joystick |
| Version Control | Git and Git LFS |
| Project Type | University Coursework |

## Screenshots

### Image Target Setup

![Image Target Setup](https://user-images.githubusercontent.com/63305439/232338363-b0d340cf-2aaa-4f4e-9fb1-c4a66a567379.jpg)

### AR Vehicle Tracking and Controls

![AR Vehicle Tracking](https://user-images.githubusercontent.com/63305439/232338403-b350cc05-2d3a-4a8a-aafb-5c40e498b429.jpg)

## Project Structure

| Directory | Description |
|---|---|
| `Assets/` | Unity scenes, scripts, models, and AR assets |
| `Packages/` | Unity package dependencies |
| `ProjectSettings/` | Unity project configuration |
| `QCAR/` | Vuforia-related project data |
| `UserSettings/` | Unity editor user settings |

## Running the Project

1. Clone the repository:

   `git clone https://github.com/nirupamkumar/AR-Unity-Project.git`

2. Ensure Git LFS is installed and retrieve any required LFS assets:

   `git lfs pull`

3. Open Unity Hub and add the cloned project.
4. Check `ProjectSettings/ProjectVersion.txt` for the Unity Editor version.
5. Ensure the project's Vuforia dependencies and required configuration are available.
6. Open the appropriate AR scene.
7. Use the configured image targets to test tracking.

A compatible camera and supported runtime environment may be required.

Compatibility with current Unity and Vuforia releases has not been verified.

## Academic Background

This project was developed as part of university coursework during my master's studies in Game Development at Algebra University College, Zagreb, Croatia.

The assignment provided practical experience with:

- Augmented reality fundamentals
- Image target recognition and tracking
- Placing virtual objects in AR
- Input handling across different platforms
- Unity and Vuforia integration
- Managing large assets using Git LFS

## Development Status

The original coursework development period has ended.

The repository is preserved as an academic project and historical reference. No active maintenance is planned.

## Author

**Nirupam Kumar Mundra**

[GitHub Profile](https://github.com/nirupamkumar)
