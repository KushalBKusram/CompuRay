## CompuRay with HoloLens

### Description
CompuRay augments the experience involved during troubleshooting or upgrading of a traditional desktop computer. This project makes use of Microsoft HoloLens, the AR device with help of Azure Computer Vision API recognizes various components of the computer and the results are spatially mapped to the real-world through HoloLens. Azure Computer Vision was trained to recognize the following components of a computer cabinet: CPU, Drive Bay, SMPS, GPU, RAM and PCI Slots.

### Interaction
The user shall interact with this HoloLens app through voice commands, except during the phase of analysis. The advantage of voice commands over traditional HoloLens recognizable gestures includes handsfree control along with a more natural UI and almost a zero-learning curve to operate the application.
A demo of this project can be viewed here: [CompuRay Demo](https://youtu.be/kPMvuo2RQSU)

### Documentation
You can refer to our official blog [CompuRay with HoloLens](https://compuray.home.blog) for a detailed documentation. This repo mainly provides you with a Unity project, which might be helpful for you to build something upon.

### Requirements 
HoloLens (1st Gen), Visual Studio 2017, Unity 2017.x, HoloToolKit 2017 (note: not MRTK).

### Usage
Repo consists a Unity project directory.
Clone this repo and point Unity to this repo. Unity should import all the assets into a project for you. However, you will still need to set up Unity for HoloLens application which you can read about in an article that I wrote: [Configuring Unity for HoloLens Application Development](https://medium.com/@KushalBKusram/configuring-unity-for-hololens-application-development-899f79abb4ec)
