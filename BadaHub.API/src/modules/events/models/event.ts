export interface Event {
    type: EventType;
    entity: Entity;
    payload: any;
    timeFired: Date;
    origin: User;
}

// change state of IR
export enum EventType{

}

export interface User{
    id: Guid;
    name: string;
}

export interface Guid{

}

//IR, Bedroom Light switch, garage door, etc.
export interface Entity{

}