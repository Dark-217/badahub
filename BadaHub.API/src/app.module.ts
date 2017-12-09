import { Module } from '@nestjs/common';
import { EventsModule } from './modules/events/events.module';
import {DataModule} from './data/data.module';
import {HomeAssistantModule} from './modules/hai/home-assistant.module';

@Module({
    modules: [
        EventsModule
        // DataModule
    ],
    exports: [
        EventsModule
    ]
})
export class ApplicationModule {}