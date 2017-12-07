# BadaHub.API
[Nest](https://nestjs.com/)/[TypeORM](http://typeorm.io) WebSocket API that serves as the middleware between the clients and the Home Assistant instance. Also allows for extension beyond Home Assistant to any other 3rd party API.

### ToDo
- [x] Create a WebSocket server
- [ ] Make a request to the server, return state change to seperate device (phone)
- [ ] Set up ngrx event bus to save events to MySQL then broadcast via WS
- [ ] Set up Mock Home Assistant (MHA) project (seperate folder/project?)
- [ ] Trigger MHA state change, break inside API, transform to global IBadaHubEvent, return to computer and phone
- [ ] Microservice for talking to IRKit
- [ ] Authentication module/middleware using JWT
- [ ] Implement [SSL](https://www.google.com/search?q=nginx+docker+ssl&rlz=1C1MKDC_enUS768US768&oq=nginx+docker+ssl&aqs=chrome..69i57j0l4.2543j0j7&sourceid=chrome&ie=UTF-8) and WSS

Note: This project was originally going to be developed in .NET Core/EF core, but SignalR for .NET Core is currently [a work in progress](https://github.com/aspnet/SignalR). Doing this API without a Websocket framework would have been unwise.
