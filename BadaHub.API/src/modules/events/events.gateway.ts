import { WebSocketGateway, SubscribeMessage, WsResponse, WebSocketServer, WsException } from '@nestjs/websockets';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/from';
import 'rxjs/add/operator/map';
import {Event} from './models/event';
import {EventType} from './models/event-type';
import {HomeAssistantService} from '../hai/home-assistant.service';
import {Component} from '@nestjs/common';

@Component()
@WebSocketGateway(81)
export class EventsGateway {
  @WebSocketServer() server;

  constructor(private homeAssistantService: HomeAssistantService) { }

  @SubscribeMessage('events')
  onEvent(client, data): Observable<WsResponse<number>> {
    const submittedEvent = data as Event;
    const event = 'events';
    const response = [1, 2, 3];
    return Observable.from(response)
        .map((res) => ({ event, data: res }));
  }

  @SubscribeMessage('home-assistant')
  onHa(client, data): Observable<WsResponse<number>> {

    //todo add mysql events
    this.homeAssistantService
        .triggerHomeAssistantEvent(data as Event);
        // .then(() => saveEventToMySql());
        // .catch(() => logError());

    const event = 'events';
    const response = [1, 2, 3];
    return Observable.from(response)
        .map((res) => ({ event, data: res }));
  }

  public broadCastToClients() {
    this.server.clients.forEach(function each(client) {
      if (client.readyState === 1) {
        client.send('{"hey": "there"}');
      }
    });
  }

}