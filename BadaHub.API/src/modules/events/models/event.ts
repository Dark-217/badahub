import {Guid} from './guid';
import {EventType} from './event-type';
import {Entity} from './entity';
import {User} from './user';
import {JBHSService} from './jbhs-service';

export interface Event {
    // todo change to guid
    id: string,
    type: EventType;
    entity: Entity;
    payload: any;
    timeFired: Date;
    origin: User | JBHSService;
}







