# Brain-Control Game
A game controlled by brain EEG signals.

## Description
This is a simple game where a cube moves forward continuously, and the player can control it by moving it left or right. There are two control methods:

**Keyboard Control**: Use the A and D keys to move the cube left or right.

**EEG Control**: Use your brain signals, collected by an EEG device, to control the game. By imagining the cube moving left or right, you can control its movement without any physical input.

## How It Works
### Keyboard Control
Press A to move the cube left.
Press D to move the cube right.
### EEG Control

**Training**:

Train the application using the OpenVibe software. The training process takes about 15-20 minutes to calibrate the system to your brain signals. Each person needs to train the system individually as the brain signals are unique.

**EEG Devices**:

Compatible with Mobi Smarting and Muse devices. Both have been tested and work well with the game.

**Connection**:

The connection between the game and the EEG device is established using a Python library and Bluetooth.

## Prerequisites
**Hardware**: An EEG device (Mobi Smarting or Muse).
**Software**: OpenVibe for training the EEG device.
**Python Library**: A Python library for Bluetooth connection
