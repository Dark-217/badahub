import 'rxjs/add/observable/from';
import 'rxjs/add/operator/map';
import {Component} from '@nestjs/common';
import {Event} from '../events/models/event';
import {BehaviorSubject} from 'rxjs/BehaviorSubject';
let WebSocketClient = require('websocket').client;

@Component()
export class HomeAssistantService {

    private homeAssistantWebSocket: any;
    private _hass: any;
    private requestCount: number = 202;
    private eventStream: BehaviorSubject<string> = new BehaviorSubject("");

    constructor() {
        this.homeAssistantWebSocket = new WebSocketClient();
        this.homeAssistantWebSocket.connect('ws://192.168.0.8:8123/api/websocket');


        this.homeAssistantWebSocket.on('connect', (connection) => {
             this._hass = connection;
             this.eventStream.subscribe(data => {
                 return connection.sendUTF(data)
             });
        });



    }

    //public broadcastToAllClients = () => this.eventGateway.broadCastToClients();

    public triggerHomeAssistantEvent = (event: Event) => {
        //todo send web socket event to home assistant
        this.eventStream.next(JSON.stringify({
            'id': 600,
            'type': 'call_service',
            'domain': 'light',
            'service': 'turn_on',
            'service_data': {'entity_id': 'light.bed_light'}
        }));
        console.log(event)
    }

}