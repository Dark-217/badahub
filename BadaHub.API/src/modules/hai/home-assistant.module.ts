import { Module } from '@nestjs/common';
import {HomeAssistantService} from './home-assistant.service';

@Module({
    components: [
        HomeAssistantService
    ]
})
export class HomeAssistantModule {}