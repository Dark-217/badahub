# BadaHub.API
[Nest](https://nestjs.com/)/[TypeORM](http://typeorm.io) WebSocket API that serves as the middleware between the clients and the Home Assistant instance. Also allows for extension beyond Home Assistant to any other 3rd party API.

### ToDo
- [x] Create a WebSocket server
- [ ] Make a request to the server, return state change to seperate device (phone)
- [ ] Set up Mock Home Assistant (MHA) project (seperate folder/project?)
- [ ] Trigger MHA state change, break inside API, transform to global IBadaHubEvent, return to computer and phone
- [ ] Microservice for taling to IRKit
- [ ] Authentication using JWT
- [ ] Implement SSL and WSS

Note: This project was originally going to be developed in .NET Core/EF core, but SignalR for .NET Core is currently [a work in progress](https://github.com/aspnet/SignalR). Doing this API without a Websocket framework would have been unwise.
