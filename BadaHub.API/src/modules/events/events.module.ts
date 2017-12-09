import { Module } from '@nestjs/common';
import { EventsGateway } from './events.gateway';
import {HomeAssistantModule} from '../hai/home-assistant.module';
import {HomeAssistantService} from '../hai/home-assistant.service';

@Module({
    modules: [HomeAssistantModule],
    components: [EventsGateway]
})
export class EventsModule {}