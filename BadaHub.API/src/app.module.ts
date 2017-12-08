import { Module } from '@nestjs/common';
import { EventsModule } from './modules/events/events.module';
import {DataModule} from './data/data.module';

@Module({
    modules: [
        EventsModule
        // DataModule
    ],
})
export class ApplicationModule {}