# SignalRCoreDemos
Repo containing various demos with SignalR Core. These were pretty much recreated from the talk by Damian Edwards and David
Fowler given at [Microsoft Build 2017](https://channel9.msdn.com/events/Build/2017/B8078).

**Note:** You'll need to have .NET Core 2.0 preview 1 installed on yourt machine to run these demos. I've build and tested
these on OSX, but they should work on Windows and Linux as well.

## SignalRCore
This is a demo of the most basic things you'll need to setup in order to get started with SignalR Core. Its an empty ASP.NET
Core application with SignalR Core added to it and a client written in pure JavaScript.

## SignalRCoreRedis
Shows scale-out using Redis. It includes user tracking including authentication. Note that you'll need to have a Redis server
setup to run this demo, which you can get up and running fairly easily with Docker for Windows or Docker for Mac.

## Sockets
Contains two ASP.NET Core Sockets endpoints, one which just broadcasts messages and one that receives images in binary form
and broadcasts those in either binary format or as ASCII art.

## SocketClient
A client that can be used with the above Sockets demo to write out the broadcasted image that is captured by the browser as
an ASCII art image on the console.
