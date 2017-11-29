# BadaHub.API
.NET Core/EF Core WebSocket API that serves as the middleware between the clients and the Home Assistant instance. Also allows for extension beyond Home Assistant to any other 3rd party API.

### ToDo
- [ ] Create a WebSocket server
- [ ] Make a request to the server, return state change to seperate device (phone)
- [ ] Set up Mock Home Assistant (MHA) project (seperate folder/project?)
- [ ] Trigger MHA state change, break inside API, transform to global IBadaHubEvent, return to computer and phone
