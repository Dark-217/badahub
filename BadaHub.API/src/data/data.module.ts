import { Module } from '@nestjs/common';
import { databaseProviders } from './data.providers';

@Module({
    components: [...databaseProviders],
    exports: [...databaseProviders],
})
export class DataModule {}