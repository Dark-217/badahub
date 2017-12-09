import 'rxjs/add/observable/from';
import 'rxjs/add/operator/map';
import {Component, Inject} from '@nestjs/common';
import {Event} from '../events/models/event';
let W3CWebSocket = require('websocket').w3cwebsocket;

@Component()
export class HomeAssistantService {

    private homeAssistantWebSocket: WebSocket;
    private isConnected: boolean = false;

    constructor() {
        if(!this.isConnected) {
            this.isConnected = true;
            var client = new W3CWebSocket('ws://192.168.0.8:8123/api/websocket');

            client.onopen = function(data) {
                console.log('WebSocket Client Connected');

            };
        }
        // this.homeAssistantWebSocket = new WebSocket('ws://192.168.0.8:8123/api/websocket');
        //
        // this.homeAssistantWebSocket.on('connection', function open(data) {
        //     console.log("hey");
        // });
    }

    // public broadcastToAllClients = () => this.eventGateway.broadCastToClients();

    public triggerHomeAssistantEvent = (event: Event) => {
        //todo send web socket event to home assistant
        console.log(event)
    }

}