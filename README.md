# BadaHub 🏠
.NET Core/Angular/WebSocket home automation platform for the Bada household

### Household as Code
This project is an experiment in building a home automation platform using an amalgamation of technologies. After studying the topic of "infrastructure as code," I wondered what it would be like to build a "household as code;" a series of moving peices and projects that could be easily deployed, managed, and customized. Together, these peices would form a single purpose: household/home server automation and monitoring.

### Table of Contents
1. [BadaHub - Overview](badahub)
   
   Basic architecture and purpose of project.

2. [BadaHub - API](BadaHub.API)

   .NET Core/EF Core WebSocket API running in a Docker container on JoeBadsHomeServer (JBHS). Serves as a decoupling of Home Assistant and the clients dispersed in and outside of the house. Enables the ability to interface with Home Assistant and any other 3rd party API.

3. [BadaHub - Client](BadaHub.Client)

   BenjaOS/Electron/Ionic/Angular bootable kiosk application and mobile application. The goal of the Client project is to develop a set of code that can be deployed to everything (with the priority being a boot-to-app tablet and mobile phones).

4. [BadaHub - Snips](BadaHub.Snips)

   On device AI with Snips. This purpose of this project is to build a completely open source voice-driven assistant. 

### Resources
* [Google Doc with links and notes](https://goo.gl/upCyLR)
* [Google Sheet with list of intended integrations](https://goo.gl/FEHGTD)

### Architecture
![alt text](https://raw.githubusercontent.com/joe307bad/badahub/master/architecture.png)
