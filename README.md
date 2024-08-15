
# Unity Video Player

A fully interactive video player built with Unity, demonstrating various features such as video playback controls, volume adjustment, progress tracking, and more. This project showcases skills in UI design, multimedia handling, and C# scripting within the Unity environment.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [Video Controls](#video-controls)
  - [Volume Control](#volume-control)
  - [Progress Bar](#progress-bar)
  - [Full-Screen Toggle](#full-screen-toggle)
  - [Mute/Unmute](#muteunmute)
- [Customization](#customization)
  - [Changing Videos](#changing-videos)
  - [UI Customization](#ui-customization)
- [Contributing](#contributing)
- [License](#license)

## Features
- **Video Playback Controls**: Play, Pause, Stop video playback with simple buttons.
- **Volume Control**: Adjust the audio level using a slider.
- **Progress Bar**: Track and seek through the video with a progress bar.
- **Full-Screen Toggle**: Switch between windowed and full-screen modes.
- **Mute/Unmute**: Quickly mute or unmute the video audio.
- **Object Interaction**: Includes basic interaction with 3D objects in the scene.

## Getting Started

### Prerequisites
- **Unity**: This project was built using Unity 2021.x or later. Ensure you have Unity installed.
- **Git**: To clone the repository.
- **Visual Studio**: Recommended for C# scripting.

### Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/UnityVideoPlayer.git
   ```
2. **Open the Project in Unity**:
   - Launch Unity Hub and click `Open Project`.
   - Navigate to the cloned directory and open the project.

3. **Install Dependencies**:
   - Unity will automatically install any required packages listed in the `Packages/manifest.json` file.

## Usage

### Video Controls
- **Play**: Click the "Play" button to start the video.
- **Pause**: Click the "Pause" button to pause the video.
- **Stop**: Click the "Stop" button to stop the video playback.

### Volume Control
- **Adjust Volume**: Use the volume slider to increase or decrease the audio level.

### Progress Bar
- **Track Progress**: The progress bar shows the current position in the video.
- **Seek Video**: Click and drag the progress bar to seek to a different part of the video.

### Full-Screen Toggle
- **Toggle Full-Screen**: Click the "Full Screen" button to switch between windowed and full-screen modes.

### Mute/Unmute
- **Mute Audio**: Click the "Mute" button to mute the audio.
- **Unmute Audio**: Click the "Unmute" button to restore the audio.

## Customization

### Changing Videos
- **Replace Video File**: To change the video being played, simply replace the video file in the `Assets/Videos/` folder and update the reference in the Unity Editor.

### UI Customization
- **Button Text**: Use TextMeshPro to customize the text on buttons.
- **UI Layout**: Adjust the layout, colors, and styles of UI elements in the Unity Editor.

## Contributing
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a Pull Request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
