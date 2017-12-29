# BadaHub.API
.NET Core/EF Core/SignalR WebSocket API that serves as the middleware between the clients and 3rd party APIs. Also records history in SQL Server.

### ToDo
- [x] Create a WebSocket server
- [x] Implement DDD from [Equinox Project](https://github.com/EduardoPires/EquinoxProject)
- [ ] Make a request to the server, return state change to seperate device (phone)
- [ ] Set up event bus to trigger event (to HASS or 3rd party), save events to SQL Server then broadcast via WS
- [ ] Log errors to file (set up file watcher later to parse and display recent errors)
- [ ] Microservice for talking to IRKit
- [ ] Authentication module/middleware using JWT
- [ ] Implement [SSL](https://www.google.com/search?q=nginx+docker+ssl&rlz=1C1MKDC_enUS768US768&oq=nginx+docker+ssl&aqs=chrome..69i57j0l4.2543j0j7&sourceid=chrome&ie=UTF-8) and WSS
