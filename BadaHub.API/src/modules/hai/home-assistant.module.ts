import { Module } from '@nestjs/common';
import {HomeAssistantService} from './home-assistant.service';

@Module({
    components: [
        HomeAssistantService
    ],
    exports: [
        HomeAssistantService
    ]
})
export class HomeAssistantModule {}