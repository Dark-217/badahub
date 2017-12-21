import 'rxjs/add/observable/from';
import 'rxjs/add/operator/map';
import {Component} from '@nestjs/common';
import {Event} from '../events/models/event';
import {Subject} from 'rxjs/Subject';
import {ReplaySubject} from 'rxjs/ReplaySubject';

let WebSocket = require('websocket').client;

@Component()
export class HomeAssistantService {

    private homeAssistantWebSocket: any;
    private eventStream: Subject<any> = new ReplaySubject();

    constructor() {
        this.homeAssistantWebSocket = new WebSocket();

        this.homeAssistantWebSocket.on('connect', (connection) => {

            this.eventStream.subscribe(data => {
                return connection.send(data)
            });

            connection.on('message', (message) => {
                console.log(message);
            });

            connection.on('close', function (e) {
                console.log('echo-protocol Connection Closed');
            });
        });

        this.homeAssistantWebSocket.connect('ws://192.168.0.8:8123/api/websocket');

    }

    //public broadcastToAllClients = () => this.eventGateway.broadCastToClients();

    public triggerHomeAssistantEvent = (event: Event) => {
        //todo send web socket event to home assistant
        this.eventStream.next(JSON.stringify({
            'id': event.id,
            'type': 'call_service',
            'domain': 'light',
            'service': 'turn_on',
            'service_data': {'entity_id': 'light.bed_light'}
        }));
    }

}