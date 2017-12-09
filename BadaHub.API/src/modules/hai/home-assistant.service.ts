import 'rxjs/add/observable/from';
import 'rxjs/add/operator/map';
import {Component, Inject} from '@nestjs/common';
import {Event} from '../events/models/event';
import * as WebSocket from 'ws';

@Component()
export class HomeAssistantService {

    private homeAssistantWebSocket: WebSocket;

    constructor() {
        this.homeAssistantWebSocket = new WebSocket('ws://192.168.0.8:8123/api/websocket');

        this.homeAssistantWebSocket.on('open', function open(data) {
            console.log("hey");
        });
    }

    // public broadcastToAllClients = () => this.eventGateway.broadCastToClients();

    public triggerHomeAssistantEvent = (event: Event) => {
        //todo send web socket event to home assistant
        console.log(event)
    }

}